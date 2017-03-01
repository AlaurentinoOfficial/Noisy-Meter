using NAudio.Wave;
using System;
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
    public partial class Meter : Form
    {
        private int Duration;
        private int Limit;
        private int Overflow;
        private bool IsStoped;
        private WaveIn Recorder;
        private DateTime FirstTime;
        private int LastSecond;
        private double Min;
        private double Max;
        private string[] SoundComparative;
        private double BeforeDb;
        private int MoveX;
        private int MoveY;
        private bool ToogleMove;

        public Meter()
        {
            InitializeComponent();
            SoundComparative = new string[] {
                "Almost quiet, Breathing",
                "Rustling leaves, Ticking watch",
                "Whisper, Quiet rural area",
                "Quiet libary, Bird calls",
                "Quiet office, Moderate rainfall",
                "Normal conversation at 3 ft",
                "Busy traffic, Vacuum cleaner",
                "Loud music, Alarm clocks",
                "Diesel truck, Power mower",
                "Motorcycle, Blow dryer",
                "Concerts, Screaming child",
                "Threshold of pain, Thunder"
            };
            Overflow = 0;
            IsStoped = false;
            Min = 35;
            Max = 35;

            dbLevel.Text = "35 dB";
            dbLevel.Value = 35;
            dbMax.Text = "35 dB";
            dbMax.Value = 35;
            dbMin.Text = "35 dB";
            dbMin.Value = 35;
            dbComparative.Text = "30dB - " + SoundComparative[0];
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
        }

        public void StartRecording()
        {
            Recorder = new WaveIn();
            Recorder.DeviceNumber = 0;
            Recorder.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(0).Channels);
            Recorder.DataAvailable += RecorderOnDataAvailable;
            Recorder.StartRecording();
        }

        private void RecorderOnDataAvailable(object sender, WaveInEventArgs args)
        {
            if (Duration > (DateTime.Now - FirstTime).Minutes || Duration == 0)
            {
                double sum = 0;
                for (var i = 0; i < args.Buffer.Length; i = i + 2)
                {
                    double sample = BitConverter.ToInt16(args.Buffer, i) / 32768.0;
                    sum += (sample * sample);
                }
                double rms = Math.Sqrt(sum / (args.Buffer.Length / 2));
                double decibels = 20 * Math.Log10(rms) + 70;
                decibels = decibels > 120 ? 120 : decibels;
                decibels = decibels < 0 ? 0 : decibels;

                if (Max == 0)
                {
                    Max = decibels;
                    Min = decibels;
                }

                if (decibels < Min)
                    Min = decibels;

                if (decibels > Max)
                    Max = decibels;

                UpdateView(decibels);
            }
            else
                StopRecoder();
        }

        private void UpdateView(double decibels)
        {
            if (decibels > Limit && BeforeDb < Limit)
                    ++Overflow;
            BeforeDb = decibels;

            int c = 0;
            if (decibels >= 100)
                c = int.Parse(
                    Convert.ToString(Convert.ToString(Math.Round(decibels)).ToCharArray()[0]) +
                    Convert.ToString(Convert.ToString(Math.Round(decibels)).ToCharArray()[1]));
            else if (decibels <= 19)
                c = 1;
            else
                c = int.Parse(Convert.ToString(Convert.ToString(Math.Round(decibels)).ToCharArray()[0]));

            dbLevel.Text = Convert.ToString((int)Math.Round(decibels)) + " dB";
            dbLevel.Value = (int)Math.Round(decibels);
            dbMax.Text = Convert.ToString((int)Math.Round(Max)) + " dB";
            dbMax.Value = (int)Math.Round(Max);
            dbMin.Text = Convert.ToString((int)Math.Round(Min)) + " dB";
            dbMin.Value = (int)Math.Round(Min);
            dbComparative.Text = (c * 10) + "dB - " + SoundComparative[c - 1];


            var time = (DateTime.Now - FirstTime).Seconds;

            if (time > LastSecond)
            {
                ChartVolume.Series["Noisy"].Points.AddXY(time, decibels);
                ChartVolume.Series["Limit"].Points.AddXY(time, Limit);
                LastSecond = time;
            }
        }

        private void StopRecoder()
        {
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            Recorder.StopRecording();
            if (IsStoped)
            {
                MessageBox.Show("The limit was extrapolated " + Overflow + " times", "Status",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                IsStoped = true;

                Overflow = 0;
                IsStoped = false;
                Min = 35;
                Max = 35;

                dbLevel.Text = "35 dB";
                dbLevel.Value = 35;
                dbMax.Text = "35 dB";
                dbMax.Value = 35;
                dbMin.Text = "35 dB";
                dbMin.Value = 35;
                dbComparative.Text = "30dB - " + SoundComparative[0];

                foreach (var series in ChartVolume.Series)
                    series.Points.Clear();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            FirstTime = DateTime.Now;
            LastSecond = 0;
            IsStoped = true;
            Limit = Convert.ToInt32(limitValue.Value);
            Duration = Convert.ToInt32(durationValue.Value);
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            StartRecording();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            StopRecoder();
        }

        private void limitValue_ValueChanged(object sender, EventArgs e)
        {
            Limit = Convert.ToInt32(limitValue.Value);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ToogleMove)
                if(e.Button == MouseButtons.Left)
                    this.Location = new Point(Cursor.Position.X - MoveX, Cursor.Position.Y - MoveY);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            ToogleMove = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ToogleMove = true;
            MoveX = e.X;
            MoveY = e.Y;
        }
    }
}
