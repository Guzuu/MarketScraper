using System;
using System.Windows.Forms;

namespace MarketScraper
{
    static class Program
    {
        /// <summary>
        /// Created public so main menu form is easier accessible 
        /// </summary>
        static public Form1 f1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            f1 = new Form1();
            Application.Run(f1);
        }
    }
}
