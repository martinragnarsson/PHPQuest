namespace PHPQuest
{
    partial class AddWords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAddWords = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAddNewWords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxAddMoreWords2 = new System.Windows.Forms.TextBox();
            this.cmbAddWordsTranslated = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbAddWords
            // 
            this.cmbAddWords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddWords.FormattingEnabled = true;
            this.cmbAddWords.Location = new System.Drawing.Point(12, 30);
            this.cmbAddWords.Name = "cmbAddWords";
            this.cmbAddWords.Size = new System.Drawing.Size(121, 21);
            this.cmbAddWords.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add words to:";
            // 
            // tbxAddNewWords
            // 
            this.tbxAddNewWords.Location = new System.Drawing.Point(12, 96);
            this.tbxAddNewWords.Name = "tbxAddNewWords";
            this.tbxAddNewWords.Size = new System.Drawing.Size(121, 20);
            this.tbxAddNewWords.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Translation";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(117, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxAddMoreWords2
            // 
            this.tbxAddMoreWords2.Location = new System.Drawing.Point(172, 96);
            this.tbxAddMoreWords2.Name = "tbxAddMoreWords2";
            this.tbxAddMoreWords2.Size = new System.Drawing.Size(121, 20);
            this.tbxAddMoreWords2.TabIndex = 6;
            // 
            // cmbAddWordsTranslated
            // 
            this.cmbAddWordsTranslated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddWordsTranslated.FormattingEnabled = true;
            this.cmbAddWordsTranslated.Location = new System.Drawing.Point(172, 30);
            this.cmbAddWordsTranslated.Name = "cmbAddWordsTranslated";
            this.cmbAddWordsTranslated.Size = new System.Drawing.Size(121, 21);
            this.cmbAddWordsTranslated.TabIndex = 5;
            // 
            // AddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 187);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxAddMoreWords2);
            this.Controls.Add(this.cmbAddWordsTranslated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAddNewWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAddWords);
            this.Name = "AddWords";
            this.Text = "AddWords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbAddWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbAddWordsTranslated;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox tbxAddNewWords;
        public System.Windows.Forms.TextBox tbxAddMoreWords2;
    }
}