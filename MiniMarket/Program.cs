using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniMarket
{
    static public  class Program
    {
        static bool isUserLoggedin = false;

        /*procitaj malo na netu sta su static clase ,okPOK  OK */
        public static bool IsUserLoggedin
        {
            get { return isUserLoggedin; }
            set { isUserLoggedin = value; }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

/*mislim da si mozda ovaj kod mijenjao 
 ,,,, jesam, dodao sam Application*/
//ova forma nije ok vise treba ovo napraviti iz pocetka