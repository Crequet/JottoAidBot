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
        WordGuessCollection wgc;

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
            for (int i =0; i < wgc.PossibleLayerCombinations.Count; i++)
            {
                possiblecombinationslist.Items.Add(i.ToString());
                for (int j = 0; j < wgc.PossibleLayerCombinations[i].Length; j++)
                {
                   possiblecombinationslist.Items[i].SubItems.Add(wgc.PossibleLayerCombinations[i][j].ToString());
                }
            }
            ResumeLayout(); possiblecombinationslist.ResumeLayout();
            possiblecombinationslist.EndUpdate();
        }

        private void atozbuttons_Update()
        {
            if (!updatelistcheckbox.Checked) return;
            char[] buttoncolorindicators = new char[26];
            for (int i = 0; i < 26; i++)
            {
                buttoncolorindicators[i] = wgc.PossibleLayerCombinations[0][i].Value;
                for (int j = 1; j < wgc.PossibleLayerCombinations.Count; j++)
                {
                    if (buttoncolorindicators[i] == '?') break;
                    buttoncolorindicators[i] = LayerOperation.MergeNodes(buttoncolorindicators[i], wgc.PossibleLayerCombinations[j][i]);
                }

                if (buttoncolorindicators[i] == '?')
                {
                    Controls[i + 4].BackColor = Color.FromKnownColor(KnownColor.Control);
                    Controls[i + 4].Enabled = false;
                }
                else if (buttoncolorindicators[i] == 'T')
                {
                    Controls[i + 4].BackColor = Color.FromKnownColor(KnownColor.PaleGreen);
                    Controls[i + 4].Enabled = true;
                }
                else if (buttoncolorindicators[i] == 'F')
                {
                    Controls[i + 4].BackColor = Color.FromKnownColor(KnownColor.LightPink);
                    Controls[i + 4].Enabled = true;
                }
                else if (buttoncolorindicators[i] == 'C')
                {
                    Controls[i + 4].BackColor = Color.FromKnownColor(KnownColor.PaleTurquoise);
                    Controls[i + 4].Enabled = true;
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
            for ( int i = 0; i < wgc.PossibleLayerCombinations.Count; i++)
            {
                if (wgc.PossibleLayerCombinations[i][buttonnumber].Value == 'T')
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
            for (int i = 0; i < wgc.PossibleLayerCombinations.Count; i++)
            {
                possiblecombinationslist.Items[i].Selected = true;
            }
            possiblecombinationslist.EndUpdate();
            possiblecombinationslist.SelectedIndexChanged += new System.EventHandler(this.possiblecombinationslist_SelectedIndexChanged);
            totalbutton.Text = wgc.PossibleLayerCombinations.Count > 0 ? wgc.PossibleLayerCombinations.Count.ToString() : "";
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
    }
}
