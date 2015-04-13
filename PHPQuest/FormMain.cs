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
using PHPQuest.Controller;

namespace PHPQuest
{
    public partial class FormMain : Form
    {
        TimeTest tt;
        PopupAddWords popup = new PopupAddWords();
        AddWords popup2;
        public FormMain()
        {
            popup2 = new AddWords(tt);
            InitializeComponent();


            this.tt = new TimeTest(this);

            this.popup2.cmbAddWords.Items.Add("Swedish");
            this.popup2.cmbAddWords.Items.Add("English");

            this.popup2.cmbAddWordsTranslated.Items.Add("Swedish");
            this.popup2.cmbAddWordsTranslated.Items.Add("English");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Visar form TimeTest.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            tt.Show();
        }

        private void btnAddworderinos_Click(object sender, EventArgs e)
        {
            DialogResult showAddWords = popup2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
