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
    public partial class TimeTest : Form
    {
        Random random = new Random();
        bool rightanswer = false;
        bool start = false;
        bool förstasparningen = false;
        int i = 20;
        int n = 0;
        int points = 0;
        FormMain fm;

        WordList wordList;

        PopupAddWords popup = new PopupAddWords();
        AddWords popup2;

        public TimeTest(FormMain fm)
        {
            this.fm = fm;
            popup2 = new AddWords(this);
            wordList = new WordList();
            InitializeComponent();
            fm.comboBox1.Cursor = Cursors.Default;

            fm.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            fm.Controls.Add(fm.comboBox1);
            fm.comboBox1.Items.Add("Add language");
            fm.comboBox1.Items.Add("Reset");
            fm.comboBox1.Items.Add("Save");
            fm.comboBox1.SelectedIndexChanged += new System.EventHandler(ComboBox1_DropDown);


            fm.comboBox2.Items.Add("Swedish");
            fm.comboBox2.Items.Add("English");


            fm.comboBox3.Items.Add("Swedish");
            fm.comboBox3.Items.Add("English");


            this.popup2.cmbAddWords.Items.Add("Swedish");
            this.popup2.cmbAddWords.Items.Add("English");

            this.popup2.cmbAddWordsTranslated.Items.Add("Swedish");
            this.popup2.cmbAddWordsTranslated.Items.Add("English");



        }
        private void ComboBox1_DropDown(object sender, System.EventArgs e)
        {
            if (fm.comboBox1.SelectedIndex == 0)
            {
                DialogResult dialogresult = popup.ShowDialog();

                if (popup.textBox1.Text != string.Empty)
                {
                    fm.comboBox1.Items.Add(popup.textBox1.Text);
                    fm.comboBox2.Items.Add(popup.textBox1.Text);
                    fm.comboBox3.Items.Add(popup.textBox1.Text);
                    this.popup2.cmbAddWords.Items.Add(popup.textBox1.Text);
                    this.popup2.cmbAddWordsTranslated.Items.Add(popup.textBox1.Text);
                    popup.textBox1.Clear();
                }
            }
            if (fm.comboBox1.SelectedIndex == 1)
            {
                System.IO.File.WriteAllText(@"F:\Glosor2\Save.txt", string.Empty);
                lblCount.Text = "20";
                i = 20;
                this.tmrCount.Enabled = true;
                start = false;
                tbxAnswer.ReadOnly = true;
                points = 0;
            }
            if (fm.comboBox1.SelectedIndex == 2)
            {////////////////////////////////////////////////////////////////

                string saving = System.IO.File.ReadAllText(@"L:\Patrik Grip\Gammalt\Martin Ragnarsson - TE2A\glosor\Save.txt");
                int save = Convert.ToInt32(saving);
                save++;

                System.IO.File.WriteAllText(@"L:\Patrik Grip\Gammalt\Martin Ragnarsson - TE2A\glosor\Save.txt", save.ToString());
                if (förstasparningen)
                {
                    save = 1;
                    förstasparningen = false;
                }
                else
                {
                    save = Convert.ToInt32(System.IO.File.ReadAllText(@"L:\Patrik Grip\Gammalt\Martin Ragnarsson - TE2A\glosor\Save.txt"));
                }
                System.IO.File.WriteAllText(@"L:\Patrik Grip\Gammalt\Martin Ragnarsson - TE2A\glosor\Resultat.txt", "\n" + "Testnr: " + save + " " + "Points: " + points);
            }
        }

        private void tmrCount_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                if (start == true)
                {
                    i--;
                    tbxAnswer.ReadOnly = false;
                }
            }
            else
            {
                this.tmrCount.Enabled = false;
                tbxAnswer.ReadOnly = true;
            }

            this.Update();
            lblCount.Text = i.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = true;
        }


        private void tmrMain_Tick(object sender, EventArgs e)
        {
            lblPoints.Text = "Points:   " + points.ToString();

            if (rightanswer)
            {
                points++;
                n = random.Next(0, wordList.Språk1.Count);
                tbxAnswer.Clear();
                rightanswer = false;
                i = 20;
            }
            if (fm.comboBox2.SelectedIndex == 0)
            {
                lblWord.Text = wordList.Språk1[n];
            }
            if (fm.comboBox2.SelectedIndex == 1)
            {
                lblWord.Text = wordList.Språk2[n];
            }
            if (fm.comboBox2.SelectedIndex == 2)
            {
                lblWord.Text = wordList.Språk3[n];
            }
            if (fm.comboBox2.SelectedIndex == 3)
            {
                lblWord.Text = wordList.Språk4[n];
            }
            this.Update();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            tbxAnswer.BackColor = Color.White;
            if (e.KeyCode == Keys.Enter)
            {
                if (!rightanswer)
                {
                    tbxAnswer.BackColor = Color.Red;
                }
                btnSend.PerformClick();
            }
            
            
        }

        public void btnSend_Click(object sender, EventArgs e)
        {
            if (fm.comboBox3.SelectedIndex == 0)
            {
                if (tbxAnswer.Text == wordList.Språk1[n])
                {
                    rightanswer = true;
                }
            }
            if (fm.comboBox3.SelectedIndex == 1)
            {
                if (tbxAnswer.Text == wordList.Språk2[n])
                {
                    rightanswer = true;
                }
            }
            if (fm.comboBox3.SelectedIndex == 2)
            {
                if (tbxAnswer.Text == wordList.Språk3[n])
                {
                    rightanswer = true;
                }
            }
            if (fm.comboBox3.SelectedIndex == 3)
            {
                if (tbxAnswer.Text == wordList.Språk4[n])
                {
                    rightanswer = true;
                }
            }
            if (rightanswer)
            {
                tbxAnswer.BackColor = Color.White;
            }

        }


        private void btnAddworderinos_Click(object sender, EventArgs e)
        {
            DialogResult pleswork = popup2.ShowDialog();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.tmrCount.Enabled = false;
            tbxAnswer.ReadOnly = true;
            i = 20;
            lblCount.Text = i.ToString();
        }

        private void TimeTest_Load(object sender, EventArgs e)
        {

        }
    }
}
