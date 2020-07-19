using SerialManager;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ArduinoOne
{
    static class Program
    {

        public static string SerialCOM = "COM4";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new RGBForm());
            Application.Run(new ToogleLed());
        }

        public static void ExecuteOnMainThread(Action action)
        {
            action.Invoke();
        }
    }
}
