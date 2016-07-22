using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Zun Dai
 * Student ID: 300839401
 * Date modified: 2016-07-20
 * Program description: Assigment4, Array and List
 * 
 */

namespace AirLineReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            Random rnd = new Random();
            Flight air = new Flight();

            while (selection != 3)
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("  1. For first class");
                Console.WriteLine("  2. For economy");
                Console.WriteLine("  3. Exit");
                Console.WriteLine("**********************************");
                Console.Write("Please select: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    selection = 0;
                }

                switch (selection)
                {
                    case 1:
                        air.chooseFirstSeat();
                        break;
                    case 2:
                        air.chooseSecondSeat();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter a correct input \n");
                        break;
                }
            }
        }
    }
}
