using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Swich_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 'A';
            char ch2 = 'B';

            switch (ch1)
            {
                case 'A': Console.WriteLine("This A is Part of outer swich");

                    switch (ch2)
                    {
                        case 'B': Console.WriteLine("This A is part of inner swich.");
                            break;
                    } // End Inner swich.


                    break;
            }

            Console.ReadKey();
        }
    }
}
