using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineReservation
{
    class Flight
    {
        // PRIVATE PROPERTIES
        private bool[] _seats = new bool[10];

        // CONSTRUCTOR
        public Flight()
        {
            initializeArray();
        }

        // PRIVATE METHODS
        // Initializes the value of checkValueArray as false
        private void initializeArray()
        {
            for (int index = 0; index < _seats.Length; index++)
            {
                this._seats[index] = false;
            }
        }

        // PUBLIC METHODS
        // Assign a seat in the first-class section (seats 1–5).
        public void chooseFirstSeat()
        {
            int index = 0;
            while (index < 5)
            {
                if (_seats[index] == false)
                {
                    this._seats[index] = true;
                    this.printSeats();
                    break;
                }
                else if (index == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** Every First class seats are not available ***");
                    Console.WriteLine("Next flight leaves in 3 hours");
                    Console.WriteLine();
                }
                index++;
            }
        }

        public void chooseSecondSeat()
        {
            int index = 5;
            string changeSeat;

            while (index < 10)
            {
                if (_seats[index] == false)
                {
                    this._seats[index] = true;
                    this.printSeats();
                    break;
                }

                else if (index == 9)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** No economy class seats available ***");
                    Console.Write("Do you want to reserve a first class seat? y(yes) or n(no): ");
                    changeSeat = Console.ReadLine();

                    if (changeSeat == "y")
                        chooseFirstSeat();
                    else
                    {
                        Console.WriteLine("Next flight leaves in 3 hours");
                        Console.WriteLine();
                    }
                }
                index++;
            }
        }

        // Display seats state
        public void printSeats()
        {
            Console.WriteLine();
            Console.WriteLine("**** FIRST CLASS ***** ECONOMY CLASS ****");
            Console.WriteLine(" 1   2   3   4   5 | 6   7   8   9   10 ");
            Console.WriteLine("*****************************************");
            for (int index = 0; index < _seats.Length; index++)
            {
                if (this._seats[index] == true)
                    Console.Write(" O  ");
                else
                    Console.Write(" X  ");
            }
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
    }
}
