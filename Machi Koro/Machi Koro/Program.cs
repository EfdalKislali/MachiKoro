using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machi_Koro
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
            Application.Run(new Form1());

            /*
            Cards restaurant = new Cards(3, 9 + 1, "restaurant", "rood");
            Table table = new Table();
            table.VoegToe(restaurant);
            Console.WriteLine(table);
            */
        }
    }
}
