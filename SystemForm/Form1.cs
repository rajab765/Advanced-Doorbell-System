using System;
using System.IO.Ports;
using System.Windows.Forms;
using InTheHand.Net.Sockets;

namespace SystemForm
{
    public partial class Form1 : Form
    {
        public BluetoothClient client = new BluetoothClient();
        public string selectedItem { get; set; }
        public BluetoothDeviceInfo[] AllDevices;
        public SerialPort port = new SerialPort(ArdunioConstants.ArduinoBoardPortName, ArdunioConstants.ArduinoBoardBaudRate);
        private string codeText = string.Empty;
        private string newCode = string.Empty;
        public bool Resetting = false;
        public int WrongCounter = 0;
        public DateTime? KeypadLocked = null;
        public Form1()
        {

            InitializeComponent();

            codeBox.TextAlign = HorizontalAlignment.Center;
            codeBox.Text = codeText;
        }
        public void ArduinoCommand(string command)
        {
            port.Open();
            if (port.IsOpen)
            {
                port.Write(command);
            }
            port.Close();
        }
        public void GetDevices()
        {
            AllDevices = client.DiscoverDevices();
            foreach (BluetoothDeviceInfo Device in AllDevices)
            {
                if (Device.DeviceName.Contains(ArdunioConstants.BluetoothDevice))
                {

                }
                    //onSetDevices(Device.DeviceName); // event to get device name and add it to ComoBox element on form
            }
            //onSetProgress(); // event, that all devices were found, set progress bar and etc.
        }
        public void GoConnect()
        {
            foreach (BluetoothDeviceInfo Device in AllDevices)
            {
                if (Device.DeviceName.Equals(selectedItem)) // item from ComboBox
                {
                    if (!client.Connected)
                        client = new BluetoothClient();
                    client.BeginConnect(Device.DeviceAddress, Device.InstalledServices[0], this.BluetoothClientConnectCallback, client);
                    break;
                }
                else
                {
                    MessageBox.Show("Choose the device");
                }
            }
        }
        private void BluetoothClientConnectCallback(IAsyncResult ar)
        {
            //Have no problem with this
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //BluetoothClient client = new BluetoothClient();
            //List<string> items = new List<string>();
            //BluetoothDeviceInfo[] devices = client.DiscoverDevicesInRange();
            //foreach (BluetoothDeviceInfo d in devices)
            //{
            //    items.Add(d.DeviceName);
            //}
            GetDevices();

        }

        private void buttonNo1_Click(object sender, EventArgs e)
        {
            codeText += "1";
            codeBox.Text = codeText;
        }

        private void buttonNo2_Click(object sender, EventArgs e)
        {
            codeText += "2";
            codeBox.Text = codeText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNo3_Click(object sender, EventArgs e)
        {
            codeText += "3";
            codeBox.Text = codeText;
        }

        private void buttonNo4_Click(object sender, EventArgs e)
        {
            codeText += "4";
            codeBox.Text = codeText;
        }

        private void buttonNo5_Click(object sender, EventArgs e)
        {
            codeText += "5";
            codeBox.Text = codeText;
        }

        private void buttonNo6_Click(object sender, EventArgs e)
        {
            codeText += "7";
            codeBox.Text = codeText;
        }

        private void buttonNo7_Click(object sender, EventArgs e)
        {
            codeText += "7";
            codeBox.Text = codeText;
        }

        private void buttonNo8_Click(object sender, EventArgs e)
        {
            codeText += "8";
            codeBox.Text = codeText;
        }

        private void buttonNo9_Click(object sender, EventArgs e)
        {
            codeText += "9";
            codeBox.Text = codeText;
        }

        private void buttonNo0_Click(object sender, EventArgs e)
        {
            codeText += "0";
            codeBox.Text = codeText;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(WrongCounter == 4)
            {
                TimeSpan timeDifference = DateTime.UtcNow - KeypadLocked.Value;
                if(timeDifference.TotalMinutes < 3)
                {
                    MessageBox.Show("Keypad Locked");
                    return;
                }
            }
            WrongCounter = 0;
            KeypadLocked = null;
            if (Resetting && !string.IsNullOrEmpty(newCode))
            {
                if(newCode == codeText)
                {
                    codeText = "";
                    codeBox.Text = "";
                    MessageBox.Show("New Code Set");
                    codeBox.Text = codeText;
                    ArdunioConstants.Passcode = newCode;
                    newCode = "";
                    Resetting = false;
                }
                else
                {
                    codeText = "";
                    codeBox.Text = "";
                    MessageBox.Show("No matched Re-type");
                    codeBox.Text = codeText;
                }                
            }
            else if (Resetting && string.IsNullOrEmpty(newCode)) 
            {
                newCode = codeText;
                codeText = "";
                MessageBox.Show("Re-Type New Code");
                codeBox.Text = "";
                codeBox.Text = codeText;
            }
            else if(codeText == ArdunioConstants.DefaultPasscode)
            {
                codeText = "";
                codeBox.Text = "";
                MessageBox.Show("Type New Code");
                codeBox.Text = codeText;
                Resetting = true;
            }
            else if (codeText == ArdunioConstants.Passcode && !Resetting)
            {
                MessageBox.Show("Door Opened");
                codeText = "";
                codeBox.Text = codeText;
                ArduinoCommand(ArdunioCommands.DoorUnlock);
            }
            else
            {
                MessageBox.Show("Wrong Code");
                codeText = "";
                codeBox.Text = codeText;
                if (!Resetting)
                {
                    WrongCounter++;
                    if(WrongCounter == 4)
                    {
                        KeypadLocked = DateTime.UtcNow;
                        buttonBell.Click += new EventHandler(buttonBell_Click);
                    }
                }
            }
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if(codeText.Length > 0)
            {
                codeText = codeText.Remove(codeText.Length - 1);
            }
            codeBox.Text = codeText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBell_Click(object sender, EventArgs e)
        {
            ArduinoCommand(ArdunioCommands.LedOn);
            // Arduni call Light and vibrator
        }
    }
}
