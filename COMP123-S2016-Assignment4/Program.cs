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

namespace DiceRollingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sums = new int[13];
            int sum = 0;
            int die1 = 0;
            int die2 = 0;
            int[,] dieValues = new int[7, 7];
             
            Random rndmDie = new Random();


            for (int i = 0; i < 36000; i++)
            {
                die1 = rndmDie.Next(1, 7);
                die2 = rndmDie.Next(1, 7);
                sum = die1 + die2;
                sums[sum] += 1;
                dieValues[die1, die2] += 1;
            }

            Console.WriteLine("    2       3       4       5       6       7       8       9       10       11       12");
             
            for (int i = 2; i <= 12; i++)
            {
                Console.Write("    {0:D4}", sums[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    1          2          3          4          5          6");
            Console.WriteLine("*******************************************************************");

            for (int r = 1; r <= 6; r++)
            {
                Console.Write("    {0:N0} |", r);
                for (int c = 1; c <= 6; c++)
                {
                    Console.Write("    {0:D4} |", dieValues[r, c]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
