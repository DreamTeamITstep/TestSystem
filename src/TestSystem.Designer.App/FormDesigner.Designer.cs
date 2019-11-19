namespace TestSystem.Designer.App
{
    partial class FormDesigner
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_TestName = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.textBox_Theme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Subject = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_Answers = new System.Windows.Forms.TabControl();
            this.tabPage_Answers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_DeleteAnswer = new System.Windows.Forms.Button();
            this.button_NextAnswer = new System.Windows.Forms.Button();
            this.label_Answers = new System.Windows.Forms.Label();
            this.button_PreviousAnswer = new System.Windows.Forms.Button();
            this.button_AddAnswer = new System.Windows.Forms.Button();
            this.radioListBox_Answers = new TestSystem.Designer.App.RadioListBox();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label_Questions = new System.Windows.Forms.Label();
            this.button_AddQuestion = new System.Windows.Forms.Button();
            this.button_DeleteQuestion = new System.Windows.Forms.Button();
            this.button_NextQuestion = new System.Windows.Forms.Button();
            this.button_PreviousQuestion = new System.Windows.Forms.Button();
            this.tabControl_Question = new System.Windows.Forms.TabControl();
            this.tabPage_Question = new System.Windows.Forms.TabPage();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl_Answers.SuspendLayout();
            this.tabPage_Answers.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl_Question.SuspendLayout();
            this.tabPage_Question.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.testNameToolStripMenuItem,
            this.toolStripTextBox_TestName});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // testNameToolStripMenuItem
            // 
            this.testNameToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testNameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.testNameToolStripMenuItem.Enabled = false;
            this.testNameToolStripMenuItem.Name = "testNameToolStripMenuItem";
            this.testNameToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.testNameToolStripMenuItem.Text = "Test name";
            // 
            // toolStripTextBox_TestName
            // 
            this.toolStripTextBox_TestName.BackColor = System.Drawing.Color.Gray;
            this.toolStripTextBox_TestName.Name = "toolStripTextBox_TestName";
            this.toolStripTextBox_TestName.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_TestName.TextChanged += new System.EventHandler(this.toolStripTextBox_TestName_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(515, 361);
            this.splitContainer1.SplitterDistance = 35;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Author, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Theme, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Subject, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Author.Location = new System.Drawing.Point(428, 3);
            this.textBox_Author.Multiline = true;
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(84, 29);
            this.textBox_Author.TabIndex = 5;
            // 
            // textBox_Theme
            // 
            this.textBox_Theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Theme.Location = new System.Drawing.Point(258, 3);
            this.textBox_Theme.Multiline = true;
            this.textBox_Theme.Name = "textBox_Theme";
            this.textBox_Theme.Size = new System.Drawing.Size(79, 29);
            this.textBox_Theme.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theme";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Subject
            // 
            this.textBox_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Subject.Location = new System.Drawing.Point(88, 3);
            this.textBox_Subject.Multiline = true;
            this.textBox_Subject.Name = "textBox_Subject";
            this.textBox_Subject.Size = new System.Drawing.Size(79, 29);
            this.textBox_Subject.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl_Answers, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_Questions, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_AddQuestion, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_DeleteQuestion, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_NextQuestion, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_PreviousQuestion, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tabControl_Question, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(515, 322);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tabControl_Answers
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tabControl_Answers, 5);
            this.tabControl_Answers.Controls.Add(this.tabPage_Answers);
            this.tabControl_Answers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Answers.Location = new System.Drawing.Point(3, 109);
            this.tabControl_Answers.Name = "tabControl_Answers";
            this.tableLayoutPanel2.SetRowSpan(this.tabControl_Answers, 3);
            this.tabControl_Answers.SelectedIndex = 0;
            this.tabControl_Answers.Size = new System.Drawing.Size(509, 153);
            this.tabControl_Answers.TabIndex = 9;
            // 
            // tabPage_Answers
            // 
            this.tabPage_Answers.Controls.Add(this.tableLayoutPanel3);
            this.tabPage_Answers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Answers.Name = "tabPage_Answers";
            this.tabPage_Answers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Answers.Size = new System.Drawing.Size(501, 127);
            this.tabPage_Answers.TabIndex = 0;
            this.tabPage_Answers.Text = "Answers";
            this.tabPage_Answers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Controls.Add(this.button_DeleteAnswer, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.button_NextAnswer, 7, 3);
            this.tableLayoutPanel3.Controls.Add(this.label_Answers, 6, 3);
            this.tableLayoutPanel3.Controls.Add(this.button_PreviousAnswer, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.button_AddAnswer, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.radioListBox_Answers, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_Answer, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(495, 121);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button_DeleteAnswer
            // 
            this.button_DeleteAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DeleteAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_DeleteAnswer.Location = new System.Drawing.Point(247, 93);
            this.button_DeleteAnswer.Name = "button_DeleteAnswer";
            this.button_DeleteAnswer.Size = new System.Drawing.Size(55, 25);
            this.button_DeleteAnswer.TabIndex = 12;
            this.button_DeleteAnswer.Text = "Delete";
            this.button_DeleteAnswer.UseVisualStyleBackColor = true;
            this.button_DeleteAnswer.Click += new System.EventHandler(this.button_DeleteAnswer_Click);
            // 
            // button_NextAnswer
            // 
            this.button_NextAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_NextAnswer.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NextAnswer.Location = new System.Drawing.Point(430, 93);
            this.button_NextAnswer.Name = "button_NextAnswer";
            this.button_NextAnswer.Size = new System.Drawing.Size(62, 25);
            this.button_NextAnswer.TabIndex = 11;
            this.button_NextAnswer.Text = ">>>>";
            this.button_NextAnswer.UseVisualStyleBackColor = true;
            this.button_NextAnswer.Click += new System.EventHandler(this.button_NextAnswer_Click);
            // 
            // label_Answers
            // 
            this.label_Answers.AutoSize = true;
            this.label_Answers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Answers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Answers.Location = new System.Drawing.Point(369, 90);
            this.label_Answers.Name = "label_Answers";
            this.label_Answers.Size = new System.Drawing.Size(55, 31);
            this.label_Answers.TabIndex = 10;
            this.label_Answers.Text = "Answers\r\n0/0";
            this.label_Answers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_PreviousAnswer
            // 
            this.button_PreviousAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PreviousAnswer.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PreviousAnswer.Location = new System.Drawing.Point(308, 93);
            this.button_PreviousAnswer.Name = "button_PreviousAnswer";
            this.button_PreviousAnswer.Size = new System.Drawing.Size(55, 25);
            this.button_PreviousAnswer.TabIndex = 9;
            this.button_PreviousAnswer.Text = "<<<<";
            this.button_PreviousAnswer.UseVisualStyleBackColor = true;
            this.button_PreviousAnswer.Click += new System.EventHandler(this.button_PreviousAnswer_Click);
            // 
            // button_AddAnswer
            // 
            this.button_AddAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddAnswer.Location = new System.Drawing.Point(3, 93);
            this.button_AddAnswer.Name = "button_AddAnswer";
            this.button_AddAnswer.Size = new System.Drawing.Size(55, 25);
            this.button_AddAnswer.TabIndex = 8;
            this.button_AddAnswer.Text = "Add";
            this.button_AddAnswer.UseVisualStyleBackColor = true;
            this.button_AddAnswer.Click += new System.EventHandler(this.button_AddAnswer_Click);
            // 
            // radioListBox_Answers
            // 
            this.radioListBox_Answers.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel3.SetColumnSpan(this.radioListBox_Answers, 8);
            this.radioListBox_Answers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioListBox_Answers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.radioListBox_Answers.FormattingEnabled = true;
            this.radioListBox_Answers.Location = new System.Drawing.Point(3, 3);
            this.radioListBox_Answers.Name = "radioListBox_Answers";
            this.tableLayoutPanel3.SetRowSpan(this.radioListBox_Answers, 3);
            this.radioListBox_Answers.Size = new System.Drawing.Size(489, 84);
            this.radioListBox_Answers.TabIndex = 1;
            this.radioListBox_Answers.SelectedIndexChanged += new System.EventHandler(this.radioListBox_Answers_SelectedIndexChanged);
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.AccessibleDescription = "";
            this.textBox_Answer.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel3.SetColumnSpan(this.textBox_Answer, 3);
            this.textBox_Answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Answer.Location = new System.Drawing.Point(64, 93);
            this.textBox_Answer.Multiline = true;
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(177, 25);
            this.textBox_Answer.TabIndex = 2;
            this.textBox_Answer.TextChanged += new System.EventHandler(this.textBox_Answer_TextChanged);
            // 
            // label_Questions
            // 
            this.label_Questions.AutoSize = true;
            this.label_Questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Questions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Questions.Location = new System.Drawing.Point(209, 265);
            this.label_Questions.Name = "label_Questions";
            this.label_Questions.Size = new System.Drawing.Size(97, 57);
            this.label_Questions.TabIndex = 8;
            this.label_Questions.Text = "Questions\r\n0/0";
            this.label_Questions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_AddQuestion
            // 
            this.button_AddQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddQuestion.Location = new System.Drawing.Point(113, 272);
            this.button_AddQuestion.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.button_AddQuestion.Name = "button_AddQuestion";
            this.button_AddQuestion.Size = new System.Drawing.Size(83, 43);
            this.button_AddQuestion.TabIndex = 7;
            this.button_AddQuestion.Text = "Add\r\nquestion";
            this.button_AddQuestion.UseVisualStyleBackColor = true;
            this.button_AddQuestion.Click += new System.EventHandler(this.button_AddQuestion_Click);
            // 
            // button_DeleteQuestion
            // 
            this.button_DeleteQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DeleteQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_DeleteQuestion.Location = new System.Drawing.Point(319, 272);
            this.button_DeleteQuestion.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.button_DeleteQuestion.Name = "button_DeleteQuestion";
            this.button_DeleteQuestion.Size = new System.Drawing.Size(83, 43);
            this.button_DeleteQuestion.TabIndex = 6;
            this.button_DeleteQuestion.Text = "Delete\r\nquestion";
            this.button_DeleteQuestion.UseVisualStyleBackColor = true;
            this.button_DeleteQuestion.Click += new System.EventHandler(this.button_DeleteQuestion_Click);
            // 
            // button_NextQuestion
            // 
            this.button_NextQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_NextQuestion.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NextQuestion.Location = new System.Drawing.Point(422, 272);
            this.button_NextQuestion.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.button_NextQuestion.Name = "button_NextQuestion";
            this.button_NextQuestion.Size = new System.Drawing.Size(83, 43);
            this.button_NextQuestion.TabIndex = 5;
            this.button_NextQuestion.Text = ">>>>";
            this.button_NextQuestion.UseVisualStyleBackColor = true;
            this.button_NextQuestion.Click += new System.EventHandler(this.button_NextQuestion_Click);
            // 
            // button_PreviousQuestion
            // 
            this.button_PreviousQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PreviousQuestion.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PreviousQuestion.Location = new System.Drawing.Point(10, 272);
            this.button_PreviousQuestion.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.button_PreviousQuestion.Name = "button_PreviousQuestion";
            this.button_PreviousQuestion.Size = new System.Drawing.Size(83, 43);
            this.button_PreviousQuestion.TabIndex = 0;
            this.button_PreviousQuestion.Text = "<<<<";
            this.button_PreviousQuestion.UseVisualStyleBackColor = true;
            this.button_PreviousQuestion.Click += new System.EventHandler(this.button_PreviousQuestion_Click);
            // 
            // tabControl_Question
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tabControl_Question, 5);
            this.tabControl_Question.Controls.Add(this.tabPage_Question);
            this.tabControl_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Question.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Question.Name = "tabControl_Question";
            this.tableLayoutPanel2.SetRowSpan(this.tabControl_Question, 2);
            this.tabControl_Question.SelectedIndex = 0;
            this.tabControl_Question.Size = new System.Drawing.Size(509, 100);
            this.tabControl_Question.TabIndex = 4;
            // 
            // tabPage_Question
            // 
            this.tabPage_Question.Controls.Add(this.textBox_Question);
            this.tabPage_Question.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Question.Name = "tabPage_Question";
            this.tabPage_Question.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Question.Size = new System.Drawing.Size(501, 74);
            this.tabPage_Question.TabIndex = 0;
            this.tabPage_Question.Text = "Question";
            this.tabPage_Question.UseVisualStyleBackColor = true;
            // 
            // textBox_Question
            // 
            this.textBox_Question.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Question.Location = new System.Drawing.Point(3, 3);
            this.textBox_Question.Multiline = true;
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(495, 68);
            this.textBox_Question.TabIndex = 0;
            this.textBox_Question.TextChanged += new System.EventHandler(this.textBox_Question_TextChanged);
            // 
            // FormDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(515, 388);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDesigner";
            this.Text = "Test designer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl_Answers.ResumeLayout(false);
            this.tabPage_Answers.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl_Question.ResumeLayout(false);
            this.tabPage_Question.ResumeLayout(false);
            this.tabPage_Question.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.TextBox textBox_Theme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Subject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl_Answers;
        private System.Windows.Forms.TabPage tabPage_Answers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_NextAnswer;
        private System.Windows.Forms.Label label_Answers;
        private System.Windows.Forms.Button button_PreviousAnswer;
        private System.Windows.Forms.Button button_AddAnswer;
        private RadioListBox radioListBox_Answers;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_Questions;
        private System.Windows.Forms.Button button_AddQuestion;
        private System.Windows.Forms.Button button_DeleteQuestion;
        private System.Windows.Forms.Button button_NextQuestion;
        private System.Windows.Forms.Button button_PreviousQuestion;
        private System.Windows.Forms.TabControl tabControl_Question;
        private System.Windows.Forms.TabPage tabPage_Question;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.ToolStripMenuItem testNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_TestName;
        private System.Windows.Forms.Button button_DeleteAnswer;
    }
}

