using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JottoAidBot
{
    public partial class mainForm : Form
    {
        int[] letteroccurencerate;
        char[] buttoncolorindicators;
        WordGuessCollection wgc;
        List<BooleanNode[]> filteredlist;

        public mainForm()
        {
            InitializeComponent();
            wgc = new WordGuessCollection();
            wgc.PossibleLayerCombinationsChanged += possiblecombinationslist_Update;
            wgc.PossibleLayerCombinationsChanged += atozbuttons_Update;
            possiblecombinationslist_Update(); atozbuttons_Update();
            
        }

        private void mainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            jottotooltip.Show("Hover the mouse over form elements to reveal help information" + Environment.NewLine + "To disable help information, uncheck the checkbox at the bottom-right corner" , this, 7, 0, 3000);
            e.Cancel = true;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.possiblecombinationslist.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void wordtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                addbutton_Click(sender, e);
            }
        }
        
        private void addbutton_Click(object sender, EventArgs e)
        {
            string word = ""; int num = 0; bool fillnum = false;
            for(int i =0; i < wordtext.Text.Length ;i++)
            {
                if (fillnum)
                {
                    if (char.IsDigit(wordtext.Text[i])) num = (num * 10) + int.Parse(wordtext.Text[i].ToString());
                }
                else
                {
                    if (wordtext.Text[i] == ',') fillnum = true;
                    else if (char.IsLetter(wordtext.Text[i])) word += wordtext.Text[i];
                }
            }
            word = new string(word.ToLower().ToCharArray().Distinct().ToArray());
            num = num > word.Length ? word.Length : num;
            wordtext.Clear();
            wordlist.Items.Add(word + ", " + num);
            wgc.Add(new WordGuess(word, num));
            wgc.Run();
            
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            
            wordlist.BeginUpdate();
            foreach(int i in wordlist.SelectedIndices)
            {
                wordlist.Items.RemoveAt(i);
                wgc.RemoveAt(i);
                if (wordlist.Items.Count > 0)
                {
                    wordlist.SelectedIndex = i > wordlist.Items.Count - 1 ? wordlist.Items.Count - 1 : i;
                }                
            }
            wordlist.EndUpdate();
            wgc.Run();
        }
        
        private void possiblecombinationslist_Update()
        {
            if (!updatelistcheckbox.Checked) return;
            possiblecombinationslist.BeginUpdate();
            SuspendLayout(); possiblecombinationslist.SuspendLayout();
            possiblecombinationslist.Items.Clear();
            filteredlist = new List<BooleanNode[]>();

            if (maxnottcountcheckbox.Checked || minnottcountcheckbox.Checked)
            {
                for (int i = 0; i < wgc.PossibleLayerCombinations.Count; i++)
                {
                    if (maxnottcountcheckbox.Checked && wgc.PossibleLayerCombinations[i].NotTrueCount() > 26 - maxnottcountnumericupdown.Value) continue;
                    if (minnottcountcheckbox.Checked && wgc.PossibleLayerCombinations[i].NotTrueCount() < 26 - minnottcountnumericupdown.Value) continue;
                    filteredlist.Add(wgc.PossibleLayerCombinations[i]);
                }
            }
            else
            {
                for (int i = 0; i < wgc.PossibleLayerCombinations.Count; i++)
                {
                    filteredlist.Add(wgc.PossibleLayerCombinations[i]);
                }
            }

            if (filteredlist.Count <= 0)
            {
                List<BooleanNode[]> defaultvalue = new List<BooleanNode[]>();
                defaultvalue.Add(new BooleanNode[26]);
                filteredlist = defaultvalue;
            }

            for (int i = 0; i < filteredlist.Count; i++)
            {
                possiblecombinationslist.Items.Add(i.ToString());
                for (int j = 0; j < filteredlist[i].Length; j++)
                {
                    possiblecombinationslist.Items[i].SubItems.Add(filteredlist[i][j].ToString());
                }
            }

            ResumeLayout(); possiblecombinationslist.ResumeLayout();
            possiblecombinationslist.EndUpdate();
        }

        private void atozbuttons_Update()
        {
            if (!updatelistcheckbox.Checked) return;
            buttoncolorindicators = new char[26];
            letteroccurencerate = new int[26];
            for (int i = 0; i < 26; i++)
            {
                buttoncolorindicators[i] = possiblecombinationslist.Items[0].SubItems[i + 1].Text[0];
                letteroccurencerate[i] = possiblecombinationslist.Items[0].SubItems[i + 1].Text[0] == 'T' ? 1 : 0;
                for (int j = 1; j < possiblecombinationslist.Items.Count; j++)
                {
                    if (buttoncolorindicators[i] == '?')
                    {
                        break;
                    }
                    buttoncolorindicators[i] = LayerOperation.MergeNodes(buttoncolorindicators[i], possiblecombinationslist.Items[j].SubItems[i + 1].Text[0]);
                    if (possiblecombinationslist.Items[j].SubItems[i + 1].Text[0] == 'T') letteroccurencerate[i]++;
                }

                if (buttoncolorindicators[i] == '?')
                {
                    buttonspanel.Controls[i].BackColor = Color.FromKnownColor(KnownColor.Control);
                    buttonspanel.Controls[i].Enabled = false;
                    labelspanel.Controls[i].Text = "-";
                }
                else if (buttoncolorindicators[i] == 'T')
                {
                    buttonspanel.Controls[i].BackColor = Color.FromKnownColor(KnownColor.PaleGreen);
                    buttonspanel.Controls[i].Enabled = true;
                    labelspanel.Controls[i].Text = "1";
                }
                else if (buttoncolorindicators[i] == 'F')
                {
                    buttonspanel.Controls[i].BackColor = Color.FromKnownColor(KnownColor.LightPink);
                    buttonspanel.Controls[i].Enabled = true;
                    labelspanel.Controls[i].Text = "0";
                }
                else if (buttoncolorindicators[i] == 'C')
                {
                    buttonspanel.Controls[i].BackColor = Color.FromKnownColor(KnownColor.PaleTurquoise);
                    buttonspanel.Controls[i].Enabled = true;
                    labelspanel.Controls[i].Text = Math.Round(((decimal)letteroccurencerate[i] / possiblecombinationslist.Items.Count),3).ToString();
                }
            }
            if (updatelistcheckbox.Checked) totalbutton.Text = "";
        }

        private void aTozbuttons_Click(object sender, EventArgs e)
        {
            if (!updatelistcheckbox.Checked) return;
            int totalcount = 0;

            possiblecombinationslist.SelectedIndexChanged -= new System.EventHandler(this.possiblecombinationslist_SelectedIndexChanged);
            possiblecombinationslist.BeginUpdate();
            possiblecombinationslist.Select();
            int buttonnumber = ((Control)sender).Name[0] - 97;
            for ( int i = 0; i < possiblecombinationslist.Items.Count; i++)
            {
                if (possiblecombinationslist.Items[i].SubItems[buttonnumber+1].Text == "T")
                {
                    possiblecombinationslist.Items[i].Selected = true;
                    totalcount++;
                }
                else
                {
                    possiblecombinationslist.Items[i].Selected = false;
                }
            }
            possiblecombinationslist.EndUpdate();
            possiblecombinationslist.SelectedIndexChanged += new System.EventHandler(this.possiblecombinationslist_SelectedIndexChanged);
            totalbutton.Text = totalcount > 0 ? totalcount.ToString() : "";
        }

        private void totalbutton_Click(object sender, EventArgs e)
        {
            if (!updatelistcheckbox.Checked) return;
            possiblecombinationslist.SelectedIndexChanged -= new System.EventHandler(this.possiblecombinationslist_SelectedIndexChanged);
            possiblecombinationslist.BeginUpdate();
            possiblecombinationslist.Select();
            for (int i = 0; i < possiblecombinationslist.Items.Count; i++)
            {
                possiblecombinationslist.Items[i].Selected = true;
            }
            possiblecombinationslist.EndUpdate();
            possiblecombinationslist.SelectedIndexChanged += new System.EventHandler(this.possiblecombinationslist_SelectedIndexChanged);
            totalbutton.Text = possiblecombinationslist.Items.Count > 0 ? possiblecombinationslist.Items.Count.ToString() : "";
        }

        private void updatelistcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (updatelistcheckbox.Checked == true)
            {
                possiblecombinationslist_Update(); atozbuttons_Update();
            }
        }

        private void possiblecombinationslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalbutton.Text = possiblecombinationslist.SelectedIndices.Count > 0 ? possiblecombinationslist.SelectedIndices.Count.ToString() : "";
        }

        private void helpcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            jottotooltip.Active = helpcheckbox.Checked;
            HelpButton = helpcheckbox.Checked;
        }

        private void minormaxnottcountnumericupdown_ValueChanged(object sender, EventArgs e)
        {
            possiblecombinationslist_Update(); atozbuttons_Update();
        }

        private void maxnottcountcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            maxnottcountnumericupdown.Enabled = maxnottcountcheckbox.Checked;
            possiblecombinationslist_Update(); atozbuttons_Update();
        }

        private void minnottcountcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            minnottcountnumericupdown.Enabled = minnottcountcheckbox.Checked;
            possiblecombinationslist_Update(); atozbuttons_Update();
        }

    }
}
