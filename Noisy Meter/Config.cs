﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noisy_Meter
{
    public partial class Config : Form
    {
        int duration = 5 * 60;
        int limit = 60;

        public Config()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            duration = Convert.ToInt32(durationValue.Value);
            limit = Convert.ToInt32(limitValue.Value);

            Main main = new Main();
            main.Duration = duration;
            main.Limit = limit;
            main.Show();
            main.FormClosing += delegate {
                main.StopRecording();
                
                if(!main.IsStoped)
                {
                    MessageBox.Show("The limit was extrapolated " + main.Overflow + " times", "Status",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    main.IsStoped = true;
                }
            };
        }
    }
}