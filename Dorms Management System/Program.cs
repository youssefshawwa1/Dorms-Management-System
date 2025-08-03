using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorms_Management_System
{
    
     static class Program
    {
        public static FormLogin loginForm;
        public static FormDashboard dashboardForm;
        public static string conString = "Data Source=.;Initial Catalog=dorms; Integrated Security=True; TrustServerCertificate=true;";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new FormLogin();
            Application.Run(loginForm);
        }
    }
}
