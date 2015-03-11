namespace PHPQuest
{
    partial class TimeTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTest));
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.tbxAnswer = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.tmrCount = new System.Windows.Forms.Timer(this.components);
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblPoints = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddworderinos = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(5, 34);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 31);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "20";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(47, 44);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(167, 20);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "Seconds to answer.";
            // 
            // tbxAnswer
            // 
            this.tbxAnswer.Location = new System.Drawing.Point(216, 219);
            this.tbxAnswer.Name = "tbxAnswer";
            this.tbxAnswer.ReadOnly = true;
            this.tbxAnswer.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer.TabIndex = 3;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(224, 161);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 16);
            this.lblWord.TabIndex = 4;
            // 
            // tmrCount
            // 
            this.tmrCount.Enabled = true;
            this.tmrCount.Interval = 1000;
            this.tmrCount.Tick += new System.EventHandler(this.tmrCount_Tick);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(233, 47);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(61, 18);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "Points:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1, 3);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(107, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(230, 256);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(11, 192);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(11, 261);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "To:";
            // 
            // btnAddworderinos
            // 
            this.btnAddworderinos.Location = new System.Drawing.Point(279, 3);
            this.btnAddworderinos.Name = "btnAddworderinos";
            this.btnAddworderinos.Size = new System.Drawing.Size(75, 23);
            this.btnAddworderinos.TabIndex = 13;
            this.btnAddworderinos.Text = "Add Words";
            this.btnAddworderinos.UseVisualStyleBackColor = true;
            this.btnAddworderinos.Click += new System.EventHandler(this.btnAddworderinos_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(195, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 308);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAddworderinos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.tbxAnswer);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Glosor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TextBox tbxAnswer;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Timer tmrCount;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddworderinos;
        private System.Windows.Forms.Button btnStop;
    }
}

