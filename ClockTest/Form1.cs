using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ClockTest
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);

        private SerialPort port;
        private Thread readThread;
        private BackgroundWorker workThread;

        private clock1 player1 = new clock1();
        private clock1 player2 = new clock1();
        private scenario scenario1 = new scenario();
        private scenario scenario2 = new scenario();

        public Form1()
        {
            InitializeComponent();

            workThread = new BackgroundWorker();
            windowSetup();
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            IContainer components = new Container();
            port = new SerialPort(components);
            port.PortName = portName.SelectedItem.ToString();
            port.BaudRate = 9600;
            port.DtrEnable = true;
            port.ReadTimeout = 5000;
            port.WriteTimeout = 500;

            try
            {
                port.Open();
            }
            catch (Exception startEx)
            {
                MessageBox.Show(startEx.Message, "Error");
            }

            readThread = new Thread(new ThreadStart(this.Read));
            readThread.Start();
            this.workThread.RunWorkerAsync();

            portName.Enabled = false;

            player1.Show();
            player2.Show();
            scenario1.Show();
            scenario2.Show();

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                player1.Hide();
                player2.Hide();
                scenario1.Hide();
                scenario2.Hide();
                port.Close();
                portName.Enabled = true;
            }
            catch (Exception stopEx)
            {
                MessageBox.Show(stopEx.Message, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                portName.Items.Add(s);
            }
        }

        private void SetText(string text)
        {
            if (this.outputBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.outputBox.AppendText(text + "\n");

                string[] values = text.Split(' ');

                player1.readTime(values[1]);
                scenario1.readPoints(values[2]);
                player2.readTime(values[4]);
                scenario2.readPoints(values[5]);
            }
        }

        public void Read()
        {
            while (port.IsOpen)
            {
                try
                {
                    string message = port.ReadLine();
                    this.SetText(message);
                }
                catch (Exception readEx)
                {
                    MessageBox.Show(readEx.Message, "Error");
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (readThread != null && readThread.ThreadState == ThreadState.Running)
                {
                    player1.Close();
                    player2.Close();
                    scenario1.Close();
                    scenario2.Close();
                    readThread.Abort();
                }
                if (port != null && port.IsOpen)
                    port.Close();
            }
            catch (Exception closeEx)
            {
                MessageBox.Show(closeEx.Message, "Error");
            }

        }

        private void windowSetup()
        {
            Point main = DesktopLocation;
            Point p1 = new Point();
            Point p2 = new Point();

            player1.Text = "Clock1";
            player2.Text = "Clock2";
            scenario1.Text = "Scenario1";
            scenario2.Text = "Scenario2";

            p1.X = main.X + 400;
            p1.Y = main.Y;
            player1.DesktopLocation = p1;
            p1.X = p1.X + 365;
            scenario1.DesktopLocation = p1;

            p2.X = main.X + 400;
            p2.Y = main.Y + 160;
            player2.DesktopLocation = p2;
            p2.X = p2.X + 365;
            scenario2.DesktopLocation = p2;



        }

        private void p1NameBtn_Click(object sender, EventArgs e)
        {
            if (player1Name.Text.Length > 8)
            {
                MessageBox.Show("Player 1 name is too long", "Warning");
                return;
            }
            string output = "#" + player1Name.Text.Replace(" ", "") + "#";
            port.Write(output);
        }

        private void p2NameBtn_Click(object sender, EventArgs e)
        {
            if (player2Name.Text.Length > 8)
            {
                MessageBox.Show("Player 2 name is too long", "Warning");
                return;
            }
            string output = "$" + player2Name.Text.Replace(" ", "") + "$";
            port.Write(output);
        }

        private void playerTimeBtn_Click(object sender, EventArgs e)
        {
            int time;
            if (!int.TryParse(playerTime.Text, out time))
            {
                MessageBox.Show("Player Time is not a number", "Warning");
                return;
            }
            string output = time.ToString();
            output = "%" + output + "%";
            port.Write(output);
        }

    }
}
