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

namespace WearableUI
{
    public partial class Form1 : Form
    {
        public SerialPort port = new SerialPort(ArdunioConstants.ArduinoBoardPortName, ArdunioConstants.ArduinoBoardBaudRate);

        public bool IsShaking = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void shakeButton_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write(ArdunioCommands.DoorUnlock);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartReading();
        }
        public void StartReading()
        {          
            var ts = new ThreadStart(BackgroundMethod);
            var backgroundThread = new Thread(ts);
            backgroundThread.Start();          
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
                    btnVibrate.BackColor = Color.Green;
                    Thread.Sleep(2000);
                    btnVibrate.BackColor = Color.Red;
                }
                Thread.Sleep(2000);
            }
        }

        private void labelVibrate_Click(object sender, EventArgs e)
        {

        }
    }
}
