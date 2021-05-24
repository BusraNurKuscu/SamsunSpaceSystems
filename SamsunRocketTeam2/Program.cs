using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamsunSpaceSystems
{
    static class Program
    {
        public static List<Database> globalLiveData = new List<Database>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // geçmiş datalar görülmek istenirse burası açılır
            //Program.globalLiveData = Database.GetAll();
            // geçmiş datalar görülmek istenirse burası açılır

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
