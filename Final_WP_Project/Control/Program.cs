using Final_WP_Project.View;
using Final_WP_Project.View.Manager;
using Final_WP_Project.View.Manager.Employee_click;
using Final_WP_Project.View.Reception;
using Final_WP_Project.View.Reception.Room;
using Final_WP_Project.View.Reception.RoomClick;
using Final_WP_Project.View.Reception.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Final_WP_Project
{
    static class Program
    {
        //Test102
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DayOff());
        }
    }
}
