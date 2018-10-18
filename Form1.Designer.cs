namespace Cats_papers {
    partial class Form1 {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CopyPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnlyCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_16 = new System.Windows.Forms.TextBox();
            this.textBox_15 = new System.Windows.Forms.TextBox();
            this.textBox_14 = new System.Windows.Forms.TextBox();
            this.textBox_13 = new System.Windows.Forms.TextBox();
            this.textBox_12 = new System.Windows.Forms.TextBox();
            this.originalLable = new System.Windows.Forms.Label();
            this.textBox_11 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.resultLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Formalize = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.CopyPaste.SuspendLayout();
            this.OnlyCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.titleLayoutPanel.SuspendLayout();
            this.resultLayoutPanel.SuspendLayout();
            this.buttonsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyPaste
            // 
            this.CopyPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.CopyPaste.Name = "contextMenuStrip1";
            this.CopyPaste.ShowImageMargin = false;
            this.CopyPaste.Size = new System.Drawing.Size(115, 48);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.Context_Menu_Copy);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.Context_Menu_Paste);
            // 
            // OnlyCopy
            // 
            this.OnlyCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem1});
            this.OnlyCopy.Name = "OnlyCopy";
            this.OnlyCopy.ShowImageMargin = false;
            this.OnlyCopy.Size = new System.Drawing.Size(115, 26);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.Context_Menu_Copy);
            // 
            // Help
            // 
            this.Help.AutomaticDelay = 10000000;
            this.Help.AutoPopDelay = 10000000;
            this.Help.InitialDelay = 500;
            this.Help.ReshowDelay = 100;
            this.Help.UseAnimation = false;
            this.Help.UseFading = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.NavajoWhite;
            this.label10.Location = new System.Drawing.Point(109, 2);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 37);
            this.label10.TabIndex = 16;
            this.label10.Text = "Название";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Help.SetToolTip(this.label10, "Полное название источника или сайта\r\n");
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.NavajoWhite;
            this.label9.Location = new System.Drawing.Point(28, 2);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "Автор или ссылка";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Help.SetToolTip(this.label9, "И.О. Фамилия, И.О. Фамилия, ... \r\nили ссылка на сайт (начиная с http)");
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(2, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "№";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Help.SetToolTip(this.label8, "Нумерация источников");
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label11.Location = new System.Drawing.Point(271, 2);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 37);
            this.label11.TabIndex = 17;
            this.label11.Text = "Издательство";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Help.SetToolTip(this.label11, "Наименование издательства\r\n(не обязательно для заполнения)");
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label12.Location = new System.Drawing.Point(352, 2);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 37);
            this.label12.TabIndex = 18;
            this.label12.Text = "Город издания";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Help.SetToolTip(this.label12, "Город издания источника\r\n(не обязательно для заполнения)");
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label13.Location = new System.Drawing.Point(433, 2);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 37);
            this.label13.TabIndex = 19;
            this.label13.Text = "Год издания";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Help.SetToolTip(this.label13, "Год издания источника\r\n(не обязательно для заполнения)");
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.NavajoWhite;
            this.label14.Location = new System.Drawing.Point(487, 2);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 37);
            this.label14.TabIndex = 20;
            this.label14.Text = "Объем";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Help.SetToolTip(this.label14, "Объем источника в страницах");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::Cats_papers.Properties.Settings.Default, "SplitterDistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 540;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resultLayoutPanel);
            this.splitContainer1.Panel2MinSize = 340;
            this.splitContainer1.Size = new System.Drawing.Size(884, 361);
            this.splitContainer1.SplitterDistance = global::Cats_papers.Properties.Settings.Default.SplitterDistance;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.Splitter_Position);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.mainTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 321);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 40);
            this.panel3.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.AutoSize = true;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(40)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(194, 1);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(134, 38);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // mainTable
            // 
            this.mainTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTable.ColumnCount = 7;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTable.Controls.Add(this.textBox_16, 6, 0);
            this.mainTable.Controls.Add(this.textBox_15, 5, 0);
            this.mainTable.Controls.Add(this.textBox_14, 4, 0);
            this.mainTable.Controls.Add(this.textBox_13, 3, 0);
            this.mainTable.Controls.Add(this.textBox_12, 2, 0);
            this.mainTable.Controls.Add(this.originalLable, 0, 0);
            this.mainTable.Controls.Add(this.textBox_11, 1, 0);
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.mainTable.Size = new System.Drawing.Size(540, 40);
            this.mainTable.TabIndex = 0;
            // 
            // textBox_16
            // 
            this.textBox_16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_16.BackColor = System.Drawing.Color.White;
            this.textBox_16.ContextMenuStrip = this.CopyPaste;
            this.textBox_16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_16.HideSelection = false;
            this.textBox_16.Location = new System.Drawing.Point(487, 2);
            this.textBox_16.Margin = new System.Windows.Forms.Padding(1, 2, 1, 10);
            this.textBox_16.Name = "textBox_16";
            this.textBox_16.Size = new System.Drawing.Size(52, 26);
            this.textBox_16.TabIndex = 16;
            this.textBox_16.WordWrap = false;
            this.textBox_16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.textBox_16.Leave += new System.EventHandler(this.Text_View_Correct);
            // 
            // textBox_15
            // 
            this.textBox_15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_15.BackColor = System.Drawing.Color.White;
            this.textBox_15.ContextMenuStrip = this.CopyPaste;
            this.textBox_15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_15.HideSelection = false;
            this.textBox_15.Location = new System.Drawing.Point(433, 2);
            this.textBox_15.Margin = new System.Windows.Forms.Padding(1, 2, 1, 10);
            this.textBox_15.Name = "textBox_15";
            this.textBox_15.Size = new System.Drawing.Size(52, 26);
            this.textBox_15.TabIndex = 15;
            this.textBox_15.WordWrap = false;
            this.textBox_15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.textBox_15.Leave += new System.EventHandler(this.Text_View_Correct);
            // 
            // textBox_14
            // 
            this.textBox_14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_14.BackColor = System.Drawing.Color.White;
            this.textBox_14.ContextMenuStrip = this.CopyPaste;
            this.textBox_14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_14.HideSelection = false;
            this.textBox_14.Location = new System.Drawing.Point(352, 2);
            this.textBox_14.Margin = new System.Windows.Forms.Padding(1, 2, 1, 10);
            this.textBox_14.Name = "textBox_14";
            this.textBox_14.Size = new System.Drawing.Size(79, 26);
            this.textBox_14.TabIndex = 14;
            this.textBox_14.WordWrap = false;
            this.textBox_14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.textBox_14.Leave += new System.EventHandler(this.Text_View_Correct);
            // 
            // textBox_13
            // 
            this.textBox_13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_13.BackColor = System.Drawing.Color.White;
            this.textBox_13.ContextMenuStrip = this.CopyPaste;
            this.textBox_13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_13.HideSelection = false;
            this.textBox_13.Location = new System.Drawing.Point(271, 2);
            this.textBox_13.Margin = new System.Windows.Forms.Padding(1, 2, 1, 10);
            this.textBox_13.Name = "textBox_13";
            this.textBox_13.Size = new System.Drawing.Size(79, 26);
            this.textBox_13.TabIndex = 13;
            this.textBox_13.WordWrap = false;
            this.textBox_13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.textBox_13.Leave += new System.EventHandler(this.Text_View_Correct);
            // 
            // textBox_12
            // 
            this.textBox_12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_12.BackColor = System.Drawing.Color.White;
            this.textBox_12.ContextMenuStrip = this.CopyPaste;
            this.textBox_12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_12.HideSelection = false;
            this.textBox_12.Location = new System.Drawing.Point(109, 2);
            this.textBox_12.Margin = new System.Windows.Forms.Padding(1, 2, 1, 10);
            this.textBox_12.Name = "textBox_12";
            this.textBox_12.Size = new System.Drawing.Size(160, 26);
            this.textBox_12.TabIndex = 12;
            this.textBox_12.WordWrap = false;
            this.textBox_12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.textBox_12.Leave += new System.EventHandler(this.Text_View_Correct);
            // 
            // originalLable
            // 
            this.originalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalLable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.originalLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalLable.Location = new System.Drawing.Point(2, 2);
            this.originalLable.Margin = new System.Windows.Forms.Padding(2, 2, 1, 14);
            this.originalLable.MinimumSize = new System.Drawing.Size(2, 26);
            this.originalLable.Name = "originalLable";
            this.originalLable.Size = new System.Drawing.Size(24, 26);
            this.originalLable.TabIndex = 14;
            this.originalLable.Text = "1";
            this.originalLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_11
            // 
            this.textBox_11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_11.BackColor = System.Drawing.Color.White;
            this.textBox_11.ContextMenuStrip = this.CopyPaste;
            this.textBox_11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_11.HideSelection = false;
            this.textBox_11.Location = new System.Drawing.Point(28, 2);
            this.textBox_11.Margin = new System.Windows.Forms.Padding(1, 2, 1, 10);
            this.textBox_11.Name = "textBox_11";
            this.textBox_11.Size = new System.Drawing.Size(79, 26);
            this.textBox_11.TabIndex = 11;
            this.textBox_11.WordWrap = false;
            this.textBox_11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.textBox_11.Leave += new System.EventHandler(this.Text_View_Correct);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.titleLayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 40);
            this.panel1.TabIndex = 3;
            // 
            // titleLayoutPanel
            // 
            this.titleLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLayoutPanel.ColumnCount = 7;
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.titleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.titleLayoutPanel.Controls.Add(this.label10, 0, 0);
            this.titleLayoutPanel.Controls.Add(this.label9, 0, 0);
            this.titleLayoutPanel.Controls.Add(this.label8, 0, 0);
            this.titleLayoutPanel.Controls.Add(this.label11, 3, 0);
            this.titleLayoutPanel.Controls.Add(this.label12, 4, 0);
            this.titleLayoutPanel.Controls.Add(this.label13, 5, 0);
            this.titleLayoutPanel.Controls.Add(this.label14, 6, 0);
            this.titleLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.titleLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLayoutPanel.Name = "titleLayoutPanel";
            this.titleLayoutPanel.RowCount = 1;
            this.titleLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titleLayoutPanel.Size = new System.Drawing.Size(540, 40);
            this.titleLayoutPanel.TabIndex = 0;
            // 
            // resultLayoutPanel
            // 
            this.resultLayoutPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resultLayoutPanel.ColumnCount = 1;
            this.resultLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resultLayoutPanel.Controls.Add(this.buttonsLayoutPanel, 0, 0);
            this.resultLayoutPanel.Controls.Add(this.Result, 0, 1);
            this.resultLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.resultLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.resultLayoutPanel.Name = "resultLayoutPanel";
            this.resultLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.resultLayoutPanel.RowCount = 2;
            this.resultLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.resultLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.resultLayoutPanel.Size = new System.Drawing.Size(340, 361);
            this.resultLayoutPanel.TabIndex = 0;
            // 
            // buttonsLayoutPanel
            // 
            this.buttonsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsLayoutPanel.BackColor = System.Drawing.Color.LightBlue;
            this.buttonsLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.buttonsLayoutPanel.ColumnCount = 2;
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayoutPanel.Controls.Add(this.Formalize, 0, 0);
            this.buttonsLayoutPanel.Controls.Add(this.Copy, 1, 0);
            this.buttonsLayoutPanel.Location = new System.Drawing.Point(0, 2);
            this.buttonsLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            this.buttonsLayoutPanel.RowCount = 1;
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.buttonsLayoutPanel.Size = new System.Drawing.Size(338, 50);
            this.buttonsLayoutPanel.TabIndex = 0;
            // 
            // Formalize
            // 
            this.Formalize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Formalize.AutoSize = true;
            this.Formalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.Formalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Formalize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Formalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.Formalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
            this.Formalize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Formalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Formalize.Image = ((System.Drawing.Image)(resources.GetObject("Formalize.Image")));
            this.Formalize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Formalize.Location = new System.Drawing.Point(14, 6);
            this.Formalize.Margin = new System.Windows.Forms.Padding(0);
            this.Formalize.Name = "Formalize";
            this.Formalize.Size = new System.Drawing.Size(142, 38);
            this.Formalize.TabIndex = 0;
            this.Formalize.Text = "Оформить";
            this.Formalize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Formalize.UseVisualStyleBackColor = false;
            this.Formalize.Click += new System.EventHandler(this.Formalize_Click);
            // 
            // Copy
            // 
            this.Copy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Copy.AutoSize = true;
            this.Copy.BackColor = System.Drawing.Color.Gainsboro;
            this.Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Copy.Location = new System.Drawing.Point(172, 6);
            this.Copy.Margin = new System.Windows.Forms.Padding(0);
            this.Copy.Name = "Copy";
            this.Copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Copy.Size = new System.Drawing.Size(162, 38);
            this.Copy.TabIndex = 1;
            this.Copy.Text = "Скопировать";
            this.Copy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Result.ContextMenuStrip = this.OnlyCopy;
            this.Result.DetectUrls = false;
            this.Result.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Result.Location = new System.Drawing.Point(0, 52);
            this.Result.Margin = new System.Windows.Forms.Padding(0);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(338, 309);
            this.Result.TabIndex = 1;
            this.Result.Text = "";
            this.Result.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cat\'s papers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.CopyPaste.ResumeLayout(false);
            this.OnlyCopy.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.titleLayoutPanel.ResumeLayout(false);
            this.titleLayoutPanel.PerformLayout();
            this.resultLayoutPanel.ResumeLayout(false);
            this.buttonsLayoutPanel.ResumeLayout(false);
            this.buttonsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel resultLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonsLayoutPanel;
        private System.Windows.Forms.Button Formalize;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.ToolTip Help;
        private System.Windows.Forms.Label originalLable;
        private System.Windows.Forms.ContextMenuStrip CopyPaste;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip OnlyCopy;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel titleLayoutPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBox_11;
        private System.Windows.Forms.TextBox textBox_16;
        private System.Windows.Forms.TextBox textBox_15;
        private System.Windows.Forms.TextBox textBox_14;
        private System.Windows.Forms.TextBox textBox_13;
        private System.Windows.Forms.TextBox textBox_12;





    }
}

