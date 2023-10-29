namespace Paint2D
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox = new PictureBox();
            OperateArea = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelFile = new FlowLayoutPanel();
            buttonOpen = new Button();
            buttonNew = new Button();
            buttonSave = new Button();
            buttonSaveAs = new Button();
            panelImageOperate = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonHorizontal = new Button();
            buttonVertical = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            buttonAntiClock = new Button();
            buttonClock = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            buttonResize = new Button();
            buttonDelete = new Button();
            panelTools = new FlowLayoutPanel();
            buttonPen = new Button();
            buttonEraser = new Button();
            buttonText = new Button();
            buttonBucket = new Button();
            panelThickness = new FlowLayoutPanel();
            textBoxThickness = new TextBox();
            trackBarOfThickness = new TrackBar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonBlack = new Button();
            buttonWhite = new Button();
            buttonRed = new Button();
            buttonYellow = new Button();
            buttonBlue = new Button();
            buttonGreen = new Button();
            buttonPickColor = new Button();
            panelSelectedColor = new Panel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            pictureBoxLine = new PictureBox();
            pictureBoxCircle = new PictureBox();
            pictureBoxEllipse = new PictureBox();
            pictureBoxTriangle = new PictureBox();
            pictureBoxSquare = new PictureBox();
            pictureBoxRectangle = new PictureBox();
            tableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            OperateArea.SuspendLayout();
            panelFile.SuspendLayout();
            panelImageOperate.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panelTools.SuspendLayout();
            panelThickness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarOfThickness).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCircle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEllipse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTriangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSquare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRectangle).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(3, 178);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(800, 500);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // OperateArea
            // 
            OperateArea.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            OperateArea.ColumnCount = 6;
            OperateArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            OperateArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215F));
            OperateArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            OperateArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            OperateArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            OperateArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 211F));
            OperateArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            OperateArea.Controls.Add(label6, 3, 0);
            OperateArea.Controls.Add(label5, 5, 0);
            OperateArea.Controls.Add(label4, 4, 0);
            OperateArea.Controls.Add(label3, 2, 0);
            OperateArea.Controls.Add(label2, 1, 0);
            OperateArea.Controls.Add(label1, 0, 0);
            OperateArea.Controls.Add(panelFile, 0, 1);
            OperateArea.Controls.Add(panelImageOperate, 1, 1);
            OperateArea.Controls.Add(panelTools, 2, 1);
            OperateArea.Controls.Add(panelThickness, 3, 1);
            OperateArea.Controls.Add(flowLayoutPanel1, 4, 1);
            OperateArea.Controls.Add(flowLayoutPanel5, 5, 1);
            OperateArea.Location = new Point(3, 3);
            OperateArea.Name = "OperateArea";
            OperateArea.RowCount = 2;
            OperateArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            OperateArea.RowStyles.Add(new RowStyle());
            OperateArea.Size = new Size(800, 169);
            OperateArea.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(412, 1);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 8;
            label6.Text = "粗细";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(594, 1);
            label5.Name = "label5";
            label5.Size = new Size(205, 20);
            label5.TabIndex = 5;
            label5.Text = "形状";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(513, 1);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "颜色";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(306, 1);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 3;
            label3.Text = "工具";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(90, 1);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 2;
            label2.Text = "图像操作";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "文件";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFile
            // 
            panelFile.Controls.Add(buttonOpen);
            panelFile.Controls.Add(buttonNew);
            panelFile.Controls.Add(buttonSave);
            panelFile.Controls.Add(buttonSaveAs);
            panelFile.Dock = DockStyle.Fill;
            panelFile.FlowDirection = FlowDirection.TopDown;
            panelFile.Location = new Point(4, 25);
            panelFile.Name = "panelFile";
            panelFile.Size = new Size(79, 151);
            panelFile.TabIndex = 0;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(3, 3);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(70, 30);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "打开";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(3, 39);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(70, 30);
            buttonNew.TabIndex = 3;
            buttonNew.Text = "新建";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(3, 75);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(70, 30);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "保存";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAs
            // 
            buttonSaveAs.Location = new Point(3, 111);
            buttonSaveAs.Name = "buttonSaveAs";
            buttonSaveAs.Size = new Size(70, 30);
            buttonSaveAs.TabIndex = 2;
            buttonSaveAs.Text = "另存为";
            buttonSaveAs.UseVisualStyleBackColor = true;
            buttonSaveAs.Click += buttonSaveAs_Click;
            // 
            // panelImageOperate
            // 
            panelImageOperate.ColumnCount = 1;
            panelImageOperate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelImageOperate.Controls.Add(flowLayoutPanel2, 0, 1);
            panelImageOperate.Controls.Add(flowLayoutPanel3, 0, 2);
            panelImageOperate.Controls.Add(flowLayoutPanel4, 0, 0);
            panelImageOperate.Dock = DockStyle.Fill;
            panelImageOperate.Location = new Point(90, 25);
            panelImageOperate.Name = "panelImageOperate";
            panelImageOperate.RowCount = 3;
            panelImageOperate.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelImageOperate.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelImageOperate.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelImageOperate.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelImageOperate.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelImageOperate.Size = new Size(209, 151);
            panelImageOperate.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonHorizontal);
            flowLayoutPanel2.Controls.Add(buttonVertical);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 53);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(203, 44);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // buttonHorizontal
            // 
            buttonHorizontal.Location = new Point(2, 2);
            buttonHorizontal.Margin = new Padding(2);
            buttonHorizontal.Name = "buttonHorizontal";
            buttonHorizontal.Size = new Size(95, 40);
            buttonHorizontal.TabIndex = 0;
            buttonHorizontal.Text = "水平翻转";
            buttonHorizontal.UseVisualStyleBackColor = true;
            buttonHorizontal.Click += buttonHorizontal_Click;
            // 
            // buttonVertical
            // 
            buttonVertical.Location = new Point(101, 2);
            buttonVertical.Margin = new Padding(2);
            buttonVertical.Name = "buttonVertical";
            buttonVertical.Size = new Size(95, 40);
            buttonVertical.TabIndex = 1;
            buttonVertical.Text = "垂直翻转";
            buttonVertical.UseVisualStyleBackColor = true;
            buttonVertical.Click += buttonVertical_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(buttonAntiClock);
            flowLayoutPanel3.Controls.Add(buttonClock);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 103);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(203, 45);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // buttonAntiClock
            // 
            buttonAntiClock.Font = new Font("更纱黑体 UI SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAntiClock.Location = new Point(2, 2);
            buttonAntiClock.Margin = new Padding(2);
            buttonAntiClock.Name = "buttonAntiClock";
            buttonAntiClock.Size = new Size(95, 40);
            buttonAntiClock.TabIndex = 0;
            buttonAntiClock.Text = "逆时针旋转";
            buttonAntiClock.UseVisualStyleBackColor = true;
            buttonAntiClock.Click += buttonAntiClock_Click;
            // 
            // buttonClock
            // 
            buttonClock.Font = new Font("更纱黑体 UI SC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClock.Location = new Point(101, 2);
            buttonClock.Margin = new Padding(2);
            buttonClock.Name = "buttonClock";
            buttonClock.Size = new Size(95, 40);
            buttonClock.TabIndex = 1;
            buttonClock.Text = "顺时针旋转";
            buttonClock.UseVisualStyleBackColor = true;
            buttonClock.Click += buttonClock_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(buttonResize);
            flowLayoutPanel4.Controls.Add(buttonDelete);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(203, 44);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // buttonResize
            // 
            buttonResize.Location = new Point(2, 2);
            buttonResize.Margin = new Padding(2);
            buttonResize.Name = "buttonResize";
            buttonResize.Size = new Size(95, 40);
            buttonResize.TabIndex = 0;
            buttonResize.Text = "调整大小";
            buttonResize.UseVisualStyleBackColor = true;
            buttonResize.Click += buttonResize_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(101, 2);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(95, 40);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "清空";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panelTools
            // 
            panelTools.Controls.Add(buttonPen);
            panelTools.Controls.Add(buttonEraser);
            panelTools.Controls.Add(buttonText);
            panelTools.Controls.Add(buttonBucket);
            panelTools.Dock = DockStyle.Fill;
            panelTools.Location = new Point(306, 25);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(99, 151);
            panelTools.TabIndex = 7;
            // 
            // buttonPen
            // 
            buttonPen.Location = new Point(3, 3);
            buttonPen.Name = "buttonPen";
            buttonPen.Size = new Size(95, 30);
            buttonPen.TabIndex = 0;
            buttonPen.Text = "笔刷";
            buttonPen.UseVisualStyleBackColor = true;
            buttonPen.Click += buttonPen_Click;
            // 
            // buttonEraser
            // 
            buttonEraser.Location = new Point(3, 39);
            buttonEraser.Name = "buttonEraser";
            buttonEraser.Size = new Size(95, 30);
            buttonEraser.TabIndex = 1;
            buttonEraser.Text = "擦除";
            buttonEraser.UseVisualStyleBackColor = true;
            buttonEraser.Click += buttonEraser_Click;
            // 
            // buttonText
            // 
            buttonText.Location = new Point(3, 75);
            buttonText.Name = "buttonText";
            buttonText.Size = new Size(95, 30);
            buttonText.TabIndex = 2;
            buttonText.Text = "文本";
            buttonText.UseVisualStyleBackColor = true;
            buttonText.Click += buttonText_Click;
            // 
            // buttonBucket
            // 
            buttonBucket.Location = new Point(3, 111);
            buttonBucket.Name = "buttonBucket";
            buttonBucket.Size = new Size(95, 30);
            buttonBucket.TabIndex = 3;
            buttonBucket.Text = "填充";
            buttonBucket.UseVisualStyleBackColor = true;
            buttonBucket.Click += buttonBucket_Click;
            // 
            // panelThickness
            // 
            panelThickness.Controls.Add(textBoxThickness);
            panelThickness.Controls.Add(trackBarOfThickness);
            panelThickness.Dock = DockStyle.Fill;
            panelThickness.FlowDirection = FlowDirection.TopDown;
            panelThickness.Location = new Point(412, 25);
            panelThickness.Name = "panelThickness";
            panelThickness.Size = new Size(94, 151);
            panelThickness.TabIndex = 9;
            // 
            // textBoxThickness
            // 
            textBoxThickness.Location = new Point(3, 3);
            textBoxThickness.Name = "textBoxThickness";
            textBoxThickness.Size = new Size(90, 28);
            textBoxThickness.TabIndex = 0;
            textBoxThickness.Text = "2";
            textBoxThickness.WordWrap = false;
            textBoxThickness.TextChanged += textBoxThickness_TextChanged;
            textBoxThickness.KeyPress += textBoxThickness_KeyPress;
            // 
            // trackBarOfThickness
            // 
            trackBarOfThickness.Anchor = AnchorStyles.Top;
            trackBarOfThickness.Location = new Point(20, 37);
            trackBarOfThickness.Minimum = 1;
            trackBarOfThickness.Name = "trackBarOfThickness";
            trackBarOfThickness.Orientation = Orientation.Vertical;
            trackBarOfThickness.Size = new Size(56, 110);
            trackBarOfThickness.TabIndex = 1;
            trackBarOfThickness.Value = 2;
            trackBarOfThickness.Scroll += trackBarOfThickness_Scroll;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonBlack);
            flowLayoutPanel1.Controls.Add(buttonWhite);
            flowLayoutPanel1.Controls.Add(buttonRed);
            flowLayoutPanel1.Controls.Add(buttonYellow);
            flowLayoutPanel1.Controls.Add(buttonBlue);
            flowLayoutPanel1.Controls.Add(buttonGreen);
            flowLayoutPanel1.Controls.Add(buttonPickColor);
            flowLayoutPanel1.Controls.Add(panelSelectedColor);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(513, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(74, 151);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // buttonBlack
            // 
            buttonBlack.BackColor = Color.Black;
            buttonBlack.Location = new Point(3, 3);
            buttonBlack.Name = "buttonBlack";
            buttonBlack.Size = new Size(30, 30);
            buttonBlack.TabIndex = 0;
            buttonBlack.UseVisualStyleBackColor = false;
            buttonBlack.Click += buttonBlack_Click;
            // 
            // buttonWhite
            // 
            buttonWhite.BackColor = Color.White;
            buttonWhite.Location = new Point(39, 3);
            buttonWhite.Name = "buttonWhite";
            buttonWhite.Size = new Size(30, 30);
            buttonWhite.TabIndex = 1;
            buttonWhite.UseVisualStyleBackColor = false;
            buttonWhite.Click += buttonWhite_Click;
            // 
            // buttonRed
            // 
            buttonRed.BackColor = Color.Red;
            buttonRed.Location = new Point(3, 39);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(30, 30);
            buttonRed.TabIndex = 2;
            buttonRed.UseVisualStyleBackColor = false;
            buttonRed.Click += buttonRed_Click;
            // 
            // buttonYellow
            // 
            buttonYellow.BackColor = Color.Yellow;
            buttonYellow.Location = new Point(39, 39);
            buttonYellow.Name = "buttonYellow";
            buttonYellow.Size = new Size(30, 30);
            buttonYellow.TabIndex = 3;
            buttonYellow.UseVisualStyleBackColor = false;
            buttonYellow.Click += buttonYellow_Click;
            // 
            // buttonBlue
            // 
            buttonBlue.BackColor = Color.DodgerBlue;
            buttonBlue.Location = new Point(3, 75);
            buttonBlue.Name = "buttonBlue";
            buttonBlue.Size = new Size(30, 30);
            buttonBlue.TabIndex = 4;
            buttonBlue.UseVisualStyleBackColor = false;
            buttonBlue.Click += buttonBlue_Click;
            // 
            // buttonGreen
            // 
            buttonGreen.BackColor = Color.SpringGreen;
            buttonGreen.Location = new Point(39, 75);
            buttonGreen.Name = "buttonGreen";
            buttonGreen.Size = new Size(30, 30);
            buttonGreen.TabIndex = 5;
            buttonGreen.UseVisualStyleBackColor = false;
            buttonGreen.Click += buttonGreen_Click;
            // 
            // buttonPickColor
            // 
            buttonPickColor.BackColor = SystemColors.Control;
            buttonPickColor.Font = new Font("更纱黑体 UI SC", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPickColor.Location = new Point(3, 111);
            buttonPickColor.Name = "buttonPickColor";
            buttonPickColor.Size = new Size(30, 30);
            buttonPickColor.TabIndex = 6;
            buttonPickColor.Text = "选色";
            buttonPickColor.UseVisualStyleBackColor = false;
            buttonPickColor.Click += buttonPickColor_Click;
            // 
            // panelSelectedColor
            // 
            panelSelectedColor.BackColor = Color.Black;
            panelSelectedColor.BorderStyle = BorderStyle.Fixed3D;
            panelSelectedColor.Location = new Point(39, 111);
            panelSelectedColor.Name = "panelSelectedColor";
            panelSelectedColor.Size = new Size(30, 30);
            panelSelectedColor.TabIndex = 7;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(pictureBoxLine);
            flowLayoutPanel5.Controls.Add(pictureBoxCircle);
            flowLayoutPanel5.Controls.Add(pictureBoxEllipse);
            flowLayoutPanel5.Controls.Add(pictureBoxTriangle);
            flowLayoutPanel5.Controls.Add(pictureBoxSquare);
            flowLayoutPanel5.Controls.Add(pictureBoxRectangle);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.Location = new Point(594, 25);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(205, 151);
            flowLayoutPanel5.TabIndex = 11;
            // 
            // pictureBoxLine
            // 
            pictureBoxLine.BackColor = Color.White;
            pictureBoxLine.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxLine.Image = (Image)resources.GetObject("pictureBoxLine.Image");
            pictureBoxLine.Location = new Point(8, 8);
            pictureBoxLine.Margin = new Padding(8);
            pictureBoxLine.Name = "pictureBoxLine";
            pictureBoxLine.Size = new Size(50, 50);
            pictureBoxLine.TabIndex = 0;
            pictureBoxLine.TabStop = false;
            pictureBoxLine.Click += pictureBoxLine_Click;
            // 
            // pictureBoxCircle
            // 
            pictureBoxCircle.BackColor = Color.White;
            pictureBoxCircle.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxCircle.Image = (Image)resources.GetObject("pictureBoxCircle.Image");
            pictureBoxCircle.Location = new Point(74, 8);
            pictureBoxCircle.Margin = new Padding(8);
            pictureBoxCircle.Name = "pictureBoxCircle";
            pictureBoxCircle.Size = new Size(50, 50);
            pictureBoxCircle.TabIndex = 1;
            pictureBoxCircle.TabStop = false;
            pictureBoxCircle.Click += pictureBoxCircle_Click;
            // 
            // pictureBoxEllipse
            // 
            pictureBoxEllipse.BackColor = Color.White;
            pictureBoxEllipse.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxEllipse.Image = (Image)resources.GetObject("pictureBoxEllipse.Image");
            pictureBoxEllipse.Location = new Point(140, 8);
            pictureBoxEllipse.Margin = new Padding(8);
            pictureBoxEllipse.Name = "pictureBoxEllipse";
            pictureBoxEllipse.Size = new Size(50, 50);
            pictureBoxEllipse.TabIndex = 2;
            pictureBoxEllipse.TabStop = false;
            pictureBoxEllipse.Click += pictureBoxEllipse_Click;
            // 
            // pictureBoxTriangle
            // 
            pictureBoxTriangle.BackColor = Color.White;
            pictureBoxTriangle.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxTriangle.Image = (Image)resources.GetObject("pictureBoxTriangle.Image");
            pictureBoxTriangle.Location = new Point(8, 74);
            pictureBoxTriangle.Margin = new Padding(8);
            pictureBoxTriangle.Name = "pictureBoxTriangle";
            pictureBoxTriangle.Size = new Size(50, 50);
            pictureBoxTriangle.TabIndex = 3;
            pictureBoxTriangle.TabStop = false;
            pictureBoxTriangle.Click += pictureBoxTriangle_Click;
            // 
            // pictureBoxSquare
            // 
            pictureBoxSquare.BackColor = Color.White;
            pictureBoxSquare.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxSquare.Image = (Image)resources.GetObject("pictureBoxSquare.Image");
            pictureBoxSquare.Location = new Point(74, 74);
            pictureBoxSquare.Margin = new Padding(8);
            pictureBoxSquare.Name = "pictureBoxSquare";
            pictureBoxSquare.Size = new Size(50, 50);
            pictureBoxSquare.TabIndex = 4;
            pictureBoxSquare.TabStop = false;
            pictureBoxSquare.Click += pictureBoxSquare_Click;
            // 
            // pictureBoxRectangle
            // 
            pictureBoxRectangle.BackColor = Color.White;
            pictureBoxRectangle.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxRectangle.Image = (Image)resources.GetObject("pictureBoxRectangle.Image");
            pictureBoxRectangle.Location = new Point(140, 74);
            pictureBoxRectangle.Margin = new Padding(8);
            pictureBoxRectangle.Name = "pictureBoxRectangle";
            pictureBoxRectangle.Size = new Size(50, 50);
            pictureBoxRectangle.TabIndex = 5;
            pictureBoxRectangle.TabStop = false;
            pictureBoxRectangle.Click += pictureBoxRectangle_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(OperateArea, 0, 0);
            tableLayoutPanel.Controls.Add(pictureBox, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.MinimumSize = new Size(800, 600);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(832, 703);
            tableLayoutPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 703);
            Controls.Add(tableLayoutPanel);
            DoubleBuffered = true;
            MinimumSize = new Size(850, 750);
            Name = "MainForm";
            Text = "画图：";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            OperateArea.ResumeLayout(false);
            OperateArea.PerformLayout();
            panelFile.ResumeLayout(false);
            panelImageOperate.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            panelTools.ResumeLayout(false);
            panelThickness.ResumeLayout(false);
            panelThickness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarOfThickness).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCircle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEllipse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTriangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSquare).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRectangle).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel OperateArea;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel panelFile;
        private Button buttonOpen;
        private Button buttonSave;
        private Button buttonSaveAs;
        private TableLayoutPanel panelImageOperate;
        private Button buttonHorizontal;
        private Button buttonVertical;
        private Button buttonAntiClock;
        private Button buttonClock;
        private TableLayoutPanel tableLayoutPanel;
        private FlowLayoutPanel panelTools;
        private Button buttonPen;
        private Button buttonEraser;
        private Button buttonText;
        private Button buttonBucket;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button buttonResize;
        private Button buttonDelete;
        private Button buttonNew;
        private Label label6;
        private FlowLayoutPanel panelThickness;
        private TextBox textBoxThickness;
        private TrackBar trackBarOfThickness;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonBlack;
        private Button buttonWhite;
        private Button buttonRed;
        private Button buttonYellow;
        private Button buttonBlue;
        private Button buttonGreen;
        private Button buttonPickColor;
        private Panel panelSelectedColor;
        private FlowLayoutPanel flowLayoutPanel5;
        private PictureBox pictureBoxLine;
        private PictureBox pictureBoxCircle;
        private PictureBox pictureBoxEllipse;
        private PictureBox pictureBoxTriangle;
        private PictureBox pictureBoxSquare;
        private PictureBox pictureBoxRectangle;
        private PictureBox pictureBox;
    }
}