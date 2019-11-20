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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Група";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EnabledTests);
            this.tabControl1.Controls.Add(this.ResultTests);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 450);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Tag = "";
            // 
            // EnabledTests
            // 
            this.EnabledTests.Controls.Add(this.panelAvailableTests);
            this.EnabledTests.Location = new System.Drawing.Point(4, 22);
            this.EnabledTests.Name = "EnabledTests";
            this.EnabledTests.Padding = new System.Windows.Forms.Padding(3);
            this.EnabledTests.Size = new System.Drawing.Size(645, 424);
            this.EnabledTests.TabIndex = 0;
            this.EnabledTests.Text = "Доступні тести";
            this.EnabledTests.UseVisualStyleBackColor = true;
            // 
            // panelAvailableTests
            // 
            this.panelAvailableTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAvailableTests.Location = new System.Drawing.Point(3, 3);
            this.panelAvailableTests.Name = "panelAvailableTests";
            this.panelAvailableTests.Size = new System.Drawing.Size(639, 418);
            this.panelAvailableTests.TabIndex = 0;
            // 
            // ResultTests
            // 
            this.ResultTests.Controls.Add(this.listView1);
            this.ResultTests.Location = new System.Drawing.Point(4, 22);
            this.ResultTests.Name = "ResultTests";
            this.ResultTests.Padding = new System.Windows.Forms.Padding(3);
            this.ResultTests.Size = new System.Drawing.Size(645, 424);
            this.ResultTests.TabIndex = 1;
            this.ResultTests.Text = "Результати тестів";
            this.ResultTests.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameTest,
            this.columnSubject,
            this.columnGrade});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(639, 418);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
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
    }
}