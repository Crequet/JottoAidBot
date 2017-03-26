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
        bool[] letterfilterlogicalview;
        public bool formisvisible;

        public wordfinderForm()
        {
            InitializeComponent();
            wordliststringviews = Properties.Resources.allwordsdictionarytxtfile.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            initializewordlistlogicalviews();
            noduplicatecheckbox.CheckedChanged += call_possiblewordlist_Update;
            minimumwordlengthcheckbox.CheckedChanged += call_possiblewordlist_Update;
            maximumwordlengthcheckbox.CheckedChanged += call_possiblewordlist_Update;
            letterfiltercheckbox.CheckedChanged += call_possiblewordlist_Update;
            minimumwordlengthnumericupdown.ValueChanged += call_possiblewordlist_Update;
            maximumwordlengthnumericupdown.ValueChanged += call_possiblewordlist_Update;
        }

        void initializewordlistlogicalviews()
        {
            wordlistlogicalviews = new bool[wordliststringviews.Length][];

            for (int i=0; i < wordliststringviews.Length; i++)
            {
                wordlistlogicalviews[i] = LayerOperation.GetLogicalView(wordliststringviews[i]);
            }
        }
        public void call_possiblewordlist_Update(object sender, EventArgs e)
        {
            possiblewordlist_Update();
        }

        public void possiblewordlist_Update()
        {
            string q = "";
            foreach (char c in letterfiltertext.Text)
            {
                if (char.IsLetter(c)) q += char.ToLower(c);
            }
            letterfilterlogicalview = LayerOperation.GetLogicalView(q);
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
                    if (word[i] == word[j])
                        return true;
                }
            }
            return false;
        }

        bool matcheswithatleastonecondition(int index)
        {
            for (int i = 0; i < ((mainForm)this.Owner).filteredlist.Count; i++)
            {
                if (LayerOperation.LayersMatch(((mainForm)this.Owner).filteredlist[i], wordlistlogicalviews[index]))
                    return true;
            }
            return false;
        }

        bool isvalidword(int index)
        {
            if (noduplicatecheckbox.Checked && containsduplicate(wordliststringviews[index])) return false;
            if (minimumwordlengthcheckbox.Checked && wordliststringviews[index].Length > minimumwordlengthnumericupdown.Value) return false;
            if (maximumwordlengthcheckbox.Checked && wordliststringviews[index].Length < maximumwordlengthnumericupdown.Value) return false;
            if (((mainForm)this.Owner).maxuniqueletterscountcheckbox.Checked && wordlistlogicalviews[index].TrueCount() > ((mainForm)this.Owner).maxuniqueletterscountnumericupdown.Value) return false;
            if (((mainForm)this.Owner).maxuniqueletterscountcheckbox.Checked && wordlistlogicalviews[index].TrueCount() < ((mainForm)this.Owner).minuniqueletterscountnumericupdown.Value) return false;
            if (letterfiltercheckbox.Checked && !(LayerOperation.LayersMatch(letterfilterlogicalview, wordlistlogicalviews[index]))) return false;
            if (matcheswithatleastonecondition(index)) return true;
            return false;
        }

        private void wordfinderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                formisvisible = false;
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

        private void letterfiltercheckbox_CheckedChanged(object sender, EventArgs e)
        {
            letterfiltertext.Enabled = letterfiltercheckbox.Checked;
        }

        private void letterfiltertext_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                possiblewordlist_Update();
            }
        }
    }
}
