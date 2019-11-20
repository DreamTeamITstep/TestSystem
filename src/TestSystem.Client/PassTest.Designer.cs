namespace TestClient
{
    partial class PassTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassTest));
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrev = new System.Windows.Forms.PictureBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.checkedListBoxAnswers = new System.Windows.Forms.CheckedListBox();
            this.buttonSendTest = new System.Windows.Forms.Button();
            this.labelNumberQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(337, 384);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 17);
            this.labelStatus.TabIndex = 49;
            this.labelStatus.Text = "1 із 1";
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(406, 345);
            this.pictureBoxNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(105, 92);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNext.TabIndex = 48;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // pictureBoxPrev
            // 
            this.pictureBoxPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPrev.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrev.Image")));
            this.pictureBoxPrev.Location = new System.Drawing.Point(203, 345);
            this.pictureBoxPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPrev.Name = "pictureBoxPrev";
            this.pictureBoxPrev.Size = new System.Drawing.Size(105, 92);
            this.pictureBoxPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPrev.TabIndex = 47;
            this.pictureBoxPrev.TabStop = false;
            this.pictureBoxPrev.Click += new System.EventHandler(this.pictureBoxPrev_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(327, 67);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(63, 17);
            this.labelQuestion.TabIndex = 50;
            this.labelQuestion.Text = "WhatIf?";
            // 
            // checkedListBoxAnswers
            // 
            this.checkedListBoxAnswers.FormattingEnabled = true;
            this.checkedListBoxAnswers.Location = new System.Drawing.Point(184, 113);
            this.checkedListBoxAnswers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBoxAnswers.Name = "checkedListBoxAnswers";
            this.checkedListBoxAnswers.Size = new System.Drawing.Size(398, 194);
            this.checkedListBoxAnswers.TabIndex = 51;
            // 
            // buttonSendTest
            // 
            this.buttonSendTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSendTest.Location = new System.Drawing.Point(545, 407);
            this.buttonSendTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSendTest.Name = "buttonSendTest";
            this.buttonSendTest.Size = new System.Drawing.Size(251, 30);
            this.buttonSendTest.TabIndex = 52;
            this.buttonSendTest.Text = "Відправити тест на перевірку";
            this.buttonSendTest.UseVisualStyleBackColor = false;
            this.buttonSendTest.Click += new System.EventHandler(this.buttonSendTest_Click);
            // 
            // labelNumberQuestion
            // 
            this.labelNumberQuestion.AutoSize = true;
            this.labelNumberQuestion.Location = new System.Drawing.Point(327, 33);
            this.labelNumberQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberQuestion.Name = "labelNumberQuestion";
            this.labelNumberQuestion.Size = new System.Drawing.Size(80, 17);
            this.labelNumberQuestion.TabIndex = 53;
            this.labelNumberQuestion.Text = "Question1?";
            // 
            // PassTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNumberQuestion);
            this.Controls.Add(this.buttonSendTest);
            this.Controls.Add(this.checkedListBoxAnswers);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.pictureBoxPrev);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PassTest";
            this.Text = "PassTest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.PictureBox pictureBoxPrev;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.CheckedListBox checkedListBoxAnswers;
        private System.Windows.Forms.Button buttonSendTest;
        private System.Windows.Forms.Label labelNumberQuestion;
    }
}