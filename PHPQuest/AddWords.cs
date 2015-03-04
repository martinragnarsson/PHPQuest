using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHPQuest.Controller;

namespace PHPQuest
{
    public partial class AddWords : Form
    {
        Form1 form1;
        public AddWords(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            
        }

        WordList wordList;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAddWords.SelectedIndex == 0 && cmbAddWordsTranslated.SelectedIndex != 0)
            {
                wordList.Språk1.Add(tbxAddNewWords.Text);
            }
            if (cmbAddWords.SelectedIndex == 1 && cmbAddWordsTranslated.SelectedIndex != 1)
            {
                wordList.Språk2.Add(tbxAddNewWords.Text);
            }
            if (cmbAddWords.SelectedIndex == 2 && cmbAddWordsTranslated.SelectedIndex != 2)
            {
                wordList.Språk3.Add(tbxAddNewWords.Text);
            }
            if (cmbAddWords.SelectedIndex == 3 && cmbAddWordsTranslated.SelectedIndex != 3)
            {
                wordList.Språk4.Add(tbxAddNewWords.Text);
            }
            if (cmbAddWordsTranslated.SelectedIndex == 0 && cmbAddWords.SelectedIndex != 0)
            {
                wordList.Språk1.Add(tbxAddMoreWords2.Text);
            }
            if (cmbAddWordsTranslated.SelectedIndex == 1 && cmbAddWords.SelectedIndex != 1)
            {
                wordList.Språk2.Add(tbxAddMoreWords2.Text);
            }
            if (cmbAddWordsTranslated.SelectedIndex == 2 && cmbAddWords.SelectedIndex != 2)
            {
                wordList.Språk3.Add(tbxAddMoreWords2.Text);
            }
            if (cmbAddWordsTranslated.SelectedIndex == 3 && cmbAddWords.SelectedIndex != 3)
            {
                wordList.Språk4.Add(tbxAddMoreWords2.Text);
            }
            tbxAddNewWords.Clear();
            tbxAddMoreWords2.Clear();  
        }
    }
}
