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
using serialcomm.Properties;
using System.Globalization;
using System.Threading;

namespace serialcomm
{
    public partial class Form1 : Form
    {
        public String DataReceived;
        public String DataToSend;
        public Form1()
        {
            InitializeComponent();
            UpdateSlider(slider1,tbslider1min,tbslider1max,tbslider1val);
            DataReceived = "";
            DataToSend = "";
            FillPortList();
        }

        private void btnOpenClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen) // Jeżeli port nie jest otwarty, otwieramy go
                {
                    serialPort1.Open(); // otwarcie portu
                    StringBuilder sb = new StringBuilder();
                    lbStatusPortu.Text = sb.Append(serialPort1.PortName) + " (" + serialPort1.BaudRate + ") Opened.";
                    // wyświetlenie informacji o otwarciu portu w polu 'stan'
                    btnOpenClosePort.Text = aStrings.Close_port;
                }
                else // Jeżeli port  jest otwarty, zamykamy go
                {
                    this.BeginInvoke(new EventHandler(ClosePort)); // wywołanie metody
                    StringBuilder sb = new StringBuilder();
                    lbStatusPortu.Text = sb.Append(serialPort1.PortName) + " (" + serialPort1.BaudRate + ") Closed.";
                        // wyświetlenie informacji o otwarciu portu w polu 'stan'
                    btnOpenClosePort.Text = aStrings.Openport;
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Wybrany port jest zajety");
            }
            catch (Exception ex)
            {
                Report(ex);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) // Instrukcje jakie mają się wykonac w momencie odebrania danych z portu szeregowego.
        {
            try
            {
                DataReceived = serialPort1.ReadLine(); // odczyt linii 
                this.BeginInvoke(new EventHandler(DisplayDataReceived)); // wywołanie metody
            }
            catch (Exception ex)
            {
                Report(ex);
            }
          }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                DataReceived = serialPort1.ReadExisting(); // odczyt linii 
                if (DataReceived!="")DataReceived = DataReceived.Substring(DataReceived.Length - 4);
                this.BeginInvoke(new EventHandler(DisplayDataReceived)); // wywołanie metody
                //this.BeginInvoke(new EventHandler(DisplayDataReceived)); // wywołanie metody
       }
            catch (Exception ex)
            {
                Report(ex);
            }
        }


        private void btnSendString_Click(object sender, EventArgs e)
        {

            DataToSend = tbSendingData.Text;
            SendData(DataToSend);
        }

        private void SendData(string dataToSend)
        {
            try
            {
                serialPort1.Write(dataToSend);
               // lbDatatosend.Text = dataToSend;
                //serialPort1.ReadLine();
            }
            catch (Exception ex)
            {
                Report(ex);
            }
        }

        
        private void btnStartContinuousReceiving_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cbStartContinuousReceiving.Checked)
                {
                    this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
                    cbStartContinuousReceiving.Checked = true;
                    btnStartContinuousReceiving.Text = "Stop Receive Continuous";
                }
                else
                {
                    this.serialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
                    cbStartContinuousReceiving.Checked = false;
                    btnStartContinuousReceiving.Text = "Start Receive Continuous";
                }
                

                //DataReceived = serialPort1.ReadLine(); // odczyt linii 
                //if (DataReceived == "512")
                //{
                //    MessageBox.Show("juhu");
                //}
                //this.BeginInvoke(new EventHandler(DisplayDataReceived)); // wywołanie metody
            }
            catch (Exception ex)
            {
                Report(ex);
            }
        }


        ///################///################///################///################
        /// ///################///################///################
        /// ///################///################///################///################
        /// ///################///################///################
        
        private void UpdateSlider(TrackBar slider, TextBox tbMin, TextBox tbMax, TextBox sliderval)
        {
            try
            {
                int minn = int.Parse(tbMin.Text);
                int maxx = int.Parse(tbMax.Text);
                if (minn > maxx)
                {
                    minn = maxx;
                    tbMin.Text = minn.ToString();
                }
                if (maxx < minn)
                {
                    maxx = minn;
                    tbMax.Text = maxx.ToString();
                }
                slider.Minimum = minn;
                slider.Maximum = maxx;
                if (slider.Value < minn)
                {
                    slider.Value = minn;
                }
                if (slider.Value >maxx)
                {
                    slider.Value = maxx;
                }
                
                slider.TickFrequency = (slider.Maximum - slider.Minimum) / 10;
                tbslider1val.Text = slider.Value.ToString();
            }
            catch (Exception ex)
            {Report(ex);
            }
        }

        private void FillPortList()
        {
            List<string> portList = new List<string>(SerialPort.GetPortNames());
            if (portList.Count != 0)
            {
                foreach (var VARIABLE in portList)
                {
                    cbChosenSerial.Items.Add(VARIABLE);
                }
                cbChosenSerial.SelectedIndex = 0;
                serialPort1.PortName = cbChosenSerial.Text; // nazwa portu gdzie jest Arduino podłączone
                serialPort1.BaudRate = int.Parse(cbBaudrate.Text);
                StringBuilder sb = new StringBuilder();
                lbStatusPortu.Text = sb.Append(serialPort1.PortName) + " (" + serialPort1.BaudRate + ") Closed"; // wyświetlenie informacji o otwarciu portu w polu 'stan'
            }
            else
            {
                cbChosenSerial.Text = aStrings.brak_portow; // nazwa portu gdzie jest Arduino podłączone
                lbStatusPortu.Text = aStrings.brak_portow;
            }
        }

        private void Event_UpdateSlider(object sender, EventArgs e)
        {
            UpdateSlider(slider1,tbslider1min,tbslider1max,tbslider1val);
        }

        private void btnminus30_Click(object sender, EventArgs e)
        {
            SliderAdd(slider1, -30);
        }

        private void btnminus20_Click(object sender, EventArgs e)
        {
            SliderAdd(slider1, -20);
        }

        private void btnminus10_Click(object sender, EventArgs e)
        {
            SliderAdd(slider1,-10);
        }



        private void btnplus10_Click(object sender, EventArgs e)
        {
            SliderAdd(slider1, 10);
        }

        private void btnplus20_Click(object sender, EventArgs e)
        {
            SliderAdd(slider1, 20);
        }

        private void btnplus30_Click(object sender, EventArgs e)
        {
            SliderAdd(slider1, 30);
        }

        private void cbChosenSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = cbChosenSerial.Text; // nazwa portu gdzie jest Arduino podłączone

        }
        private void cbBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = int.Parse(cbBaudrate.Text);
        }
        private void ClosePort(object sender, EventArgs e)
        {
            serialPort1.Close();
        }
        void Report(Exception ex)
        {
            MessageBox.Show(ex.Message + "\n\n" + ex.GetType() + "\n\n" + ex.StackTrace);
        }
        private void DisplayDataReceived(object sender, EventArgs e)
        {
            tbDataReceived.Text = DataReceived; // wstawienie wartości do pola tekstowego
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // instrukcje jakie mają się wykonac w przypadku wyłączenia okna programu
        {
            serialPort1.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SliderAdd(TrackBar slider, int n)
        {
            try
            {
                int newVal = slider.Value + n;
                if (newVal < slider.Minimum) newVal = slider.Minimum;
                if (newVal > slider.Maximum) newVal = slider.Maximum;
                slider.Value = newVal;
            }
            catch (Exception ex)
            {

                Report(ex);
            }

        }

        private void ev(object sender, EventArgs e)
        {

        }
        private void btnmin_Click(object sender, EventArgs e)
        {
            String dataToSend = tbmin.Text;
            SendData(dataToSend);

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            String dataToSend = tb0.Text;
            SendData(dataToSend);
        }


        private void btn45_Click(object sender, EventArgs e)
        {
            String dataToSend = tb45.Text;
            SendData(dataToSend);
        }

        private void btn90_Click(object sender, EventArgs e)
        {
            String dataToSend = tb90.Text;
            SendData(dataToSend);
        }

        private void btn135_Click(object sender, EventArgs e)
        {
            String dataToSend = tb135.Text;
            SendData(dataToSend);
        }

        private void btn180_Click(object sender, EventArgs e)
        {
            String dataToSend = tb180.Text;
            SendData(dataToSend);
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            String dataToSend = tbmax.Text;
            SendData(dataToSend);
        }

        private void tbslider1val_TextChanged(object sender, EventArgs e)
        {
            slider1.Value= int.Parse(tbslider1val.Text);
        }

        private void btnSendSliderVal_Click(object sender, EventArgs e)
        {
            SendData(tbslider1val.Text);
        }
    }
}
