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
        private int Limit;
        private int Overflow;
        private bool IsStoped;
        private WaveIn Recorder;
        private DateTime FirstTime;
        private double LastSecond;
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
            IsStoped = true;
            PrepereRecoder();
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
            if (Convert.ToInt32(durationValue.Value) > (DateTime.Now - FirstTime).Minutes
                || Convert.ToInt32(durationValue.Value) == 0)
            {
                double sum = 0;
                for (var i = 0; i < args.Buffer.Length; i = i + 2)
                {
                    double sample = BitConverter.ToInt16(args.Buffer, i) / 32768.0;
                    sum += (sample * sample);
                }
                double rms = Math.Sqrt(sum / (args.Buffer.Length / 2));
                double decibels = 20 * Math.Log10(rms);
                decibels += Convert.ToDouble(Calibation.Value) + (decibels * 0.2);
                decibels = decibels > 120 ? 120 : decibels;
                decibels = decibels < 0 ? 0 : decibels;

                Max = Max == 0 ? decibels : Max;
                Min = Max == 0 ? decibels : Min;
                
                Min = decibels < Min ? decibels : Min;
                Max = decibels > Max ? decibels : Max;

                UpdateView(decibels);
            }
            else
                PrepereRecoder();
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

            var time = Math.Round((DateTime.Now - FirstTime).TotalSeconds);

            if(time % 30 == 0)
                foreach (var series in ChartVolume.Series)
                    series.Points.Clear();

            if (time > LastSecond)
            {
                ChartVolume.Series["Noisy"].Points.AddXY(time, decibels);
                ChartVolume.Series["Limit"].Points.AddXY(time, Limit);
                LastSecond = time;
            }
        }

        private void PrepereRecoder()
        {
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            Overflow = 0;
            IsStoped = true;
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

            ChartVolume.Series["Noisy"].Points.AddXY(0, 10);
            ChartVolume.Series["Limit"].Points.AddXY(0, 50);

            ChartVolume.Series["Noisy"].Points.AddXY(3, 45);
            ChartVolume.Series["Limit"].Points.AddXY(3, 50);

            ChartVolume.Series["Noisy"].Points.AddXY(6, 25);
            ChartVolume.Series["Limit"].Points.AddXY(6, 50);

            ChartVolume.Series["Noisy"].Points.AddXY(12, 67);
            ChartVolume.Series["Limit"].Points.AddXY(12, 50);

            if (!IsStoped)
            {
                if(Convert.ToInt32(durationValue.Value) != 0)
                    MessageBox.Show("The limit was extrapolated " + Overflow + " times", "Status",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Recorder.StopRecording();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            FirstTime = DateTime.Now;
            LastSecond = -1;
            IsStoped = false;
            Limit = Convert.ToInt32(limitValue.Value);
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            foreach (var series in ChartVolume.Series)
                series.Points.Clear();
            StartRecording();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            PrepereRecoder();
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
