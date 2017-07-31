using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototypeS.Models;
using System.Threading;
using System.Diagnostics;

namespace PrototypeS
{
    static class Program
    {
        //Static Object for Database Handling.
        public static CrudDB db;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool mutexCreated = true;
            using (Mutex mutex = new Mutex(true, "PROTOTYPES-4BFCE54B-7836-4D11-B0CD-91AAED489293", out mutexCreated))
            {
                if (mutexCreated)
                {
                    //Program.db = new CrudDB();
                    //bool success = Program.db.connectDB();
                    //if (!success)
                    //{
                    //    return;
                    //}

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new HostForm());
                    //Application.Run(new MainForm("admin", "admin"));
                    //Application.Run(new LoginForm());
                }
                else
                {
                    MessageBox.Show("Another instance of application is already running.", "Already running", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
