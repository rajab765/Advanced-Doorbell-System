using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualFeed
{
    public partial class WDevice : Form
    {
        public SerialPort port = new SerialPort(ArdunioConstants.ArduinoBoardPortName, ArdunioConstants.ArduinoBoardBaudRate);
        private VideoCaptureDevice videDevice;
        private FilterInfoCollection filterInfo;

        public WDevice()
        {
            InitializeComponent();
        }

        public void startVideo()
        {
            videDevice = new VideoCaptureDevice(filterInfo[0].MonikerString);
            videDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var img = (Bitmap)eventArgs.Frame.Clone();
            img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = img;

        }

        private void WDevice_Load(object sender, EventArgs e)
        {
            videDevice = new VideoCaptureDevice();
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            StartReading();
        }

        private void pictureBoxIpl1_Click(object sender, EventArgs e)
        {

        }

        private void WDevice_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopVideo();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartReading();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopVideo();

            if (port.IsOpen)
            {
                port.Close();
                labelStatus.Text = "Dsiplay is Off";
            }
        }

        public void StopVideo()
        {
            if (videDevice.IsRunning == true)
            {
                Bitmap bmp = new Bitmap(78, 78);
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    gr.Clear(Color.FromKnownColor(KnownColor.Window));
                }
                pictureBox1.Image = bmp;
                videDevice.Stop();
                pictureBox1.Image = null;
                videDevice = new VideoCaptureDevice();
            }
                
        }
        public void StartReading()
        {
            if(labelStatus.Text != "Display is ON")
            {
                labelStatus.Text = "Display is ON";
                var ts = new ThreadStart(BackgroundMethod);
                var backgroundThread = new Thread(ts);
                backgroundThread.Start();
            }                 
        }
        private void BackgroundMethod()
        {
            port.Open();
            while (true)
            {
                if (!port.IsOpen)
                    break;
                string a = port.ReadExisting();
                if (a == "LR")
                {
                    startVideo();
                    break;
                }
                if(a == "S")
                {
                    StopVideo();
                }
                Thread.Sleep(2000);
            }
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
