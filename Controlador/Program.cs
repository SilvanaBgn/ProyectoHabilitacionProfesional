using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Text;

namespace ProyectoHabilitacionProfesional
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //String baseUri = "http://www.google.com.ar";
            //HttpWebRequest connection =
            //(HttpWebRequest)HttpWebRequest.Create(baseUri);
            System.Diagnostics.Process.Start("http://www.google.com.ar");
            //Application.Run(new Form1());
        }
    }
}
