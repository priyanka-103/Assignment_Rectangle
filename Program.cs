using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
        }

        void Go()
        {

            Rectangle r;
            int menu1 = ValidateMenu1Selection();
            if (menu1 == 2)
            {
                r = new Rectangle((ValidateUserInput("length")), (ValidateUserInput("width")));

            }
            else
            {
                r = new Rectangle();
            }

            bool keepGoing = true;

            while (keepGoing == true)
            {

                int menu = ValidateMenuSelection();

                switch (menu)
                {
                    case 1:
                        Console.WriteLine($"The length of your Rectangle is {r.GetLength()} unit.");
                        break;
                    case 2:
                        r.SetLength(ValidateUserInput("length"));
                        break;
                    case 3:
                        Console.WriteLine($"The width of your Rectangle is {r.GetWidth()} unit.");
                        break;
                    case 4:
                        r.SetWidth(ValidateUserInput("width"));
                        break;
                    case 5:
                        Console.WriteLine($"The perimeter of your rectangle is {r.GetPerimeter()} unit.");
                        break;
                    case 6:
                        Console.WriteLine($"The area of your rectangle is {r.GetArea() } square unit.");
                        break;
                    default:
                        keepGoing = false;
                        break;
                }

            }
        }

        public static int ValidateMenu1Selection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {

                Console.WriteLine("1. Create Default(1 unit X 1 unit) Rectangle");
                Console.WriteLine("2. Create Custom Rectangle");



                Console.WriteLine("Please select an option by entering a number ");
                userInput = Console.ReadLine();

                if (userInput == "1" || userInput == "2")
                {
                    validMenuSelect = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please enter a number within 1 & 2. ");

                }
            }

            Console.WriteLine();
            return int.Parse(userInput);

        }



        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {

                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit");


                Console.WriteLine("Please select an option by entering a number ");
                userInput = Console.ReadLine();

                if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5" || userInput == "6" || userInput == "7")
                {
                    validMenuSelect = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please enter a number within 1-7. ");

                }
            }


            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.Write($"Please enter the {rectSide} of your rectangle as an integer within 1-100: ");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("That is not a valid input, please input an integer within 1-100");
                }
                else if (number < 1)
                {
                    Console.WriteLine("Number cannot be less than 1, please try again");
                }
                else if (number > 100)
                {
                    Console.WriteLine("Number cannot be greater than 100, please try again");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {rectSide} of your rectangle is now {number}.\n");
                }
            }
            return number;
        }
    }


}
