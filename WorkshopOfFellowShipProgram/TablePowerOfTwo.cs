using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopOfFellowShipProgram
{
    public class TablePowerOfTwo
    {
        public void Table(int num)
        {
            if (0 < num && num <= 31)
            {
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(2 + "^" + i + "=" + Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("OverStackFlow");
            }
        }
    }
}
