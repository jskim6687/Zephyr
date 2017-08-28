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
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;


namespace Zephyr
{
    public partial class Form1 : Form
    {
        calculate cal = new calculate();

        public int endEpoch;
        public int curEpoch;
        public int sampling;
        public int recordFlag = 0;

        ArrayList com1array = new ArrayList();
        ArrayList com2array = new ArrayList();
        ArrayList com3array = new ArrayList();
        ArrayList com4array = new ArrayList();
        ArrayList com5array = new ArrayList();

        double[] altitude = new double[5];
        Series alt1;
        Series alt2;
        Series alt3;
        Series alt4;
        Series alt5;

        double[] rawPrs = new double[5];
        Series rawPrs1;
        Series rawPrs2;
        Series rawPrs3;
        Series rawPrs4;
        Series rawPrs5;

        double[] rawTmp = new double[5];
        Series rawTmp1;
        Series rawTmp2;
        Series rawTmp3;
        Series rawTmp4;
        Series rawTmp5;

        FileInfo file;

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

            //Chart for Test
            altChart.Series.Clear();
            alt1 = altChart.Series.Add("alt1");
            alt1.ChartType = SeriesChartType.Line;
            alt2 = altChart.Series.Add("alt2");
            alt2.ChartType = SeriesChartType.Line;
            alt3 = altChart.Series.Add("alt3");
            alt3.ChartType = SeriesChartType.Line;
            alt4 = altChart.Series.Add("alt4");
            alt4.ChartType = SeriesChartType.Line;
            alt5 = altChart.Series.Add("alt5");
            alt5.ChartType = SeriesChartType.Line;

            rawPrsChart.Series.Clear();
            rawPrs1 = rawPrsChart.Series.Add("rawPrs1");
            rawPrs1.ChartType = SeriesChartType.Line;
            rawPrs2 = rawPrsChart.Series.Add("rawPrs2");
            rawPrs2.ChartType = SeriesChartType.Line;
            rawPrs3 = rawPrsChart.Series.Add("rawPrs3");
            rawPrs3.ChartType = SeriesChartType.Line;
            rawPrs4 = rawPrsChart.Series.Add("rawPrs4");
            rawPrs4.ChartType = SeriesChartType.Line;
            rawPrs5 = rawPrsChart.Series.Add("rawPrs5");
            rawPrs5.ChartType = SeriesChartType.Line;

            rawTmpChart.Series.Clear();
            rawTmp1 = rawTmpChart.Series.Add("rawTmp1");
            rawTmp1.ChartType = SeriesChartType.Line;
            rawTmp2 = rawTmpChart.Series.Add("rawTmp2");
            rawTmp2.ChartType = SeriesChartType.Line;
            rawTmp3 = rawTmpChart.Series.Add("rawTmp3");
            rawTmp3.ChartType = SeriesChartType.Line;
            rawTmp4 = rawTmpChart.Series.Add("rawTmp4");
            rawTmp4.ChartType = SeriesChartType.Line;
            rawTmp5 = rawTmpChart.Series.Add("rawTmp5");
            rawTmp5.ChartType = SeriesChartType.Line;
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
            var line = serialPort1.ReadLine();
            msg1.Text = line;
            if (line.Length >= 50)
            {
                var lineArray = cal.makeArray(line);
                com1array.Add(lineArray);
                var altitude1 = lineArray[6];
                altitude[0] = double.Parse(altitude1.ToString());
                var rawPressure1 = lineArray[4];
                rawPrs[0] = double.Parse(rawPressure1.ToString());
                var rawTemperature1 = lineArray[3];
                rawPrs[0] = double.Parse(rawTemperature1.ToString());
            }
        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived2));
        }
        private void SerialReceived2(object sender, EventArgs e)
        {
            var line = serialPort2.ReadLine();
            msg2.Text = line;
            if (line.Length >= 50)
            {
                var lineArray = cal.makeArray(line);
                com2array.Add(lineArray);
                var altitude2 = lineArray[6];
                altitude[1] = double.Parse(altitude2.ToString());
                var rawPressure2 = lineArray[4];
                rawPrs[1] = double.Parse(rawPressure2.ToString());
                var rawTemperature2 = lineArray[3];
                rawPrs[1] = double.Parse(rawTemperature2.ToString());
            }
        }

        private void serialPort3_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived3));
        }
        private void SerialReceived3(object sender, EventArgs e)
        {
            var line = serialPort3.ReadLine();
            msg3.Text = line;
            if (line.Length >= 50)
            {
                var lineArray = cal.makeArray(line);
                com3array.Add(lineArray);
                var altitude3 = lineArray[6];
                altitude[2] = double.Parse(altitude3.ToString());
                var rawPressure3 = lineArray[4];
                rawPrs[2] = double.Parse(rawPressure3.ToString());
                var rawTemperature3 = lineArray[3];
                rawPrs[2] = double.Parse(rawTemperature3.ToString());
            }
        }

        private void serialPort4_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived4));
        }
        private void SerialReceived4(object sender, EventArgs e)
        {
            var line = serialPort4.ReadLine();
            msg4.Text = line;
            if (line.Length >= 50)
            {
                var lineArray = cal.makeArray(line);
                com4array.Add(lineArray);
                var altitude4 = lineArray[6];
                altitude[3] = double.Parse(altitude4.ToString());
                var rawPressure4 = lineArray[4];
                rawPrs[3] = double.Parse(rawPressure4.ToString());
                var rawTemperature4 = lineArray[3];
                rawPrs[3] = double.Parse(rawTemperature4.ToString());
            }
        }

        private void serialPort5_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived5));
        }
        private void SerialReceived5(object sender, EventArgs e)
        {
            var line = serialPort5.ReadLine();
            msg5.Text = line;
            if (line.Length >= 50)
            {
                var lineArray = cal.makeArray(line);
                com5array.Add(lineArray);
                var altitude5 = lineArray[6];
                altitude[4] = double.Parse(altitude5.ToString());
                var rawPressure5 = lineArray[4];
                rawPrs[4] = double.Parse(rawPressure5.ToString());
                var rawTemperature5 = lineArray[3];
                rawPrs[4] = double.Parse(rawTemperature5.ToString());
            }
        }


        private void recordBtn_Click(object sender, EventArgs e)
        {
            recordFlag = 1;
            curEpoch = 0;
            endEpoch = int.Parse(epochText.Text);
            sampling = int.Parse(samplingText.Text);
            progress.Maximum = endEpoch;
            file = new FileInfo(directoryPath.Text);

            if (!file.Exists)
            {
                FileStream fs = file.Create();
                fs.Close();
            }
            epochTimer.Start();
        }

        private void epochTimer_Tick(object sender, EventArgs e)
        {
            if(recordFlag == 1 && curEpoch < endEpoch)
            {
                epochTimer.Start();

                var recordString = System.DateTime.Now.ToString("yyyyMMddHHmmss");

                if (activate1.Checked == true)
                {
                    alt1.Points.AddXY(curEpoch, altitude[0]);
                    recordString = recordString + ";" + altitude[0];
                    rawPrs1.Points.AddXY(curEpoch, rawPrs[0]);
                    recordString = recordString + ";" + rawPrs[0];
                    rawTmp1.Points.AddXY(curEpoch, rawTmp[0]);
                    recordString = recordString + ";" + rawTmp[0];
                }
                if (activate2.Checked == true)
                {
                    alt2.Points.AddXY(curEpoch, altitude[1]);
                    recordString = recordString + ";" + altitude[1];
                    rawPrs2.Points.AddXY(curEpoch, rawPrs[1]);
                    recordString = recordString + ";" + rawPrs[1];
                    rawTmp2.Points.AddXY(curEpoch, rawTmp[1]);
                    recordString = recordString + ";" + rawTmp[1];
                }
                if (activate3.Checked == true)
                {
                    alt3.Points.AddXY(curEpoch, altitude[2]);
                    recordString = recordString + ";" + altitude[2];
                    rawPrs3.Points.AddXY(curEpoch, rawPrs[2]);
                    recordString = recordString + ";" + rawPrs[2];
                    rawTmp3.Points.AddXY(curEpoch, rawTmp[2]);
                    recordString = recordString + ";" + rawTmp[2];
                }
                if (activate4.Checked == true)
                {
                    alt4.Points.AddXY(curEpoch, altitude[3]);
                    recordString = recordString + ";" + altitude[3];
                    rawPrs4.Points.AddXY(curEpoch, rawPrs[3]);
                    recordString = recordString + ";" + rawPrs[3];
                    rawTmp4.Points.AddXY(curEpoch, rawTmp[3]);
                    recordString = recordString + ";" + rawTmp[3];
                }
                if (activate5.Checked == true)
                {
                    alt5.Points.AddXY(curEpoch, altitude[4]);
                    recordString = recordString + ";" + altitude[4];
                    rawPrs5.Points.AddXY(curEpoch, rawPrs[4]);
                    recordString = recordString + ";" + rawPrs[4];
                    rawTmp5.Points.AddXY(curEpoch, rawTmp[4]);
                    recordString = recordString + ";" + rawTmp[4];
                }

                recordString = recordString + "\n";
                File.AppendAllText(directoryPath.Text,recordString);

                curEpoch = curEpoch + 1;
                progress.Value = curEpoch;
                curEpochText.Text = curEpoch.ToString();
                var percent = curEpoch * 100 / endEpoch;
                epochPercent.Text = percent.ToString();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            epochTimer.Stop();
            recordFlag = 0;
            com1array.Clear();
            com2array.Clear();
            com3array.Clear();
            com4array.Clear();
            com5array.Clear();
            curEpoch = 0;
            progress.Value = curEpoch;        }

        private void drctBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            directoryPath.Text = folderBrowserDialog1.SelectedPath + '\\' + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void directoryPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
