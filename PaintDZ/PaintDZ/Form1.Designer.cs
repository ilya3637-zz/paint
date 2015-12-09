namespace PaintDZ
{
    partial class Main_Paint
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Paint));
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.cmdBox = new System.Windows.Forms.ComboBox();
            this.bGO = new System.Windows.Forms.Button();
            this.pColor = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bDeleteAll = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.chooseBar = new System.Windows.Forms.TrackBar();
            this.pLine = new System.Windows.Forms.PictureBox();
            this.pElli = new System.Windows.Forms.PictureBox();
            this.pFElli = new System.Windows.Forms.PictureBox();
            this.pRect = new System.Windows.Forms.PictureBox();
            this.pFRect = new System.Windows.Forms.PictureBox();
            this.thicknessBar = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bhistory = new System.Windows.Forms.Button();
            this.historyBox = new System.Windows.Forms.ListBox();
            this.listBoxNumber = new System.Windows.Forms.ListBox();
            this.historyBoxNumber = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bSize = new System.Windows.Forms.Button();
            this.bList = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bSaveList = new System.Windows.Forms.Button();
            this.bListLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pElli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFElli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingArea.Location = new System.Drawing.Point(594, 160);
            this.drawingArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawingArea.MaximumSize = new System.Drawing.Size(2999, 2307);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(749, 768);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            this.drawingArea.WaitOnLoad = true;
            this.drawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.bRe);
            this.drawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseDown);
            this.drawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseMove);
            this.drawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseUp);
            // 
            // cmdBox
            // 
            this.cmdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdBox.DropDownHeight = 500;
            this.cmdBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdBox.FormattingEnabled = true;
            this.cmdBox.IntegralHeight = false;
            this.cmdBox.Items.AddRange(new object[] {
            "delete all",
            "",
            "draw filled rectangle   50,70,200,200",
            "draw rectangle   50,50,200,520",
            "draw filled ellipse   10,50,200,200",
            "draw ellipse   3,50,200,200",
            "draw line   50,100,200,200",
            " ",
            "draw 2  filled rectangles 10,50,100,100 with an interval  120,120",
            "draw 2  filled ellipses   50,50,100,100 with an interval  120,120",
            "draw 4 ellipses    100,50,100,100 with an interval  100,100",
            "draw 4 rectangles 50,50,100,100  with an interval  100,100"});
            this.cmdBox.Location = new System.Drawing.Point(616, 3);
            this.cmdBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBox.MaxDropDownItems = 12;
            this.cmdBox.MaxLength = 100;
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(790, 37);
            this.cmdBox.TabIndex = 1;
            this.cmdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // bGO
            // 
            this.bGO.BackColor = System.Drawing.Color.Snow;
            this.bGO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bGO.BackgroundImage")));
            this.bGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bGO.FlatAppearance.BorderSize = 0;
            this.bGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bGO.Location = new System.Drawing.Point(1418, -2);
            this.bGO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGO.Name = "bGO";
            this.bGO.Size = new System.Drawing.Size(45, 46);
            this.bGO.TabIndex = 2;
            this.bGO.UseVisualStyleBackColor = false;
            this.bGO.Click += new System.EventHandler(this.bGO_Click);
            this.bGO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // pColor
            // 
            this.pColor.BackColor = System.Drawing.Color.Gold;
            this.pColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pColor.BackgroundImage")));
            this.pColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor.Location = new System.Drawing.Point(4, 62);
            this.pColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(75, 77);
            this.pColor.TabIndex = 3;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            this.pColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pColor_Paint);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Fuchsia;
            this.colorDialog1.FullOpen = true;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Snow;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 29;
            this.listBox.Location = new System.Drawing.Point(80, 300);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(506, 464);
            this.listBox.TabIndex = 4;
            this.listBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            this.listBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxNumber_MouseUp);
            this.listBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxNumber_MouseUp);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.White;
            this.bDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDelete.BackgroundImage")));
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDelete.FlatAppearance.BorderSize = 0;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.Location = new System.Drawing.Point(117, 155);
            this.bDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(45, 45);
            this.bDelete.TabIndex = 6;
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            this.bDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // bDeleteAll
            // 
            this.bDeleteAll.BackColor = System.Drawing.Color.White;
            this.bDeleteAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDeleteAll.BackgroundImage")));
            this.bDeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteAll.FlatAppearance.BorderSize = 0;
            this.bDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDeleteAll.Location = new System.Drawing.Point(13, 155);
            this.bDeleteAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bDeleteAll.Name = "bDeleteAll";
            this.bDeleteAll.Size = new System.Drawing.Size(45, 45);
            this.bDeleteAll.TabIndex = 7;
            this.bDeleteAll.UseVisualStyleBackColor = false;
            this.bDeleteAll.Click += new System.EventHandler(this.bDeleteAll_Click);
            this.bDeleteAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.Color.Snow;
            this.bRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bRefresh.BackgroundImage")));
            this.bRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRefresh.FlatAppearance.BorderSize = 0;
            this.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRefresh.Location = new System.Drawing.Point(64, 155);
            this.bRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(45, 45);
            this.bRefresh.TabIndex = 8;
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // chooseBar
            // 
            this.chooseBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseBar.Enabled = false;
            this.chooseBar.Location = new System.Drawing.Point(108, 18);
            this.chooseBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseBar.Maximum = 6;
            this.chooseBar.Minimum = 1;
            this.chooseBar.Name = "chooseBar";
            this.chooseBar.Size = new System.Drawing.Size(462, 69);
            this.chooseBar.TabIndex = 9;
            this.chooseBar.Value = 1;
            this.chooseBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            this.chooseBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chooseBar_MouseDown);
            // 
            // pLine
            // 
            this.pLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLine.BackgroundImage")));
            this.pLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLine.Location = new System.Drawing.Point(98, 63);
            this.pLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pLine.Name = "pLine";
            this.pLine.Size = new System.Drawing.Size(86, 77);
            this.pLine.TabIndex = 10;
            this.pLine.TabStop = false;
            this.pLine.Click += new System.EventHandler(this.pLine_Click);
            // 
            // pElli
            // 
            this.pElli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pElli.BackgroundImage")));
            this.pElli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pElli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pElli.Location = new System.Drawing.Point(182, 63);
            this.pElli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pElli.Name = "pElli";
            this.pElli.Size = new System.Drawing.Size(86, 77);
            this.pElli.TabIndex = 11;
            this.pElli.TabStop = false;
            this.pElli.Click += new System.EventHandler(this.pElli_Click);
            // 
            // pFElli
            // 
            this.pFElli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pFElli.BackgroundImage")));
            this.pFElli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pFElli.Location = new System.Drawing.Point(264, 63);
            this.pFElli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pFElli.Name = "pFElli";
            this.pFElli.Size = new System.Drawing.Size(87, 77);
            this.pFElli.TabIndex = 12;
            this.pFElli.TabStop = false;
            this.pFElli.Click += new System.EventHandler(this.pFElli_Click);
            // 
            // pRect
            // 
            this.pRect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pRect.BackgroundImage")));
            this.pRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pRect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pRect.Location = new System.Drawing.Point(350, 63);
            this.pRect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pRect.Name = "pRect";
            this.pRect.Size = new System.Drawing.Size(86, 77);
            this.pRect.TabIndex = 13;
            this.pRect.TabStop = false;
            this.pRect.Click += new System.EventHandler(this.pRect_Click);
            // 
            // pFRect
            // 
            this.pFRect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pFRect.BackgroundImage")));
            this.pFRect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pFRect.Location = new System.Drawing.Point(434, 63);
            this.pFRect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pFRect.Name = "pFRect";
            this.pFRect.Size = new System.Drawing.Size(86, 77);
            this.pFRect.TabIndex = 14;
            this.pFRect.TabStop = false;
            this.pFRect.Click += new System.EventHandler(this.pFRect_Click);
            // 
            // thicknessBar
            // 
            this.thicknessBar.BackColor = System.Drawing.Color.Snow;
            this.thicknessBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thicknessBar.LargeChange = 1;
            this.thicknessBar.Location = new System.Drawing.Point(200, 155);
            this.thicknessBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thicknessBar.Maximum = 50;
            this.thicknessBar.Minimum = 25;
            this.thicknessBar.Name = "thicknessBar";
            this.thicknessBar.Size = new System.Drawing.Size(399, 69);
            this.thicknessBar.TabIndex = 15;
            this.thicknessBar.Value = 40;
            this.thicknessBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(518, 63);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 77);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bhistory
            // 
            this.bhistory.BackColor = System.Drawing.Color.Aqua;
            this.bhistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bhistory.BackgroundImage")));
            this.bhistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bhistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bhistory.FlatAppearance.BorderSize = 2;
            this.bhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bhistory.Location = new System.Drawing.Point(4, 255);
            this.bhistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bhistory.Name = "bhistory";
            this.bhistory.Size = new System.Drawing.Size(292, 48);
            this.bhistory.TabIndex = 19;
            this.bhistory.Text = " ";
            this.bhistory.UseVisualStyleBackColor = false;
            this.bhistory.Click += new System.EventHandler(this.bhistory_Click);
            this.bhistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // historyBox
            // 
            this.historyBox.BackColor = System.Drawing.Color.Snow;
            this.historyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyBox.Cursor = System.Windows.Forms.Cursors.No;
            this.historyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.historyBox.FormattingEnabled = true;
            this.historyBox.ItemHeight = 29;
            this.historyBox.Location = new System.Drawing.Point(80, 300);
            this.historyBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(506, 464);
            this.historyBox.TabIndex = 20;
            this.historyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            this.historyBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.historyBox_MouseUp);
            this.historyBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.historyBox_MouseUp);
            // 
            // listBoxNumber
            // 
            this.listBoxNumber.BackColor = System.Drawing.Color.Snow;
            this.listBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNumber.Cursor = System.Windows.Forms.Cursors.No;
            this.listBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.listBoxNumber.FormattingEnabled = true;
            this.listBoxNumber.ItemHeight = 29;
            this.listBoxNumber.Location = new System.Drawing.Point(4, 300);
            this.listBoxNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxNumber.Name = "listBoxNumber";
            this.listBoxNumber.Size = new System.Drawing.Size(75, 464);
            this.listBoxNumber.TabIndex = 21;
            this.listBoxNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            this.listBoxNumber.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxNumber_MouseUp);
            this.listBoxNumber.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxNumber_MouseUp);
            // 
            // historyBoxNumber
            // 
            this.historyBoxNumber.BackColor = System.Drawing.Color.Snow;
            this.historyBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyBoxNumber.Cursor = System.Windows.Forms.Cursors.No;
            this.historyBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.historyBoxNumber.FormattingEnabled = true;
            this.historyBoxNumber.ItemHeight = 29;
            this.historyBoxNumber.Location = new System.Drawing.Point(4, 300);
            this.historyBoxNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyBoxNumber.Name = "historyBoxNumber";
            this.historyBoxNumber.Size = new System.Drawing.Size(75, 464);
            this.historyBoxNumber.TabIndex = 22;
            this.historyBoxNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(8, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 46);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // bSize
            // 
            this.bSize.BackColor = System.Drawing.Color.Snow;
            this.bSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSize.BackgroundImage")));
            this.bSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSize.FlatAppearance.BorderSize = 0;
            this.bSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSize.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSize.Location = new System.Drawing.Point(764, 75);
            this.bSize.Name = "bSize";
            this.bSize.Size = new System.Drawing.Size(75, 77);
            this.bSize.TabIndex = 26;
            this.bSize.UseVisualStyleBackColor = false;
            this.bSize.Click += new System.EventHandler(this.bSize_Click);
            this.bSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // bList
            // 
            this.bList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bList.BackgroundImage")));
            this.bList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bList.FlatAppearance.BorderSize = 2;
            this.bList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bList.Location = new System.Drawing.Point(297, 255);
            this.bList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bList.Name = "bList";
            this.bList.Size = new System.Drawing.Size(288, 48);
            this.bList.TabIndex = 27;
            this.bList.UseVisualStyleBackColor = false;
            this.bList.Click += new System.EventHandler(this.bList_Click);
            this.bList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // textBoxX
            // 
            this.textBoxX.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(651, 80);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxX.MaxLength = 4;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(103, 30);
            this.textBoxX.TabIndex = 28;
            this.textBoxX.Text = "500";
            this.textBoxX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // textBoxY
            // 
            this.textBoxY.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY.Location = new System.Drawing.Point(651, 115);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxY.MaxLength = 4;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(103, 30);
            this.textBoxY.TabIndex = 29;
            this.textBoxY.Text = "500";
            this.textBoxY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelX.Enabled = false;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(616, 85);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(27, 25);
            this.labelX.TabIndex = 30;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelY.Enabled = false;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(616, 122);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(26, 25);
            this.labelY.TabIndex = 31;
            this.labelY.Text = "Y";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(211, 193);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 31);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // bSave
            // 
            this.bSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSave.BackgroundImage")));
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.FlatAppearance.BorderSize = 0;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Location = new System.Drawing.Point(62, 2);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(45, 46);
            this.bSave.TabIndex = 33;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bSaveList
            // 
            this.bSaveList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSaveList.BackgroundImage")));
            this.bSaveList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bSaveList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSaveList.FlatAppearance.BorderSize = 0;
            this.bSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveList.Location = new System.Drawing.Point(34, 208);
            this.bSaveList.Name = "bSaveList";
            this.bSaveList.Size = new System.Drawing.Size(45, 45);
            this.bSaveList.TabIndex = 34;
            this.bSaveList.UseVisualStyleBackColor = true;
            this.bSaveList.Click += new System.EventHandler(this.bSaveList_Click);
            // 
            // bListLoad
            // 
            this.bListLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bListLoad.BackgroundImage")));
            this.bListLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bListLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bListLoad.FlatAppearance.BorderSize = 0;
            this.bListLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bListLoad.Location = new System.Drawing.Point(98, 208);
            this.bListLoad.Name = "bListLoad";
            this.bListLoad.Size = new System.Drawing.Size(45, 45);
            this.bListLoad.TabIndex = 35;
            this.bListLoad.UseVisualStyleBackColor = true;
            this.bListLoad.Click += new System.EventHandler(this.bListLoad_Click);
            // 
            // Main_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(2012, 963);
            this.Controls.Add(this.bListLoad);
            this.Controls.Add(this.bSaveList);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bList);
            this.Controls.Add(this.bhistory);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.bSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.historyBoxNumber);
            this.Controls.Add(this.listBoxNumber);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pFRect);
            this.Controls.Add(this.pRect);
            this.Controls.Add(this.pFElli);
            this.Controls.Add(this.pElli);
            this.Controls.Add(this.pLine);
            this.Controls.Add(this.chooseBar);
            this.Controls.Add(this.bDeleteAll);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.bGO);
            this.Controls.Add(this.thicknessBar);
            this.Controls.Add(this.bRefresh);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(7489, 4585);
            this.MinimumSize = new System.Drawing.Size(637, 631);
            this.Name = "Main_Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Paint_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pElli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFElli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.ComboBox cmdBox;
        private System.Windows.Forms.Button bGO;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bDeleteAll;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.TrackBar chooseBar;
        private System.Windows.Forms.PictureBox pLine;
        private System.Windows.Forms.PictureBox pElli;
        private System.Windows.Forms.PictureBox pFElli;
        private System.Windows.Forms.PictureBox pRect;
        private System.Windows.Forms.PictureBox pFRect;
        private System.Windows.Forms.TrackBar thicknessBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bhistory;
        private System.Windows.Forms.ListBox historyBox;
        private System.Windows.Forms.ListBox listBoxNumber;
        private System.Windows.Forms.ListBox historyBoxNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bSize;
        private System.Windows.Forms.Button bList;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bSaveList;
        private System.Windows.Forms.Button bListLoad;
    }
}

