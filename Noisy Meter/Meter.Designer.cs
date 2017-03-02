namespace Noisy_Meter
{
    partial class Meter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meter));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Calibation = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.durationValue = new System.Windows.Forms.NumericUpDown();
            this.stopBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.limitValue = new System.Windows.Forms.NumericUpDown();
            this.startBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dbLevel = new CircularProgressBar.CircularProgressBar();
            this.dbComparative = new System.Windows.Forms.Label();
            this.ChartVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dbMax = new CircularProgressBar.CircularProgressBar();
            this.dbMin = new CircularProgressBar.CircularProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calibation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitValue)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 73);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::Noisy_Meter.Properties.Resources.microphone;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(17, 15);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(45, 45);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::Noisy_Meter.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(849, 15);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(45, 45);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Noisy Meter";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.Calibation);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.durationValue);
            this.panel2.Controls.Add(this.stopBtn);
            this.panel2.Controls.Add(this.limitValue);
            this.panel2.Controls.Add(this.startBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 529);
            this.panel2.TabIndex = 19;
            // 
            // Calibation
            // 
            this.Calibation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Calibation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Calibation.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calibation.ForeColor = System.Drawing.Color.White;
            this.Calibation.Location = new System.Drawing.Point(33, 222);
            this.Calibation.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Calibation.Name = "Calibation";
            this.Calibation.Size = new System.Drawing.Size(200, 20);
            this.Calibation.TabIndex = 27;
            this.Calibation.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(27, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Calibration:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(47, 516);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(199, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developed by Anderson Laurentino";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // durationValue
            // 
            this.durationValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.durationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durationValue.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationValue.ForeColor = System.Drawing.Color.White;
            this.durationValue.Location = new System.Drawing.Point(34, 72);
            this.durationValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.durationValue.Name = "durationValue";
            this.durationValue.Size = new System.Drawing.Size(200, 20);
            this.durationValue.TabIndex = 23;
            this.durationValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stopBtn
            // 
            this.stopBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stopBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.stopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopBtn.BorderRadius = 0;
            this.stopBtn.ButtonText = "Stop";
            this.stopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBtn.DisabledColor = System.Drawing.Color.Gray;
            this.stopBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.stopBtn.Iconimage = null;
            this.stopBtn.Iconimage_right = null;
            this.stopBtn.Iconimage_right_Selected = null;
            this.stopBtn.Iconimage_Selected = null;
            this.stopBtn.IconMarginLeft = 0;
            this.stopBtn.IconMarginRight = 0;
            this.stopBtn.IconRightVisible = true;
            this.stopBtn.IconRightZoom = 0D;
            this.stopBtn.IconVisible = true;
            this.stopBtn.IconZoom = 90D;
            this.stopBtn.IsTab = false;
            this.stopBtn.Location = new System.Drawing.Point(152, 275);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Normalcolor = System.Drawing.Color.OrangeRed;
            this.stopBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.stopBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.stopBtn.selected = false;
            this.stopBtn.Size = new System.Drawing.Size(121, 48);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stopBtn.Textcolor = System.Drawing.Color.White;
            this.stopBtn.TextFont = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // limitValue
            // 
            this.limitValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.limitValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.limitValue.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limitValue.ForeColor = System.Drawing.Color.White;
            this.limitValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.limitValue.Location = new System.Drawing.Point(34, 147);
            this.limitValue.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.limitValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.limitValue.Name = "limitValue";
            this.limitValue.Size = new System.Drawing.Size(200, 20);
            this.limitValue.TabIndex = 22;
            this.limitValue.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // startBtn
            // 
            this.startBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBtn.BorderRadius = 0;
            this.startBtn.ButtonText = "Start";
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.DisabledColor = System.Drawing.Color.Gray;
            this.startBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.startBtn.Iconimage = null;
            this.startBtn.Iconimage_right = null;
            this.startBtn.Iconimage_right_Selected = null;
            this.startBtn.Iconimage_Selected = null;
            this.startBtn.IconMarginLeft = 0;
            this.startBtn.IconMarginRight = 0;
            this.startBtn.IconRightVisible = true;
            this.startBtn.IconRightZoom = 0D;
            this.startBtn.IconVisible = true;
            this.startBtn.IconZoom = 90D;
            this.startBtn.IsTab = false;
            this.startBtn.Location = new System.Drawing.Point(14, 275);
            this.startBtn.Name = "startBtn";
            this.startBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.startBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.startBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.startBtn.selected = false;
            this.startBtn.Size = new System.Drawing.Size(121, 48);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startBtn.Textcolor = System.Drawing.Color.White;
            this.startBtn.TextFont = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "dB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Limit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(240, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "min";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label9);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.dbLevel);
            this.bunifuGradientPanel1.Controls.Add(this.dbComparative);
            this.bunifuGradientPanel1.Controls.Add(this.ChartVolume);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.dbMax);
            this.bunifuGradientPanel1.Controls.Add(this.dbMin);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(288, 67);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(614, 519);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(458, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "(sec)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(55, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "(dBs)";
            // 
            // dbLevel
            // 
            this.dbLevel.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("dbLevel.AnimationFunction")));
            this.dbLevel.AnimationSpeed = 500;
            this.dbLevel.BackColor = System.Drawing.Color.Transparent;
            this.dbLevel.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLevel.ForeColor = System.Drawing.Color.White;
            this.dbLevel.InnerColor = System.Drawing.Color.Transparent;
            this.dbLevel.InnerMargin = 2;
            this.dbLevel.InnerWidth = -1;
            this.dbLevel.Location = new System.Drawing.Point(189, 9);
            this.dbLevel.MarqueeAnimationSpeed = 2000;
            this.dbLevel.Maximum = 120;
            this.dbLevel.Name = "dbLevel";
            this.dbLevel.OuterColor = System.Drawing.Color.White;
            this.dbLevel.OuterMargin = -25;
            this.dbLevel.OuterWidth = 15;
            this.dbLevel.ProgressColor = System.Drawing.Color.Gold;
            this.dbLevel.ProgressWidth = 20;
            this.dbLevel.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.dbLevel.Size = new System.Drawing.Size(200, 200);
            this.dbLevel.StartAngle = 270;
            this.dbLevel.SubscriptColor = System.Drawing.Color.White;
            this.dbLevel.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.dbLevel.SubscriptText = "";
            this.dbLevel.SuperscriptColor = System.Drawing.Color.White;
            this.dbLevel.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.dbLevel.SuperscriptText = "";
            this.dbLevel.TabIndex = 12;
            this.dbLevel.Text = "35dB";
            this.dbLevel.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.dbLevel.Value = 35;
            // 
            // dbComparative
            // 
            this.dbComparative.AutoSize = true;
            this.dbComparative.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbComparative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dbComparative.Location = new System.Drawing.Point(194, 265);
            this.dbComparative.Name = "dbComparative";
            this.dbComparative.Size = new System.Drawing.Size(216, 19);
            this.dbComparative.TabIndex = 17;
            this.dbComparative.Text = "Almost quiet, Breathing";
            // 
            // ChartVolume
            // 
            this.ChartVolume.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Consolas", 10F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Consolas", 10F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineWidth = 2;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.CursorX.Interval = 15D;
            chartArea1.Name = "FirstGraph";
            chartArea1.ShadowColor = System.Drawing.Color.Wheat;
            this.ChartVolume.ChartAreas.Add(chartArea1);
            this.ChartVolume.ImeMode = System.Windows.Forms.ImeMode.On;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.ChartVolume.Legends.Add(legend1);
            this.ChartVolume.Location = new System.Drawing.Point(-15, 301);
            this.ChartVolume.MaximumSize = new System.Drawing.Size(999, 999);
            this.ChartVolume.Name = "ChartVolume";
            this.ChartVolume.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartVolume.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Teal,
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime};
            series1.BorderWidth = 3;
            series1.ChartArea = "FirstGraph";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Noisy";
            series2.BorderWidth = 2;
            series2.ChartArea = "FirstGraph";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Limit";
            this.ChartVolume.Series.Add(series1);
            this.ChartVolume.Series.Add(series2);
            this.ChartVolume.Size = new System.Drawing.Size(654, 212);
            this.ChartVolume.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(462, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Max";
            // 
            // dbMax
            // 
            this.dbMax.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("dbMax.AnimationFunction")));
            this.dbMax.AnimationSpeed = 500;
            this.dbMax.BackColor = System.Drawing.Color.Transparent;
            this.dbMax.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbMax.ForeColor = System.Drawing.Color.White;
            this.dbMax.InnerColor = System.Drawing.Color.Transparent;
            this.dbMax.InnerMargin = 2;
            this.dbMax.InnerWidth = -1;
            this.dbMax.Location = new System.Drawing.Point(411, 108);
            this.dbMax.MarqueeAnimationSpeed = 2000;
            this.dbMax.Maximum = 120;
            this.dbMax.Name = "dbMax";
            this.dbMax.OuterColor = System.Drawing.Color.White;
            this.dbMax.OuterMargin = -25;
            this.dbMax.OuterWidth = 24;
            this.dbMax.ProgressColor = System.Drawing.Color.OrangeRed;
            this.dbMax.ProgressWidth = 5;
            this.dbMax.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dbMax.Size = new System.Drawing.Size(135, 135);
            this.dbMax.StartAngle = 270;
            this.dbMax.SubscriptColor = System.Drawing.Color.White;
            this.dbMax.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.dbMax.SubscriptText = "";
            this.dbMax.SuperscriptColor = System.Drawing.Color.White;
            this.dbMax.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.dbMax.SuperscriptText = "";
            this.dbMax.TabIndex = 15;
            this.dbMax.Text = "35dB";
            this.dbMax.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.dbMax.Value = 35;
            // 
            // dbMin
            // 
            this.dbMin.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("dbMin.AnimationFunction")));
            this.dbMin.AnimationSpeed = 500;
            this.dbMin.BackColor = System.Drawing.Color.Transparent;
            this.dbMin.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbMin.ForeColor = System.Drawing.Color.White;
            this.dbMin.InnerColor = System.Drawing.Color.Transparent;
            this.dbMin.InnerMargin = 2;
            this.dbMin.InnerWidth = -1;
            this.dbMin.Location = new System.Drawing.Point(33, 108);
            this.dbMin.MarqueeAnimationSpeed = 2000;
            this.dbMin.Maximum = 120;
            this.dbMin.Name = "dbMin";
            this.dbMin.OuterColor = System.Drawing.Color.White;
            this.dbMin.OuterMargin = -25;
            this.dbMin.OuterWidth = 24;
            this.dbMin.ProgressColor = System.Drawing.Color.LawnGreen;
            this.dbMin.ProgressWidth = 5;
            this.dbMin.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dbMin.Size = new System.Drawing.Size(135, 135);
            this.dbMin.StartAngle = 270;
            this.dbMin.SubscriptColor = System.Drawing.Color.White;
            this.dbMin.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.dbMin.SubscriptText = "";
            this.dbMin.SuperscriptColor = System.Drawing.Color.White;
            this.dbMin.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.dbMin.SuperscriptText = "";
            this.dbMin.TabIndex = 13;
            this.dbMin.Text = "35dB";
            this.dbMin.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.dbMin.Value = 35;
            // 
            // Meter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(903, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Meter";
            this.Text = "Noisy Meter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calibation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitValue)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar dbLevel;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar dbMax;
        private CircularProgressBar.CircularProgressBar dbMin;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVolume;
        private System.Windows.Forms.Label dbComparative;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton stopBtn;
        private Bunifu.Framework.UI.BunifuFlatButton startBtn;
        private System.Windows.Forms.NumericUpDown durationValue;
        private System.Windows.Forms.NumericUpDown limitValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Calibation;
        private System.Windows.Forms.Label label11;
    }
}