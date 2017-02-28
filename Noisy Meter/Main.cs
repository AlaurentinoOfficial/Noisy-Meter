using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Noisy_Meter
{
    public partial class Main : Form
    {
        public int Duration { get; set; }
        public int Limit { get; set; }
        public int Overflow { get; set; }
        public bool IsStoped { get; set; }
        private WaveIn Recorder;
        private DateTime firstTime;
        private int lastSecond;
        private double min;
        private double max;
        private string[] soundComparative;
        private double beforeDb;

        public Main()
        {
            InitializeComponent();
            firstTime = DateTime.Now;
            IsStoped = false;
            soundComparative = new string[] {
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
            StartRecording();
        }

        public void StartRecording()
        {
            Recorder = new WaveIn();
            Recorder.DeviceNumber = 0;
            Recorder.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(0).Channels);
            Recorder.DataAvailable += RecorderOnDataAvailable;
            Recorder.StartRecording();
        }

        public void StopRecording()
        {
            Recorder.StopRecording();
        }

        private void RecorderOnDataAvailable(object sender, WaveInEventArgs args)
        {
            if (Duration > (DateTime.Now - firstTime).Minutes || Duration == 0)
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

                if (max == 0)
                {
                    max = decibels;
                    min = decibels;
                }

                if (decibels < min)
                    min = decibels;

                if (decibels > max)
                    max = decibels;

                UpdateView(decibels);
            }
            else
                this.Close();
        }

        private void UpdateView(double decibels)
        {
            if (decibels > Limit)
            {
                dbLevelLabel.ForeColor = Color.DarkRed;
                if(beforeDb < Limit)
                    ++Overflow;
            }
            else
                dbLevelLabel.ForeColor = Color.Black;
            beforeDb = decibels;

            int c = 0;
            if (decibels >= 100)
                c = int.Parse(
                    Convert.ToString(Convert.ToString(Math.Round(decibels)).ToCharArray()[0]) +
                    Convert.ToString(Convert.ToString(Math.Round(decibels)).ToCharArray()[1]));
            else
                c = int.Parse(Convert.ToString(Convert.ToString(Math.Round(decibels)).ToCharArray()[0]));
            c = c <= 0 ? 1 : c;

            dbLevelLabel.Text = Convert.ToString((int)Math.Round(decibels)) + " dB";
            dbLevelMax.Text = Convert.ToString((int)Math.Round(max)) + " dB";
            dbLevelMin.Text = Convert.ToString((int)Math.Round(min)) + " dB";
            dbProgressBar.Value = (int)Math.Round(decibels);
            dbComparative.Text = (c * 10) + "dB - " + soundComparative[c-1];


            var time = (DateTime.Now - firstTime).Seconds;

            if (time > lastSecond)
            {
                ChartVolume.Series["Decibels"].Points.AddXY(time, decibels);
                ChartVolume.Series["Limit"].Points.AddXY(time, Limit);
                lastSecond = time;
            }
        }
    }
}
