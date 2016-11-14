using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVFeedbackApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = Properties.Settings.Default.TemplateDBConnectionString;
            DBConnection.ConnectionStr = connectionString;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstMenuForm());

            //add connection string here
            
            

            //Application.Run(new DBForm());

        }
    }
}
