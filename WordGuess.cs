using System.Collections.Generic;
using System.Linq;

namespace JottoAidBot
{

    public class WordGuess
    {
        int subsize;
        string word;

        public WordGuess(string Word, int SubSize)
        {
            this.word = Word;
            this.subsize = SubSize;
        }

        public int SubSize
        {
            get
            {
                return subsize;
            }
        }

        public string Word
        {
            get
            {
                return word;
            }
        }

        public int Size
        {
            get
            {
                return word.Length;
            }
        }

    }
    public class SubLayerCollection
    {
        string wordstringview; bool[] wordlogicalview;
        bool[][] sublayers; int[] activeindexes; int maximumdepth; int steps;  long counter;

        public SubLayerCollection(ref WordGuess wordguess)
        {
            wordstringview = wordguess.Word;
            initializeWordLogicalView();
            activeindexes = new int[wordguess.SubSize];
            counter = 0;
            initializeSubLayers(getcombinationcount(wordguess.Size, wordguess.SubSize));
            maximumdepth = wordguess.SubSize - 1;
            steps = wordguess.Size - wordguess.SubSize + 1;
            generateSubLayers();
        }

        public bool[] WordLogicalView
        {
            get
            {
                return wordlogicalview;
            }
        }

        public bool[][] SubLayers
        {
            get
            {
                return sublayers;
            }
        }

        void initializeWordLogicalView()
        {
            wordlogicalview = LayerOperation.GetLogicalView(wordstringview);
        }

        void initializeSubLayers(long sublayerlength)
        {
            sublayers = new bool[sublayerlength][];
        }

        long getcombinationcount(int size, int subsize)
        {
            subsize = (subsize > size / 2F) ? size - subsize : subsize;
            long numerator = size, denominator = subsize;
            for (long i = denominator - 1; i > 0; i--)
            {
                numerator *= (size - i);
                denominator *= (subsize - i);
            }
            return denominator == 0 ? 1 : numerator / denominator;
        }

        void generateSubLayers()
        {
            if (maximumdepth == -1) addLayer(); else generateSubLayers(0, 0); 
        }

        void generateSubLayers(int min, int depth)
        {
            for (activeindexes[depth] = min; activeindexes[depth] < (min + steps > wordstringview.Length ? wordstringview.Length: min + steps) ; activeindexes[depth]++)
            {
                if (depth >= maximumdepth)
                {
                    addLayer();
                }
                else
                {
                    generateSubLayers(activeindexes[depth] + 1, depth + 1);
                }
            }
        }

        void addLayer()
        {
            string layerstringview = "";
            foreach(int index in activeindexes)
            {
                layerstringview += wordstringview[index];
            }
            sublayers[counter] = LayerOperation.GetLogicalView(layerstringview);
            counter++;
        }

    }

    public static class LayerOperation
    {
        public static int TrueCount(this BooleanNode[] layer)
        {
            int count = 0;
            for (int i = 0; i < layer.Length; i++)
            {
                if (layer[i].Value == 'T')
                {
                    count++;
                }
            }
            return count;
        }
        public static int TrueCount(this bool[] layer)
        {
            int count = 0;
            for (int i = 0; i < layer.Length; i++)
            {
                if (layer[i] == true)
                {
                    count++;
                }
            }
            return count;
        }

        public static int NotTrueCount(this BooleanNode[] layer)
        {
            return layer.Length - layer.TrueCount();
        }
        public static int FalseCount(this BooleanNode[] layer)
        {
            int count = 0;
            for (int i = 0; i < layer.Length; i++)
            {
                if (layer[i].Value == 'F')
                {
                    count++;
                }
            }
            return count;
        }

        public static int NotFalseCount(this BooleanNode[] layer)
        {
            return layer.Length - layer.FalseCount();
        }

        public static bool[] GetLogicalView(string word)
        {
            bool[] logicalview = new bool[26];
            for (int i = 0; i < word.Length; i++)
            {
                logicalview[word[i] - 97] = true;
            }
            return logicalview;
        }

        public static BooleanNode[][] BlendLayers(bool[][] layers, bool[] layer)
        {
            BooleanNode[][] output = new BooleanNode[layers.Length][];
            BooleanNode[] newlayer;
            for (int i =0; i<layers.Length; i++)
            {
                newlayer = new BooleanNode[layers[i].Length];
                for (int j = 0; j < layers[i].Length; j++)
                {
                    if (layer[j] != false)
                    {
                        newlayer[j].SetValue(layers[i][j]);
                    }
                }
                output[i] =newlayer.ToArray();
            }
            return output;
        }

        public static BooleanNode[] BlendLayers(bool[] layer0, bool[] layer)
        {
            BooleanNode[] output = new BooleanNode[layer0.Length];
            for (int i = 0; i < layer0.Length; i++)
            {
                if (layer[i] != false)
                {
                    output[i].SetValue(layer0[i]);
                }
            }
            return output;
        }

        public static bool TryUnionLayers(BooleanNode[] layer1, BooleanNode[] layer2, out BooleanNode[] output)
        {
            output = new BooleanNode[layer1.Length];
            for(int i = 0; i < layer1.Length; i++)
            {
                if (layer1[i].Value == '?' && layer2[i].Value == '?')
                {
                    continue;
                }
                else if (layer1[i].Value == layer2[i].Value)
                {
                    output[i] = layer1[i];
                }
                else if (layer1[i].Value == '?')
                {
                    output[i] = layer2[i];
                }
                else if (layer2[i].Value == '?')
                {
                    output[i] = layer1[i];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool LayersMatch(BooleanNode[] layer1, bool[] layer2)
        {
            for (int i = 0; i < layer1.Length; i++)
            {
                if (!(layer1[i].Value == '?' || (layer1[i].Value == 'T' && layer2[i] == true) || (layer1[i].Value == 'F' && layer2[i] == false)))
                {
                    return false;
                }
            }
            return true;
        }

        public static char MergeNodes(char node1Value, char node2Value)
        {
            return (node1Value == 'T' && node2Value == 'T') ? 'T' : (node1Value == 'F' && node2Value == 'F') ? 'F' : ((node1Value == 'C' && node2Value == 'T') || (node1Value == 'C' && node2Value == 'F') || (node1Value == 'T' && node2Value == 'F') || (node1Value == 'F' && node2Value == 'T')) ? 'C' : '?';
        }

    }
    public struct BooleanNode
    {
        bool active;
        bool value;

        public char Value
        {
            get
            {
                return this.active ? (this.value ? 'T' :  'F') : '?';
            }
            set
            {
                this.active = true;
                this.value = value == 'T' ? true : false;
                
            }
        }

        public void SetValue(bool value)
        {
            active = true;
            this.value = value;
        }

        public void Reset()
        {
            active = false;
            value = false;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
    public class WordGuessCollection
    {
        List<WordGuess> wordguesses;
        List<bool[]> wordguesseslogicalview;
        List<BooleanNode[]> possiblelayercombinations;
        int startindex;
        public delegate void PossibleLayerCombinationsHandler();
        public event PossibleLayerCombinationsHandler PossibleLayerCombinationsChanged;

        public WordGuessCollection()
        {
            PossibleLayerCombinationsChanged += OnPossibleLayerCombinationsChanged;
            wordguesses = new List<WordGuess>();
            wordguesseslogicalview = new List<bool[]>();
            possiblelayercombinations = new List<BooleanNode[]>();
            startindex = 0;
        }

        public List<BooleanNode[]> PossibleLayerCombinations
        {
            get
            {
                return possiblelayercombinations;
            }
        }

        public void OnPossibleLayerCombinationsChanged()
        {
            //Doo doo roo doo dooo
        }

        public void Add(WordGuess wordguess)
        {
            wordguesses.Add(wordguess);
            wordguesseslogicalview.Add(LayerOperation.GetLogicalView(wordguess.Word));
        }

        public void RemoveAt(int index)
        {
            wordguesses.RemoveAt(index);
            wordguesseslogicalview.RemoveAt(index);
            possiblelayercombinations.Clear();
            startindex = 0;
            PossibleLayerCombinationsChanged();
        }

        public void Clear()
        {
            wordguesses.Clear();
            wordguesseslogicalview.Clear();
            possiblelayercombinations.Clear();
            startindex = 0;
        }

        public void Run()
        {
            if (wordguesses.Count == 0) return; //just for safechecking
            //else continue;
            
            for (int i = startindex; i < wordguesses.Count; i++)
            {
                addWordGuess(wordguesses[i]);
            }
            if (startindex < wordguesses.Count)
            {
                PossibleLayerCombinationsChanged();
            }
            startindex = wordguesses.Count;
        }

        void addWordGuess(WordGuess wordguess)
        {
            if (possiblelayercombinations.Count == 0)
            {
                SubLayerCollection slc = new SubLayerCollection(ref wordguess);
                possiblelayercombinations.AddRange(LayerOperation.BlendLayers(slc.SubLayers, slc.WordLogicalView));
            }
            else
            {
                List<BooleanNode[]> newpossiblelayercombinations = new List<BooleanNode[]>();
                BooleanNode[] x; //potential new layer
                SubLayerCollection slc = new SubLayerCollection(ref wordguess);
                for(int i = 0; i < possiblelayercombinations.Count; i++)
                {
                    for (int j = 0; j < slc.SubLayers.Length; j++)
                    {
                        if (LayerOperation.TryUnionLayers(possiblelayercombinations[i], LayerOperation.BlendLayers(slc.SubLayers[j], slc.WordLogicalView), out x))
                        {
                            newpossiblelayercombinations.Add(x);
                        }
                    }
                }
                possiblelayercombinations = newpossiblelayercombinations;
            }
        }

    }

}
