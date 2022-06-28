using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_and_Pascode_task
{
    public class Checking
    {
        public static int CheckingGmailAndPascode(string name, int pascode)
        {
            string n = "cavid@code.edu.az";
            int m = 12345;

            if (pascode == m && (name == n)) 
            {
                Console.WriteLine("Girish olundu");
                return -1;
            }
            else
            {
                Console.WriteLine("Mail ve yaxud password sehvdir");
                return -1;
            }




            
            

        }
    }
}
