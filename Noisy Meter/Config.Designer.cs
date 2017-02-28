namespace Noisy_Meter
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.limitValue = new System.Windows.Forms.NumericUpDown();
            this.durationValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.limitValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "dB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Limit:";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(76, 137);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(111, 28);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // limitValue
            // 
            this.limitValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.limitValue.Location = new System.Drawing.Point(76, 74);
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
            this.limitValue.Size = new System.Drawing.Size(120, 20);
            this.limitValue.TabIndex = 7;
            this.limitValue.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.limitValue.ValueChanged += new System.EventHandler(this.limitValue_ValueChanged);
            // 
            // durationValue
            // 
            this.durationValue.Location = new System.Drawing.Point(102, 22);
            this.durationValue.Name = "durationValue";
            this.durationValue.Size = new System.Drawing.Size(120, 20);
            this.durationValue.TabIndex = 8;
            this.durationValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(257, 191);
            this.Controls.Add(this.durationValue);
            this.Controls.Add(this.limitValue);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.Text = "Nosy Meter - Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.limitValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.NumericUpDown limitValue;
        private System.Windows.Forms.NumericUpDown durationValue;
    }
}