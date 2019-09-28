using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int menuOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. add");  
                if (menuOption == 0)
                {
                    break;
                }
                Console.WriteLine("2. diff");
                Console.WriteLine("0. Exit");
            }
        }
    }
}
