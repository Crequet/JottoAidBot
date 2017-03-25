using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JottoAidBot
{
    public partial class wordfinderForm : Form
    {
        string[] wordliststringviews;
        bool[][] wordlistlogicalviews;
        List<BooleanNode[]> conditions;
        int maxuniquelettercount;
        int minuniquelettercount;

        public wordfinderForm(ref List<BooleanNode[]> conditions)
        {
            InitializeComponent();
            wordliststringviews = Properties.Resources.allwordsdictionarytxtfile.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            initializewordlistlogicalviews();
            this.conditions = conditions;
        }

        public List<BooleanNode[]> Conditions
        {
            set
            {
                conditions = value;
            }
        }

        public int MaximumUniqueLetterCount
        {
            set
            {
                maxuniquelettercount = value;
            }
        }
        
        public int MinimumUniqueLetterCount
        {
            set
            {
                minuniquelettercount = value;
            }
        }

        void initializewordlistlogicalviews()
        {
            wordlistlogicalviews = new bool[wordliststringviews.Length][];

            for (int i=0; i < wordliststringviews.Length; i++)
            {
                wordlistlogicalviews[i] = LayerOperation.GetLogicalView(wordliststringviews[i]);
            }
        }

        private void dosearchbutton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            possiblewordlist.BeginUpdate();
            possiblewordlist.SuspendLayout();
            possiblewordlist.Items.Clear();   
            for (int i = 0; i < wordliststringviews.Length; i++)
            {
                if (isvalidword(i))
                    possiblewordlist.Items.Add(wordliststringviews[i]);
            }
            possiblewordlist.ResumeLayout();
            possiblewordlist.EndUpdate();
            ResumeLayout();
        }

        bool containsduplicate(string word)
        {
            for(int i = 0; i < word.Length - 1; i++)
            {
                for (int j = i + 1; j < word.Length ; j++)
                {
                    if (word[i] == word[j]) return true;
                }
            }
            return false;
        }

        bool matcheswithatleastonecondition(int index)
        {
            for (int i =0; i < conditions.Count; i++)
            {
                if (LayerOperation.LayersMatch(conditions[i], wordlistlogicalviews[index])) return true;
            }
            return false;
        }
        
        bool isvalidword(int index)
        {
            if (noduplicatecheckbox.Checked && containsduplicate(wordliststringviews[index])) return false;
            if (minimumwordlengthcheckbox.Checked && wordliststringviews[index].Length > minimumwordlengthnumericupdown.Value) return false;
            if (maximumwordlengthcheckbox.Checked && wordliststringviews[index].Length < maximumwordlengthnumericupdown.Value) return false;
            if (maxuniquelettercount != 0 && wordlistlogicalviews[index].TrueCount() > maxuniquelettercount) return false;
            if (minuniquelettercount != 0 && wordlistlogicalviews[index].TrueCount() < minuniquelettercount) return false;
            if (matcheswithatleastonecondition(index)) return true;
            return false;
        }

        private void wordfinderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void maximumwordlengthcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            maximumwordlengthnumericupdown.Enabled = maximumwordlengthcheckbox.Checked;
        }

        private void minimumwordlengthcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            minimumwordlengthnumericupdown.Enabled = minimumwordlengthcheckbox.Checked;
        }
    }
}
