using SerialManager;
using System;
using System.Windows.Forms;

namespace ArduinoOne
{

    public partial class ToogleLed : Form
    {
        SerialHelper serialHelper;
        public ToogleLed()
        {
            InitializeComponent();
            ConfigureSerialHelper();
            LoadComPorts();
            ChekDisble();
        }

        private void ConfigureSerialHelper()
        {
            serialHelper = new SerialHelper();
            serialHelper.SetSerialListener(ShowDataFromSerial);
        }

        private  void ShowDataFromSerial(string data)
        {
            try
            {
                
                if (txtBoxLog.InvokeRequired)
                {
                    var delegateCallBack = new SafeCallDelegate(SetResultInView);
                    txtBoxLog.Invoke(delegateCallBack, new object[] { data });
                }
                else
                {
                    SetResultInView(data);
                }

            }
            catch (Exception e) {

                MessageBox.Show(e.Message);
            }

        }

        private void SetResultInView(string data)
        {
            txtBoxLog.Text += data +"\n";
        }

        private delegate void SafeCallDelegate(string text);

        private void LoadComPorts()
        {
            string[] ports = serialHelper.GetCOMPorts();

            cboxPorts.DataSource = ports;

            cboxPorts.SelectedItem = ports[1]; ;//temp
        }

   

        private void ChekDisble()
        {
            disableRdb.Checked = true;
        }

        private void enableRdb_CheckedChanged(object sender, EventArgs e)
        {
            if (enableRdb.Checked)
            {
                disableRdb.Checked = false;

            }
            ToogleLedCommand();
        }

        private void disableRdb_CheckedChanged(object sender, EventArgs e)
        {
            if (disableRdb.Checked)
            {
                enableRdb.Checked = false;
            }
        }

        private void ToogleLedCommand()
        {
            try
            {
                SendCommand();
            }
            catch (Exception e)
            {

                var erro = e.Message;
            }
        }

        private void SendCommand()
        {
            string commandLed = enableRdb.Checked ? "E" : "D";
            serialHelper.SendData(commandLed);
        }


        private void ToogleLed_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialHelper.CloseSerialPort();
        }

  

        private void cboxPorts_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangePort();
            SendCommand();
        }

        private void ChangePort()
        {
            serialHelper.ChangePort(cboxPorts.SelectedItem.ToString());
            Program.SerialCOM = cboxPorts.SelectedItem.ToString();
        }

        private void btnRGB_Click(object sender, EventArgs e)
        {
            GoToRGBForm();

        }

        private void GoToRGBForm()
        {
            this.Enabled = false;
            serialHelper.CloseSerialPort();
            var formRgb = new RGBForm();
            formRgb.BackAction = ReloadForm;
            formRgb.Show();
        }

        private void ReloadForm()
        {
            this.Enabled = true;
            serialHelper.SetSerialListener(ShowDataFromSerial);
        }
    }
}
