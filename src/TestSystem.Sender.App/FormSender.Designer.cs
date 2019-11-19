namespace TestSystem.Sender.App
{
    partial class FormSender
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.button_SearchFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_GroupStudents = new System.Windows.Forms.TabControl();
            this.tabPage_GroupStudents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_GroupStudents = new System.Windows.Forms.ListBox();
            this.tabControl_Groups = new System.Windows.Forms.TabControl();
            this.tabPage_Groups = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ModifyGroup = new System.Windows.Forms.Button();
            this.button_AddGroup = new System.Windows.Forms.Button();
            this.listBox_Groups = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_DeleteGoup = new System.Windows.Forms.Button();
            this.textBox_GroupName = new System.Windows.Forms.TextBox();
            this.tabControl_AllStudents = new System.Windows.Forms.TabControl();
            this.tabPage_AllStudents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_AllStudents = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button_AddToGroup = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Allow = new System.Windows.Forms.Button();
            this.button_Disallow = new System.Windows.Forms.Button();
            this.button_SendOnServer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl_GroupStudents.SuspendLayout();
            this.tabPage_GroupStudents.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabControl_Groups.SuspendLayout();
            this.tabPage_Groups.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl_AllStudents.SuspendLayout();
            this.tabPage_AllStudents.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(600, 450);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox_FilePath);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button_SearchFile);
            this.splitContainer2.Size = new System.Drawing.Size(600, 25);
            this.splitContainer2.SplitterDistance = 510;
            this.splitContainer2.TabIndex = 1;
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_FilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FilePath.Location = new System.Drawing.Point(0, 0);
            this.textBox_FilePath.Multiline = true;
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.ReadOnly = true;
            this.textBox_FilePath.Size = new System.Drawing.Size(510, 25);
            this.textBox_FilePath.TabIndex = 0;
            // 
            // button_SearchFile
            // 
            this.button_SearchFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SearchFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SearchFile.Location = new System.Drawing.Point(0, 0);
            this.button_SearchFile.Name = "button_SearchFile";
            this.button_SearchFile.Size = new System.Drawing.Size(86, 25);
            this.button_SearchFile.TabIndex = 0;
            this.button_SearchFile.Text = "Search file";
            this.button_SearchFile.UseVisualStyleBackColor = true;
            this.button_SearchFile.Click += new System.EventHandler(this.button_SearchFile_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl_AllStudents, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tabControl_GroupStudents, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl_Groups, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl_GroupStudents
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl_GroupStudents, 2);
            this.tabControl_GroupStudents.Controls.Add(this.tabPage_GroupStudents);
            this.tabControl_GroupStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_GroupStudents.Location = new System.Drawing.Point(302, 3);
            this.tabControl_GroupStudents.Name = "tabControl_GroupStudents";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl_GroupStudents, 3);
            this.tabControl_GroupStudents.SelectedIndex = 0;
            this.tabControl_GroupStudents.Size = new System.Drawing.Size(295, 204);
            this.tabControl_GroupStudents.TabIndex = 1;
            // 
            // tabPage_GroupStudents
            // 
            this.tabPage_GroupStudents.BackColor = System.Drawing.Color.DimGray;
            this.tabPage_GroupStudents.Controls.Add(this.tableLayoutPanel5);
            this.tabPage_GroupStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPage_GroupStudents.Name = "tabPage_GroupStudents";
            this.tabPage_GroupStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_GroupStudents.Size = new System.Drawing.Size(287, 178);
            this.tabPage_GroupStudents.TabIndex = 0;
            this.tabPage_GroupStudents.Text = "Students in group";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.button4, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.listBox_GroupStudents, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(281, 172);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // listBox_GroupStudents
            // 
            this.listBox_GroupStudents.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel5.SetColumnSpan(this.listBox_GroupStudents, 2);
            this.listBox_GroupStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_GroupStudents.FormattingEnabled = true;
            this.listBox_GroupStudents.Location = new System.Drawing.Point(3, 3);
            this.listBox_GroupStudents.Name = "listBox_GroupStudents";
            this.tableLayoutPanel5.SetRowSpan(this.listBox_GroupStudents, 4);
            this.listBox_GroupStudents.Size = new System.Drawing.Size(275, 130);
            this.listBox_GroupStudents.TabIndex = 0;
            // 
            // tabControl_Groups
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl_Groups, 2);
            this.tabControl_Groups.Controls.Add(this.tabPage_Groups);
            this.tabControl_Groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Groups.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Groups.Name = "tabControl_Groups";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl_Groups, 6);
            this.tabControl_Groups.SelectedIndex = 0;
            this.tabControl_Groups.Size = new System.Drawing.Size(293, 415);
            this.tabControl_Groups.TabIndex = 0;
            // 
            // tabPage_Groups
            // 
            this.tabPage_Groups.BackColor = System.Drawing.Color.DimGray;
            this.tabPage_Groups.Controls.Add(this.tableLayoutPanel2);
            this.tabPage_Groups.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Groups.Name = "tabPage_Groups";
            this.tabPage_Groups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Groups.Size = new System.Drawing.Size(285, 389);
            this.tabPage_Groups.TabIndex = 0;
            this.tabPage_Groups.Text = "Groups";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.listBox_Groups, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.button_SendOnServer, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 383);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button_ModifyGroup, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button_AddGroup, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(142, 332);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(134, 48);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // button_ModifyGroup
            // 
            this.button_ModifyGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ModifyGroup.Location = new System.Drawing.Point(0, 24);
            this.button_ModifyGroup.Margin = new System.Windows.Forms.Padding(0);
            this.button_ModifyGroup.Name = "button_ModifyGroup";
            this.button_ModifyGroup.Size = new System.Drawing.Size(134, 24);
            this.button_ModifyGroup.TabIndex = 1;
            this.button_ModifyGroup.Text = "Modify";
            this.button_ModifyGroup.UseVisualStyleBackColor = true;
            // 
            // button_AddGroup
            // 
            this.button_AddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddGroup.Location = new System.Drawing.Point(0, 0);
            this.button_AddGroup.Margin = new System.Windows.Forms.Padding(0);
            this.button_AddGroup.Name = "button_AddGroup";
            this.button_AddGroup.Size = new System.Drawing.Size(134, 24);
            this.button_AddGroup.TabIndex = 0;
            this.button_AddGroup.Text = "Add";
            this.button_AddGroup.UseVisualStyleBackColor = true;
            // 
            // listBox_Groups
            // 
            this.listBox_Groups.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel2.SetColumnSpan(this.listBox_Groups, 2);
            this.listBox_Groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Groups.FormattingEnabled = true;
            this.listBox_Groups.Location = new System.Drawing.Point(3, 3);
            this.listBox_Groups.Name = "listBox_Groups";
            this.tableLayoutPanel2.SetRowSpan(this.listBox_Groups, 6);
            this.listBox_Groups.Size = new System.Drawing.Size(273, 276);
            this.listBox_Groups.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button_DeleteGoup, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_GroupName, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 332);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(133, 48);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // button_DeleteGoup
            // 
            this.button_DeleteGoup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DeleteGoup.Location = new System.Drawing.Point(0, 24);
            this.button_DeleteGoup.Margin = new System.Windows.Forms.Padding(0);
            this.button_DeleteGoup.Name = "button_DeleteGoup";
            this.button_DeleteGoup.Size = new System.Drawing.Size(133, 24);
            this.button_DeleteGoup.TabIndex = 3;
            this.button_DeleteGoup.Text = "Delete";
            this.button_DeleteGoup.UseVisualStyleBackColor = true;
            // 
            // textBox_GroupName
            // 
            this.textBox_GroupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_GroupName.Location = new System.Drawing.Point(0, 0);
            this.textBox_GroupName.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_GroupName.Multiline = true;
            this.textBox_GroupName.Name = "textBox_GroupName";
            this.textBox_GroupName.Size = new System.Drawing.Size(133, 24);
            this.textBox_GroupName.TabIndex = 2;
            // 
            // tabControl_AllStudents
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl_AllStudents, 2);
            this.tabControl_AllStudents.Controls.Add(this.tabPage_AllStudents);
            this.tabControl_AllStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_AllStudents.Location = new System.Drawing.Point(302, 213);
            this.tabControl_AllStudents.Name = "tabControl_AllStudents";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl_AllStudents, 3);
            this.tabControl_AllStudents.SelectedIndex = 0;
            this.tabControl_AllStudents.Size = new System.Drawing.Size(295, 205);
            this.tabControl_AllStudents.TabIndex = 2;
            // 
            // tabPage_AllStudents
            // 
            this.tabPage_AllStudents.BackColor = System.Drawing.Color.DimGray;
            this.tabPage_AllStudents.Controls.Add(this.tableLayoutPanel6);
            this.tabPage_AllStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AllStudents.Name = "tabPage_AllStudents";
            this.tabPage_AllStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AllStudents.Size = new System.Drawing.Size(287, 179);
            this.tabPage_AllStudents.TabIndex = 0;
            this.tabPage_AllStudents.Text = "All students";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.button_AddToGroup, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.listBox_AllStudents, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(281, 173);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // listBox_AllStudents
            // 
            this.listBox_AllStudents.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel6.SetColumnSpan(this.listBox_AllStudents, 2);
            this.listBox_AllStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_AllStudents.FormattingEnabled = true;
            this.listBox_AllStudents.Location = new System.Drawing.Point(3, 3);
            this.listBox_AllStudents.Name = "listBox_AllStudents";
            this.tableLayoutPanel6.SetRowSpan(this.listBox_AllStudents, 4);
            this.listBox_AllStudents.Size = new System.Drawing.Size(275, 130);
            this.listBox_AllStudents.TabIndex = 0;
            // 
            // button4
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.button4, 2);
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(0, 136);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(281, 36);
            this.button4.TabIndex = 1;
            this.button4.Text = "Remove from group";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button_AddToGroup
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.button_AddToGroup, 2);
            this.button_AddToGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddToGroup.Location = new System.Drawing.Point(0, 136);
            this.button_AddToGroup.Margin = new System.Windows.Forms.Padding(0);
            this.button_AddToGroup.Name = "button_AddToGroup";
            this.button_AddToGroup.Size = new System.Drawing.Size(281, 37);
            this.button_AddToGroup.TabIndex = 2;
            this.button_AddToGroup.Text = "Add to group";
            this.button_AddToGroup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.button_Disallow, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.button_Allow, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 285);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(133, 41);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // button_Allow
            // 
            this.button_Allow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Allow.Location = new System.Drawing.Point(0, 0);
            this.button_Allow.Margin = new System.Windows.Forms.Padding(0);
            this.button_Allow.Name = "button_Allow";
            this.button_Allow.Size = new System.Drawing.Size(133, 21);
            this.button_Allow.TabIndex = 0;
            this.button_Allow.Text = "Allow";
            this.button_Allow.UseVisualStyleBackColor = true;
            // 
            // button_Disallow
            // 
            this.button_Disallow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Disallow.Location = new System.Drawing.Point(0, 21);
            this.button_Disallow.Margin = new System.Windows.Forms.Padding(0);
            this.button_Disallow.Name = "button_Disallow";
            this.button_Disallow.Size = new System.Drawing.Size(133, 20);
            this.button_Disallow.TabIndex = 1;
            this.button_Disallow.Text = "Disallow";
            this.button_Disallow.UseVisualStyleBackColor = true;
            // 
            // button_SendOnServer
            // 
            this.button_SendOnServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SendOnServer.Location = new System.Drawing.Point(142, 285);
            this.button_SendOnServer.Name = "button_SendOnServer";
            this.button_SendOnServer.Size = new System.Drawing.Size(134, 41);
            this.button_SendOnServer.TabIndex = 4;
            this.button_SendOnServer.Text = "Send on server";
            this.button_SendOnServer.UseVisualStyleBackColor = true;
            this.button_SendOnServer.Click += new System.EventHandler(this.button_SendOnServer_Click);
            // 
            // FormSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormSender";
            this.Text = "Sender";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl_GroupStudents.ResumeLayout(false);
            this.tabPage_GroupStudents.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tabControl_Groups.ResumeLayout(false);
            this.tabPage_Groups.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl_AllStudents.ResumeLayout(false);
            this.tabPage_AllStudents.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Button button_SearchFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl_GroupStudents;
        private System.Windows.Forms.TabPage tabPage_GroupStudents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListBox listBox_GroupStudents;
        private System.Windows.Forms.TabControl tabControl_Groups;
        private System.Windows.Forms.TabPage tabPage_Groups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_ModifyGroup;
        private System.Windows.Forms.Button button_AddGroup;
        private System.Windows.Forms.ListBox listBox_Groups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_DeleteGoup;
        private System.Windows.Forms.TextBox textBox_GroupName;
        private System.Windows.Forms.TabControl tabControl_AllStudents;
        private System.Windows.Forms.TabPage tabPage_AllStudents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ListBox listBox_AllStudents;
        private System.Windows.Forms.Button button_AddToGroup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button_Disallow;
        private System.Windows.Forms.Button button_Allow;
        private System.Windows.Forms.Button button_SendOnServer;
    }
}

