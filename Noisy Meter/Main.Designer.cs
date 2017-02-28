namespace Noisy_Meter
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dbLevelLabel = new System.Windows.Forms.Label();
            this.dbProgressBar = new System.Windows.Forms.ProgressBar();
            this.ChartVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dbLevelMin = new System.Windows.Forms.Label();
            this.dbLevelMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dbComparative = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // dbLevelLabel
            // 
            this.dbLevelLabel.AutoSize = true;
            this.dbLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.dbLevelLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dbLevelLabel.Location = new System.Drawing.Point(209, 11);
            this.dbLevelLabel.Name = "dbLevelLabel";
            this.dbLevelLabel.Size = new System.Drawing.Size(118, 54);
            this.dbLevelLabel.TabIndex = 0;
            this.dbLevelLabel.Text = "0 dB";
            // 
            // dbProgressBar
            // 
            this.dbProgressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dbProgressBar.BackColor = System.Drawing.Color.White;
            this.dbProgressBar.Enabled = false;
            this.dbProgressBar.Location = new System.Drawing.Point(0, 95);
            this.dbProgressBar.Maximum = 120;
            this.dbProgressBar.Name = "dbProgressBar";
            this.dbProgressBar.Size = new System.Drawing.Size(534, 19);
            this.dbProgressBar.Step = 0;
            this.dbProgressBar.TabIndex = 1;
            this.dbProgressBar.Value = 50;
            // 
            // ChartVolume
            // 
            this.ChartVolume.AllowDrop = true;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.White;
            this.ChartVolume.ChartAreas.Add(chartArea3);
            this.ChartVolume.Location = new System.Drawing.Point(-11, 120);
            this.ChartVolume.MaximumSize = new System.Drawing.Size(999, 999);
            this.ChartVolume.Name = "ChartVolume";
            this.ChartVolume.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.LabelForeColor = System.Drawing.Color.Transparent;
            series3.Name = "Times";
            this.ChartVolume.Series.Add(series3);
            this.ChartVolume.Size = new System.Drawing.Size(545, 162);
            this.ChartVolume.TabIndex = 2;
            this.ChartVolume.UseWaitCursor = true;
            // 
            // dbLevelMin
            // 
            this.dbLevelMin.AutoSize = true;
            this.dbLevelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dbLevelMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dbLevelMin.Location = new System.Drawing.Point(73, 34);
            this.dbLevelMin.Name = "dbLevelMin";
            this.dbLevelMin.Size = new System.Drawing.Size(69, 31);
            this.dbLevelMin.TabIndex = 3;
            this.dbLevelMin.Text = "0 dB";
            // 
            // dbLevelMax
            // 
            this.dbLevelMax.AutoSize = true;
            this.dbLevelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dbLevelMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dbLevelMax.Location = new System.Drawing.Point(391, 34);
            this.dbLevelMax.Name = "dbLevelMax";
            this.dbLevelMax.Size = new System.Drawing.Size(69, 31);
            this.dbLevelMax.TabIndex = 4;
            this.dbLevelMax.Text = "0 dB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(90, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(413, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max";
            // 
            // dbComparative
            // 
            this.dbComparative.AutoSize = true;
            this.dbComparative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dbComparative.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dbComparative.Location = new System.Drawing.Point(3, 283);
            this.dbComparative.Name = "dbComparative";
            this.dbComparative.Size = new System.Drawing.Size(154, 17);
            this.dbComparative.TabIndex = 7;
            this.dbComparative.Text = "Almost quiet, Breathing";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(529, 303);
            this.Controls.Add(this.dbComparative);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbLevelMax);
            this.Controls.Add(this.dbLevelMin);
            this.Controls.Add(this.ChartVolume);
            this.Controls.Add(this.dbProgressBar);
            this.Controls.Add(this.dbLevelLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Noisy Meter";
            ((System.ComponentModel.ISupportInitialize)(this.ChartVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dbLevelLabel;
        private System.Windows.Forms.ProgressBar dbProgressBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVolume;
        private System.Windows.Forms.Label dbLevelMin;
        private System.Windows.Forms.Label dbLevelMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dbComparative;
    }
}