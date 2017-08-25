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

namespace Zephyr
{
    public partial class Form1 : Form
    {
        public int endEpoch;
        public int curEpoch;
        public int sampling;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            endEpoch = 1000;
            curEpoch = 0;
            sampling = 10;

            portNo1.Text = serialPort1.PortName;
            portNo2.Text = serialPort2.PortName;
            portNo3.Text = serialPort3.PortName;
            portNo4.Text = serialPort4.PortName;
            portNo5.Text = serialPort5.PortName;
        }

        private void refreshText()
        {
            portNo1.Text = serialPort1.PortName;
            portNo2.Text = serialPort2.PortName;
            portNo3.Text = serialPort3.PortName;
            portNo4.Text = serialPort4.PortName;
            portNo5.Text = serialPort5.PortName;
        }

        private void portChange1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = portNo1.Text;
            refreshText();
        }

        private void portChange2_Click(object sender, EventArgs e)
        {
            serialPort2.PortName = portNo2.Text;
            refreshText();
        }

        private void portChange3_Click(object sender, EventArgs e)
        {
            serialPort3.PortName = portNo3.Text;
            refreshText();
        }

        private void portChange4_Click(object sender, EventArgs e)
        {
            serialPort4.PortName = portNo4.Text;
            refreshText();
        }

        private void portChange5_Click(object sender, EventArgs e)
        {
            serialPort5.PortName = portNo5.Text;
            refreshText();
        }

        private void activate1_CheckedChanged(object sender, EventArgs e)
        {
            if (activate1.Checked == true) {
                serialPort1.Open();
            }
            else {
                serialPort1.Close();
            }
        }

        private void activate2_CheckedChanged(object sender, EventArgs e)
        {
            if (activate2.Checked == true)
            {
                serialPort2.Open();
            }
            else
            {
                serialPort2.Close();
            }
        }

        private void activate3_CheckedChanged(object sender, EventArgs e)
        {
            if (activate3.Checked == true)
            {
                serialPort3.Open();
            }
            else
            {
                serialPort3.Close();
            }
        }

        private void activate4_CheckedChanged(object sender, EventArgs e)
        {
            if (activate4.Checked == true)
            {
                serialPort4.Open();
            }
            else
            {
                serialPort4.Close();
            }
        }

        private void activate5_CheckedChanged(object sender, EventArgs e)
        {
            if (activate5.Checked == true)
            {
                serialPort5.Open();
            }
            else
            {
                serialPort5.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived1));
        }
        private void SerialReceived1(object sender, EventArgs e)
        {
            //msg1.Text = serialPort1.ReadExisting();
            var msgLine1 = serialPort1.ReadExisting();
        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived2));
        }
        private void SerialReceived2(object sender, EventArgs e)
        {
            msg2.Text = serialPort2.ReadExisting();
        }

        private void serialPort3_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived3));
        }
        private void SerialReceived3(object sender, EventArgs e)
        {
            msg3.Text = serialPort3.ReadExisting();
        }

        private void serialPort4_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived4));
        }
        private void SerialReceived4(object sender, EventArgs e)
        {
            msg4.Text = serialPort4.ReadExisting();
        }

        private void serialPort5_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived5));
        }
        private void SerialReceived5(object sender, EventArgs e)
        {
            msg5.Text = serialPort5.ReadExisting();
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            endEpoch = int.Parse(epochText.Text);
            sampling = int.Parse(samplingText.Text);
        }
    }
}
