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
    /// <summary>
    /// Denna form lägger man till ord och översättningar med
    /// </summary>
    public partial class AddWords : Form
    {
        TimeTest timetest;
        public AddWords(TimeTest timetest)
        {
            InitializeComponent();
            this.timetest = timetest;
            wordList = new WordList();
        }

        WordList wordList;

        /// <summary>
        /// Knappen som lägger till rätt ord i rätt ordlista baserat på vilket index är selectat i dropdown-menyerna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAddWords.SelectedIndex == 0 && cmbAddWordsTranslated.SelectedIndex != 0)
            {
                wordList.Språk1.Add(tbxAddNewWords.Text);
                timetest.n++;
            }
            if (cmbAddWords.SelectedIndex == 1 && cmbAddWordsTranslated.SelectedIndex != 1)
            {
                wordList.Språk2.Add(tbxAddNewWords.Text);

                timetest.n++;
            }
            //if (cmbAddWords.SelectedIndex == 2 && cmbAddWordsTranslated.SelectedIndex != 2)
            //{
            //    wordList.Språk3.Add(tbxAddNewWords.Text);
            //}
            //if (cmbAddWords.SelectedIndex == 3 && cmbAddWordsTranslated.SelectedIndex != 3)
            //{
            //    wordList.Språk4.Add(tbxAddNewWords.Text);
            //}
            if (cmbAddWordsTranslated.SelectedIndex == 0 && cmbAddWords.SelectedIndex != 0)
            {
                wordList.Språk1.Add(tbxAddMoreWords2.Text);
                timetest.n++;
            }
            if (cmbAddWordsTranslated.SelectedIndex == 1 && cmbAddWords.SelectedIndex != 1)
            {
                wordList.Språk2.Add(tbxAddMoreWords2.Text);
                timetest.n++;
            }
            //if (cmbAddWordsTranslated.SelectedIndex == 2 && cmbAddWords.SelectedIndex != 2)
            //{
            //    wordList.Språk3.Add(tbxAddMoreWords2.Text);
            //}
            //if (cmbAddWordsTranslated.SelectedIndex == 3 && cmbAddWords.SelectedIndex != 3)
            //{
            //    wordList.Språk4.Add(tbxAddMoreWords2.Text);
            //}
            tbxAddNewWords.Clear();
            tbxAddMoreWords2.Clear();  
        }

        private void cmbAddWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
