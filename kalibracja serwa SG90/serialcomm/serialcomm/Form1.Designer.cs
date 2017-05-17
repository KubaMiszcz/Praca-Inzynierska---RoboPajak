namespace serialcomm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenClosePort = new System.Windows.Forms.Button();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChosenSerial = new System.Windows.Forms.ComboBox();
            this.tbDataContinuoslyReceived = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.tbDataReceived = new System.Windows.Forms.TextBox();
            this.btnSendString = new System.Windows.Forms.Button();
            this.tbSendingData = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatusPortu = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnminus30 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbStartContinuousReceiving = new System.Windows.Forms.CheckBox();
            this.btnStartContinuousReceiving = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSendSliderVal = new System.Windows.Forms.Button();
            this.tbslider1val = new System.Windows.Forms.TextBox();
            this.btnplus20 = new System.Windows.Forms.Button();
            this.btnplus10 = new System.Windows.Forms.Button();
            this.btnminus20 = new System.Windows.Forms.Button();
            this.btnminus10 = new System.Windows.Forms.Button();
            this.btnplus30 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbslider1max = new System.Windows.Forms.TextBox();
            this.btnmax = new System.Windows.Forms.Button();
            this.tbslider1min = new System.Windows.Forms.TextBox();
            this.tbmax = new System.Windows.Forms.TextBox();
            this.slider1 = new System.Windows.Forms.TrackBar();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn180 = new System.Windows.Forms.Button();
            this.btn135 = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.tb135 = new System.Windows.Forms.TextBox();
            this.tb180 = new System.Windows.Forms.TextBox();
            this.tb0 = new System.Windows.Forms.TextBox();
            this.tb45 = new System.Windows.Forms.TextBox();
            this.tb90 = new System.Windows.Forms.TextBox();
            this.tbmin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOpenClosePort);
            this.groupBox1.Controls.Add(this.cbBaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbChosenSerial);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnOpenClosePort
            // 
            resources.ApplyResources(this.btnOpenClosePort, "btnOpenClosePort");
            this.btnOpenClosePort.Name = "btnOpenClosePort";
            this.btnOpenClosePort.UseVisualStyleBackColor = true;
            this.btnOpenClosePort.Click += new System.EventHandler(this.btnOpenClosePort_Click);
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            resources.GetString("cbBaudrate.Items"),
            resources.GetString("cbBaudrate.Items1"),
            resources.GetString("cbBaudrate.Items2"),
            resources.GetString("cbBaudrate.Items3"),
            resources.GetString("cbBaudrate.Items4"),
            resources.GetString("cbBaudrate.Items5"),
            resources.GetString("cbBaudrate.Items6"),
            resources.GetString("cbBaudrate.Items7"),
            resources.GetString("cbBaudrate.Items8"),
            resources.GetString("cbBaudrate.Items9"),
            resources.GetString("cbBaudrate.Items10"),
            resources.GetString("cbBaudrate.Items11"),
            resources.GetString("cbBaudrate.Items12"),
            resources.GetString("cbBaudrate.Items13"),
            resources.GetString("cbBaudrate.Items14"),
            resources.GetString("cbBaudrate.Items15"),
            resources.GetString("cbBaudrate.Items16")});
            resources.ApplyResources(this.cbBaudrate, "cbBaudrate");
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.SelectedIndexChanged += new System.EventHandler(this.cbBaudrate_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbChosenSerial
            // 
            this.cbChosenSerial.FormattingEnabled = true;
            resources.ApplyResources(this.cbChosenSerial, "cbChosenSerial");
            this.cbChosenSerial.Name = "cbChosenSerial";
            this.cbChosenSerial.SelectedIndexChanged += new System.EventHandler(this.cbChosenSerial_SelectedIndexChanged);
            // 
            // tbDataContinuoslyReceived
            // 
            resources.ApplyResources(this.tbDataContinuoslyReceived, "tbDataContinuoslyReceived");
            this.tbDataContinuoslyReceived.Name = "tbDataContinuoslyReceived";
            this.tbDataContinuoslyReceived.ReadOnly = true;
            // 
            // btnReceive
            // 
            resources.ApplyResources(this.btnReceive, "btnReceive");
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // tbDataReceived
            // 
            resources.ApplyResources(this.tbDataReceived, "tbDataReceived");
            this.tbDataReceived.Name = "tbDataReceived";
            this.tbDataReceived.ReadOnly = true;
            // 
            // btnSendString
            // 
            resources.ApplyResources(this.btnSendString, "btnSendString");
            this.btnSendString.Name = "btnSendString";
            this.btnSendString.UseVisualStyleBackColor = true;
            this.btnSendString.Click += new System.EventHandler(this.btnSendString_Click);
            // 
            // tbSendingData
            // 
            resources.ApplyResources(this.tbSendingData, "tbSendingData");
            this.tbSendingData.Name = "tbSendingData";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbStatusPortu,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // lbStatusPortu
            // 
            this.lbStatusPortu.Name = "lbStatusPortu";
            resources.ApplyResources(this.lbStatusPortu, "lbStatusPortu");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSendingData);
            this.groupBox2.Controls.Add(this.btnSendString);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnminus30
            // 
            resources.ApplyResources(this.btnminus30, "btnminus30");
            this.btnminus30.Name = "btnminus30";
            this.btnminus30.UseVisualStyleBackColor = true;
            this.btnminus30.Click += new System.EventHandler(this.btnminus30_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbStartContinuousReceiving);
            this.groupBox3.Controls.Add(this.btnStartContinuousReceiving);
            this.groupBox3.Controls.Add(this.tbDataReceived);
            this.groupBox3.Controls.Add(this.tbDataContinuoslyReceived);
            this.groupBox3.Controls.Add(this.btnReceive);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cbStartContinuousReceiving
            // 
            resources.ApplyResources(this.cbStartContinuousReceiving, "cbStartContinuousReceiving");
            this.cbStartContinuousReceiving.Name = "cbStartContinuousReceiving";
            this.cbStartContinuousReceiving.UseVisualStyleBackColor = true;
            // 
            // btnStartContinuousReceiving
            // 
            resources.ApplyResources(this.btnStartContinuousReceiving, "btnStartContinuousReceiving");
            this.btnStartContinuousReceiving.Name = "btnStartContinuousReceiving";
            this.btnStartContinuousReceiving.UseVisualStyleBackColor = true;
            this.btnStartContinuousReceiving.Click += new System.EventHandler(this.btnStartContinuousReceiving_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSendSliderVal);
            this.groupBox4.Controls.Add(this.tbslider1val);
            this.groupBox4.Controls.Add(this.btnplus20);
            this.groupBox4.Controls.Add(this.btnplus10);
            this.groupBox4.Controls.Add(this.btnminus20);
            this.groupBox4.Controls.Add(this.btnminus10);
            this.groupBox4.Controls.Add(this.btnplus30);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnminus30);
            this.groupBox4.Controls.Add(this.tbslider1max);
            this.groupBox4.Controls.Add(this.btnmax);
            this.groupBox4.Controls.Add(this.tbslider1min);
            this.groupBox4.Controls.Add(this.tbmax);
            this.groupBox4.Controls.Add(this.slider1);
            this.groupBox4.Controls.Add(this.btn0);
            this.groupBox4.Controls.Add(this.btn45);
            this.groupBox4.Controls.Add(this.btn180);
            this.groupBox4.Controls.Add(this.btn135);
            this.groupBox4.Controls.Add(this.btn90);
            this.groupBox4.Controls.Add(this.btnmin);
            this.groupBox4.Controls.Add(this.tb135);
            this.groupBox4.Controls.Add(this.tb180);
            this.groupBox4.Controls.Add(this.tb0);
            this.groupBox4.Controls.Add(this.tb45);
            this.groupBox4.Controls.Add(this.tb90);
            this.groupBox4.Controls.Add(this.tbmin);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btnSendSliderVal
            // 
            resources.ApplyResources(this.btnSendSliderVal, "btnSendSliderVal");
            this.btnSendSliderVal.Name = "btnSendSliderVal";
            this.btnSendSliderVal.UseVisualStyleBackColor = true;
            this.btnSendSliderVal.Click += new System.EventHandler(this.btnSendSliderVal_Click);
            // 
            // tbslider1val
            // 
            resources.ApplyResources(this.tbslider1val, "tbslider1val");
            this.tbslider1val.Name = "tbslider1val";
            this.tbslider1val.TextChanged += new System.EventHandler(this.tbslider1val_TextChanged);
            // 
            // btnplus20
            // 
            resources.ApplyResources(this.btnplus20, "btnplus20");
            this.btnplus20.Name = "btnplus20";
            this.btnplus20.UseVisualStyleBackColor = true;
            this.btnplus20.Click += new System.EventHandler(this.btnplus20_Click);
            // 
            // btnplus10
            // 
            resources.ApplyResources(this.btnplus10, "btnplus10");
            this.btnplus10.Name = "btnplus10";
            this.btnplus10.UseVisualStyleBackColor = true;
            this.btnplus10.Click += new System.EventHandler(this.btnplus10_Click);
            // 
            // btnminus20
            // 
            resources.ApplyResources(this.btnminus20, "btnminus20");
            this.btnminus20.Name = "btnminus20";
            this.btnminus20.UseVisualStyleBackColor = true;
            this.btnminus20.Click += new System.EventHandler(this.btnminus20_Click);
            // 
            // btnminus10
            // 
            resources.ApplyResources(this.btnminus10, "btnminus10");
            this.btnminus10.Name = "btnminus10";
            this.btnminus10.UseVisualStyleBackColor = true;
            this.btnminus10.Click += new System.EventHandler(this.btnminus10_Click);
            // 
            // btnplus30
            // 
            resources.ApplyResources(this.btnplus30, "btnplus30");
            this.btnplus30.Name = "btnplus30";
            this.btnplus30.UseVisualStyleBackColor = true;
            this.btnplus30.Click += new System.EventHandler(this.btnplus30_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbslider1max
            // 
            resources.ApplyResources(this.tbslider1max, "tbslider1max");
            this.tbslider1max.Name = "tbslider1max";
            this.tbslider1max.TextChanged += new System.EventHandler(this.Event_UpdateSlider);
            this.tbslider1max.Enter += new System.EventHandler(this.Event_UpdateSlider);
            // 
            // btnmax
            // 
            resources.ApplyResources(this.btnmax, "btnmax");
            this.btnmax.Name = "btnmax";
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // tbslider1min
            // 
            resources.ApplyResources(this.tbslider1min, "tbslider1min");
            this.tbslider1min.Name = "tbslider1min";
            this.tbslider1min.TextChanged += new System.EventHandler(this.Event_UpdateSlider);
            this.tbslider1min.Enter += new System.EventHandler(this.Event_UpdateSlider);
            // 
            // tbmax
            // 
            resources.ApplyResources(this.tbmax, "tbmax");
            this.tbmax.Name = "tbmax";
            // 
            // slider1
            // 
            this.slider1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.slider1, "slider1");
            this.slider1.Maximum = 1023;
            this.slider1.Name = "slider1";
            this.slider1.TickFrequency = 64;
            this.slider1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.slider1.Value = 512;
            this.slider1.Scroll += new System.EventHandler(this.Event_UpdateSlider);
            this.slider1.ValueChanged += new System.EventHandler(this.Event_UpdateSlider);
            // 
            // btn0
            // 
            resources.ApplyResources(this.btn0, "btn0");
            this.btn0.Name = "btn0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn45
            // 
            resources.ApplyResources(this.btn45, "btn45");
            this.btn45.Name = "btn45";
            this.btn45.UseVisualStyleBackColor = true;
            this.btn45.Click += new System.EventHandler(this.btn45_Click);
            // 
            // btn180
            // 
            resources.ApplyResources(this.btn180, "btn180");
            this.btn180.Name = "btn180";
            this.btn180.UseVisualStyleBackColor = true;
            this.btn180.Click += new System.EventHandler(this.btn180_Click);
            // 
            // btn135
            // 
            resources.ApplyResources(this.btn135, "btn135");
            this.btn135.Name = "btn135";
            this.btn135.UseVisualStyleBackColor = true;
            this.btn135.Click += new System.EventHandler(this.btn135_Click);
            // 
            // btn90
            // 
            resources.ApplyResources(this.btn90, "btn90");
            this.btn90.Name = "btn90";
            this.btn90.UseVisualStyleBackColor = true;
            this.btn90.Click += new System.EventHandler(this.btn90_Click);
            // 
            // btnmin
            // 
            resources.ApplyResources(this.btnmin, "btnmin");
            this.btnmin.Name = "btnmin";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // tb135
            // 
            resources.ApplyResources(this.tb135, "tb135");
            this.tb135.Name = "tb135";
            // 
            // tb180
            // 
            resources.ApplyResources(this.tb180, "tb180");
            this.tb180.Name = "tb180";
            // 
            // tb0
            // 
            resources.ApplyResources(this.tb0, "tb0");
            this.tb0.Name = "tb0";
            // 
            // tb45
            // 
            resources.ApplyResources(this.tb45, "tb45");
            this.tb45.Name = "tb45";
            // 
            // tb90
            // 
            resources.ApplyResources(this.tb90, "tb90");
            this.tb90.Name = "tb90";
            // 
            // tbmin
            // 
            resources.ApplyResources(this.tbmin, "tbmin");
            this.tbmin.Name = "tbmin";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox tbDataReceived;
        private System.Windows.Forms.Button btnSendString;
        private System.Windows.Forms.TextBox tbSendingData;
        private System.Windows.Forms.ComboBox cbChosenSerial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenClosePort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusPortu;
        private System.Windows.Forms.TextBox tbDataContinuoslyReceived;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStartContinuousReceiving;
        private System.Windows.Forms.CheckBox cbStartContinuousReceiving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnminus30;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbslider1max;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.TextBox tbslider1min;
        private System.Windows.Forms.TextBox tbmax;
        private System.Windows.Forms.TrackBar slider1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn180;
        private System.Windows.Forms.Button btn135;
        private System.Windows.Forms.Button btn90;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.TextBox tb135;
        private System.Windows.Forms.TextBox tb180;
        private System.Windows.Forms.TextBox tb0;
        private System.Windows.Forms.TextBox tb45;
        private System.Windows.Forms.TextBox tb90;
        private System.Windows.Forms.TextBox tbmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnplus20;
        private System.Windows.Forms.Button btnplus10;
        private System.Windows.Forms.Button btnminus20;
        private System.Windows.Forms.Button btnminus10;
        private System.Windows.Forms.Button btnplus30;
        private System.Windows.Forms.TextBox tbslider1val;
        private System.Windows.Forms.Button btnSendSliderVal;
    }
}

