namespace TestClient
{
    partial class Tests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tests));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EnabledTests = new System.Windows.Forms.TabPage();
            this.panelAvailableTests = new System.Windows.Forms.Panel();
            this.ResultTests = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNameTest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.EnabledTests.SuspendLayout();
            this.ResultTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonUpdate.Location = new System.Drawing.Point(13, 396);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 32);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Оновити";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Група";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище";
            this.label1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EnabledTests);
            this.tabControl1.Controls.Add(this.ResultTests);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 450);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Tag = "";
            // 
            // EnabledTests
            // 
            this.EnabledTests.Controls.Add(this.panelAvailableTests);
            this.EnabledTests.Location = new System.Drawing.Point(4, 27);
            this.EnabledTests.Margin = new System.Windows.Forms.Padding(4);
            this.EnabledTests.Name = "EnabledTests";
            this.EnabledTests.Padding = new System.Windows.Forms.Padding(4);
            this.EnabledTests.Size = new System.Drawing.Size(643, 419);
            this.EnabledTests.TabIndex = 0;
            this.EnabledTests.Text = "Доступні тести";
            this.EnabledTests.UseVisualStyleBackColor = true;
            // 
            // panelAvailableTests
            // 
            this.panelAvailableTests.BackColor = System.Drawing.Color.Maroon;
            this.panelAvailableTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAvailableTests.Location = new System.Drawing.Point(4, 4);
            this.panelAvailableTests.Margin = new System.Windows.Forms.Padding(4);
            this.panelAvailableTests.Name = "panelAvailableTests";
            this.panelAvailableTests.Size = new System.Drawing.Size(635, 411);
            this.panelAvailableTests.TabIndex = 0;
            // 
            // ResultTests
            // 
            this.ResultTests.Controls.Add(this.listView1);
            this.ResultTests.Location = new System.Drawing.Point(4, 22);
            this.ResultTests.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTests.Name = "ResultTests";
            this.ResultTests.Padding = new System.Windows.Forms.Padding(4);
            this.ResultTests.Size = new System.Drawing.Size(643, 424);
            this.ResultTests.TabIndex = 1;
            this.ResultTests.Text = "Результати тестів";
            this.ResultTests.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameTest,
            this.columnSubject,
            this.columnGrade});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(635, 416);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnNameTest
            // 
            this.columnNameTest.Text = "Назва тесту";
            this.columnNameTest.Width = 326;
            // 
            // columnSubject
            // 
            this.columnSubject.Text = "Предмет";
            this.columnSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSubject.Width = 176;
            // 
            // columnGrade
            // 
            this.columnGrade.Text = "Оцінка";
            this.columnGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnGrade.Width = 135;
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tests";
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.Tests_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.EnabledTests.ResumeLayout(false);
            this.ResultTests.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EnabledTests;
        private System.Windows.Forms.TabPage ResultTests;
        private System.Windows.Forms.Panel panelAvailableTests;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnNameTest;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.ColumnHeader columnGrade;
        private System.Windows.Forms.Button buttonUpdate;
    }
}