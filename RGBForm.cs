using SerialManager;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoOne
{
    public partial class RGBForm : Form
    {

        public RGBForm()
        {
            InitializeComponent();
            ConfigureTrackers();
            ConfigureSerialHelper();
        }

        #region Properties
        SerialHelper serialHelper;
        public Action BackAction { get; set; }
        #endregion

        #region View Events
        private void sliderRed_ValueChanged(object sender, EventArgs e)
        {
            lbRed.Text = sliderRed.Value.ToString();
        }

        private void sliderGreen_ValueChanged(object sender, EventArgs e)
        {
            lbGreen.Text = sliderGreen.Value.ToString();
        }

        private void sliderBlue_ValueChanged(object sender, EventArgs e)
        {
            lbBlue.Text = sliderBlue.Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReturnToPreviewForm();
            this.Close();
        }

        private void RGBForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialHelper.DismissSerialMonitor();
            serialHelper.CloseSerialPort();
            ReturnToPreviewForm();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await SendColors();
        }
        #endregion

        #region My Methods
        private void ConfigureSerialHelper()
        {
            try
            {
                serialHelper = new SerialHelper();
                serialHelper.ChangePort(Program.SerialCOM);
                serialHelper.SetSerialListener(SerialListener);
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show(fe.Message, "Problema" );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problema");
            }
        }

        private void SerialListener(string data)
        {
            System.Diagnostics.Debug.WriteLine(data, "WS-DEBUG");
        }

        private void ConfigureTrackers()
        {
            sliderRed.Maximum = 255;
            sliderGreen.Maximum = 255;
            sliderBlue.Maximum = 255;
        }
        private void ReturnToPreviewForm()
        {
            if (BackAction != null)
            {
                BackAction.Invoke();
            }
        }

        private async Task SendColors()
        {
            try
            {
                string red = sliderRed.Value.ToString("D3");
                string green = sliderGreen.Value.ToString("D3");
                string blue = sliderBlue.Value.ToString("D3");

                string dataItem = string.Concat(red, green, blue);

                await serialHelper.SendData(dataItem);
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show(fe.Message, "Problema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problema");
            }            
        }

        #endregion

        private async void sliderRed_Scroll(object sender, EventArgs e)
        {
            await SendColors();
        }

        private async void sliderGreen_Scroll(object sender, EventArgs e)
        {
            await SendColors();
        }

        private async void sliderBlue_Scroll(object sender, EventArgs e)
        {
            await SendColors();
        }
    }
}
