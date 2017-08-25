namespace Zephyr
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort5 = new System.IO.Ports.SerialPort(this.components);
            this.portNo1 = new System.Windows.Forms.TextBox();
            this.portNo2 = new System.Windows.Forms.TextBox();
            this.portNo3 = new System.Windows.Forms.TextBox();
            this.portNo4 = new System.Windows.Forms.TextBox();
            this.portNo5 = new System.Windows.Forms.TextBox();
            this.portChange1 = new System.Windows.Forms.Button();
            this.portChange2 = new System.Windows.Forms.Button();
            this.portChange3 = new System.Windows.Forms.Button();
            this.portChange4 = new System.Windows.Forms.Button();
            this.portChange5 = new System.Windows.Forms.Button();
            this.activate1 = new System.Windows.Forms.CheckBox();
            this.activate2 = new System.Windows.Forms.CheckBox();
            this.activate3 = new System.Windows.Forms.CheckBox();
            this.activate4 = new System.Windows.Forms.CheckBox();
            this.activate5 = new System.Windows.Forms.CheckBox();
            this.msg1 = new System.Windows.Forms.TextBox();
            this.msg2 = new System.Windows.Forms.TextBox();
            this.msg3 = new System.Windows.Forms.TextBox();
            this.msg4 = new System.Windows.Forms.TextBox();
            this.msg5 = new System.Windows.Forms.TextBox();
            this.portGroup = new System.Windows.Forms.GroupBox();
            this.portList = new System.Windows.Forms.ListBox();
            this.DataGroup = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.samplingText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epochText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msgList = new System.Windows.Forms.ListBox();
            this.recordBtn = new System.Windows.Forms.Button();
            this.portGroup.SuspendLayout();
            this.DataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // serialPort3
            // 
            this.serialPort3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort3_DataReceived);
            // 
            // serialPort4
            // 
            this.serialPort4.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort4_DataReceived);
            // 
            // serialPort5
            // 
            this.serialPort5.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort5_DataReceived);
            // 
            // portNo1
            // 
            this.portNo1.Location = new System.Drawing.Point(241, 23);
            this.portNo1.Name = "portNo1";
            this.portNo1.Size = new System.Drawing.Size(100, 21);
            this.portNo1.TabIndex = 0;
            // 
            // portNo2
            // 
            this.portNo2.Location = new System.Drawing.Point(241, 51);
            this.portNo2.Name = "portNo2";
            this.portNo2.Size = new System.Drawing.Size(100, 21);
            this.portNo2.TabIndex = 1;
            // 
            // portNo3
            // 
            this.portNo3.Location = new System.Drawing.Point(241, 79);
            this.portNo3.Name = "portNo3";
            this.portNo3.Size = new System.Drawing.Size(100, 21);
            this.portNo3.TabIndex = 2;
            // 
            // portNo4
            // 
            this.portNo4.Location = new System.Drawing.Point(241, 107);
            this.portNo4.Name = "portNo4";
            this.portNo4.Size = new System.Drawing.Size(100, 21);
            this.portNo4.TabIndex = 3;
            // 
            // portNo5
            // 
            this.portNo5.Location = new System.Drawing.Point(241, 135);
            this.portNo5.Name = "portNo5";
            this.portNo5.Size = new System.Drawing.Size(100, 21);
            this.portNo5.TabIndex = 4;
            // 
            // portChange1
            // 
            this.portChange1.Location = new System.Drawing.Point(357, 23);
            this.portChange1.Name = "portChange1";
            this.portChange1.Size = new System.Drawing.Size(75, 23);
            this.portChange1.TabIndex = 5;
            this.portChange1.Text = "포트 변경";
            this.portChange1.UseVisualStyleBackColor = true;
            this.portChange1.Click += new System.EventHandler(this.portChange1_Click);
            // 
            // portChange2
            // 
            this.portChange2.Location = new System.Drawing.Point(357, 52);
            this.portChange2.Name = "portChange2";
            this.portChange2.Size = new System.Drawing.Size(75, 23);
            this.portChange2.TabIndex = 6;
            this.portChange2.Text = "포트 변경";
            this.portChange2.UseVisualStyleBackColor = true;
            this.portChange2.Click += new System.EventHandler(this.portChange2_Click);
            // 
            // portChange3
            // 
            this.portChange3.Location = new System.Drawing.Point(357, 79);
            this.portChange3.Name = "portChange3";
            this.portChange3.Size = new System.Drawing.Size(75, 23);
            this.portChange3.TabIndex = 7;
            this.portChange3.Text = "포트 변경";
            this.portChange3.UseVisualStyleBackColor = true;
            this.portChange3.Click += new System.EventHandler(this.portChange3_Click);
            // 
            // portChange4
            // 
            this.portChange4.Location = new System.Drawing.Point(357, 107);
            this.portChange4.Name = "portChange4";
            this.portChange4.Size = new System.Drawing.Size(75, 23);
            this.portChange4.TabIndex = 8;
            this.portChange4.Text = "포트 변경";
            this.portChange4.UseVisualStyleBackColor = true;
            this.portChange4.Click += new System.EventHandler(this.portChange4_Click);
            // 
            // portChange5
            // 
            this.portChange5.Location = new System.Drawing.Point(357, 135);
            this.portChange5.Name = "portChange5";
            this.portChange5.Size = new System.Drawing.Size(75, 23);
            this.portChange5.TabIndex = 9;
            this.portChange5.Text = "포트 변경";
            this.portChange5.UseVisualStyleBackColor = true;
            this.portChange5.Click += new System.EventHandler(this.portChange5_Click);
            // 
            // activate1
            // 
            this.activate1.AutoSize = true;
            this.activate1.Location = new System.Drawing.Point(162, 25);
            this.activate1.Name = "activate1";
            this.activate1.Size = new System.Drawing.Size(73, 16);
            this.activate1.TabIndex = 10;
            this.activate1.Text = "activate1";
            this.activate1.UseVisualStyleBackColor = true;
            this.activate1.CheckedChanged += new System.EventHandler(this.activate1_CheckedChanged);
            // 
            // activate2
            // 
            this.activate2.AutoSize = true;
            this.activate2.Location = new System.Drawing.Point(162, 53);
            this.activate2.Name = "activate2";
            this.activate2.Size = new System.Drawing.Size(73, 16);
            this.activate2.TabIndex = 11;
            this.activate2.Text = "activate2";
            this.activate2.UseVisualStyleBackColor = true;
            this.activate2.CheckedChanged += new System.EventHandler(this.activate2_CheckedChanged);
            // 
            // activate3
            // 
            this.activate3.AutoSize = true;
            this.activate3.Location = new System.Drawing.Point(162, 81);
            this.activate3.Name = "activate3";
            this.activate3.Size = new System.Drawing.Size(73, 16);
            this.activate3.TabIndex = 12;
            this.activate3.Text = "activate3";
            this.activate3.UseVisualStyleBackColor = true;
            this.activate3.CheckedChanged += new System.EventHandler(this.activate3_CheckedChanged);
            // 
            // activate4
            // 
            this.activate4.AutoSize = true;
            this.activate4.Location = new System.Drawing.Point(162, 109);
            this.activate4.Name = "activate4";
            this.activate4.Size = new System.Drawing.Size(73, 16);
            this.activate4.TabIndex = 13;
            this.activate4.Text = "activate4";
            this.activate4.UseVisualStyleBackColor = true;
            this.activate4.CheckedChanged += new System.EventHandler(this.activate4_CheckedChanged);
            // 
            // activate5
            // 
            this.activate5.AutoSize = true;
            this.activate5.Location = new System.Drawing.Point(162, 137);
            this.activate5.Name = "activate5";
            this.activate5.Size = new System.Drawing.Size(73, 16);
            this.activate5.TabIndex = 14;
            this.activate5.Text = "activate5";
            this.activate5.UseVisualStyleBackColor = true;
            this.activate5.CheckedChanged += new System.EventHandler(this.activate5_CheckedChanged);
            // 
            // msg1
            // 
            this.msg1.Location = new System.Drawing.Point(447, 24);
            this.msg1.Name = "msg1";
            this.msg1.Size = new System.Drawing.Size(297, 21);
            this.msg1.TabIndex = 15;
            // 
            // msg2
            // 
            this.msg2.Location = new System.Drawing.Point(447, 54);
            this.msg2.Name = "msg2";
            this.msg2.Size = new System.Drawing.Size(297, 21);
            this.msg2.TabIndex = 16;
            // 
            // msg3
            // 
            this.msg3.Location = new System.Drawing.Point(447, 81);
            this.msg3.Name = "msg3";
            this.msg3.Size = new System.Drawing.Size(297, 21);
            this.msg3.TabIndex = 17;
            // 
            // msg4
            // 
            this.msg4.Location = new System.Drawing.Point(447, 110);
            this.msg4.Name = "msg4";
            this.msg4.Size = new System.Drawing.Size(297, 21);
            this.msg4.TabIndex = 18;
            // 
            // msg5
            // 
            this.msg5.Location = new System.Drawing.Point(447, 138);
            this.msg5.Name = "msg5";
            this.msg5.Size = new System.Drawing.Size(297, 21);
            this.msg5.TabIndex = 19;
            // 
            // portGroup
            // 
            this.portGroup.Controls.Add(this.portList);
            this.portGroup.Controls.Add(this.msg5);
            this.portGroup.Controls.Add(this.msg4);
            this.portGroup.Controls.Add(this.msg3);
            this.portGroup.Controls.Add(this.msg2);
            this.portGroup.Controls.Add(this.msg1);
            this.portGroup.Controls.Add(this.activate5);
            this.portGroup.Controls.Add(this.activate4);
            this.portGroup.Controls.Add(this.activate3);
            this.portGroup.Controls.Add(this.activate2);
            this.portGroup.Controls.Add(this.activate1);
            this.portGroup.Controls.Add(this.portChange5);
            this.portGroup.Controls.Add(this.portChange4);
            this.portGroup.Controls.Add(this.portChange3);
            this.portGroup.Controls.Add(this.portChange2);
            this.portGroup.Controls.Add(this.portChange1);
            this.portGroup.Controls.Add(this.portNo5);
            this.portGroup.Controls.Add(this.portNo4);
            this.portGroup.Controls.Add(this.portNo3);
            this.portGroup.Controls.Add(this.portNo2);
            this.portGroup.Controls.Add(this.portNo1);
            this.portGroup.Location = new System.Drawing.Point(8, 13);
            this.portGroup.Name = "portGroup";
            this.portGroup.Size = new System.Drawing.Size(752, 170);
            this.portGroup.TabIndex = 20;
            this.portGroup.TabStop = false;
            this.portGroup.Text = "Port Setting";
            // 
            // portList
            // 
            this.portList.FormattingEnabled = true;
            this.portList.ItemHeight = 12;
            this.portList.Location = new System.Drawing.Point(7, 21);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(149, 136);
            this.portList.TabIndex = 20;
            // 
            // DataGroup
            // 
            this.DataGroup.Controls.Add(this.recordBtn);
            this.DataGroup.Controls.Add(this.progressBar1);
            this.DataGroup.Controls.Add(this.label3);
            this.DataGroup.Controls.Add(this.samplingText);
            this.DataGroup.Controls.Add(this.label4);
            this.DataGroup.Controls.Add(this.label2);
            this.DataGroup.Controls.Add(this.epochText);
            this.DataGroup.Controls.Add(this.label1);
            this.DataGroup.Location = new System.Drawing.Point(972, 12);
            this.DataGroup.Name = "DataGroup";
            this.DataGroup.Size = new System.Drawing.Size(260, 170);
            this.DataGroup.TabIndex = 21;
            this.DataGroup.TabStop = false;
            this.DataGroup.Text = "Data Setting";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 136);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Times";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // samplingText
            // 
            this.samplingText.Location = new System.Drawing.Point(96, 52);
            this.samplingText.Name = "samplingText";
            this.samplingText.Size = new System.Drawing.Size(100, 21);
            this.samplingText.TabIndex = 4;
            this.samplingText.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sampling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Times";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epochText
            // 
            this.epochText.Location = new System.Drawing.Point(96, 25);
            this.epochText.Name = "epochText";
            this.epochText.Size = new System.Drawing.Size(100, 21);
            this.epochText.TabIndex = 1;
            this.epochText.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record Epoch";
            // 
            // msgList
            // 
            this.msgList.FormattingEnabled = true;
            this.msgList.ItemHeight = 12;
            this.msgList.Location = new System.Drawing.Point(8, 190);
            this.msgList.Name = "msgList";
            this.msgList.Size = new System.Drawing.Size(1224, 460);
            this.msgList.TabIndex = 22;
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(121, 82);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(75, 23);
            this.recordBtn.TabIndex = 7;
            this.recordBtn.Text = "Record";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 662);
            this.Controls.Add(this.msgList);
            this.Controls.Add(this.DataGroup);
            this.Controls.Add(this.portGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Zephyr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.portGroup.ResumeLayout(false);
            this.portGroup.PerformLayout();
            this.DataGroup.ResumeLayout(false);
            this.DataGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort4;
        private System.IO.Ports.SerialPort serialPort5;
        private System.Windows.Forms.TextBox portNo1;
        private System.Windows.Forms.TextBox portNo2;
        private System.Windows.Forms.TextBox portNo3;
        private System.Windows.Forms.TextBox portNo4;
        private System.Windows.Forms.TextBox portNo5;
        private System.Windows.Forms.Button portChange1;
        private System.Windows.Forms.Button portChange2;
        private System.Windows.Forms.Button portChange3;
        private System.Windows.Forms.Button portChange4;
        private System.Windows.Forms.Button portChange5;
        private System.Windows.Forms.CheckBox activate1;
        private System.Windows.Forms.CheckBox activate2;
        private System.Windows.Forms.CheckBox activate3;
        private System.Windows.Forms.CheckBox activate4;
        private System.Windows.Forms.CheckBox activate5;
        private System.Windows.Forms.TextBox msg1;
        private System.Windows.Forms.TextBox msg2;
        private System.Windows.Forms.TextBox msg3;
        private System.Windows.Forms.TextBox msg4;
        private System.Windows.Forms.TextBox msg5;
        private System.Windows.Forms.GroupBox portGroup;
        private System.Windows.Forms.GroupBox DataGroup;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox samplingText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox epochText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox msgList;
        private System.Windows.Forms.ListBox portList;
        private System.Windows.Forms.Button recordBtn;
    }
}

