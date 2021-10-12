
//Exponents_Lab_3 #3
//***Marjorie Patton***


using System;

namespace Exponents_Lab_3
{
    class Program
    {

        static void Main(string[] args)
        {

            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine();

                bool goAgain = true;

                while (goAgain == true)
                {

                    Console.Write("Enter an integer: ");

                    {

                        double square;
                        double cube;
                        double beginNumber=1;
                        double endNumber= double.Parse(Console.ReadLine());

                        Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");
                        Console.WriteLine("=======" + "\t" + "=======" + "\t" + "=======");

                        while (beginNumber <= endNumber)
                        {
                            
                            square = (beginNumber * beginNumber);
                            cube = (beginNumber * beginNumber * beginNumber);
                            Console.WriteLine(beginNumber + "\t" + square + "\t" + cube);
                            beginNumber = beginNumber + 1;
                        }


                        bool askAgain = true;
                        while (askAgain == true)
                        {

                            Console.WriteLine();
                            Console.Write("Continue? (y/n): ");
                            Console.Write();

                            string answer = Console.ReadLine().ToLower();

                            if (answer == "y")
                            {
                                askAgain = false;
                                goAgain = true;
                            }
                            else if (answer == "n")
                            {
                                askAgain = false;
                                goAgain = false;
                                Console.WriteLine("Good Bye!");
                            }
                           

                        }
                    }
                }
            }

        }

    }

}


