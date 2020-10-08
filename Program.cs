using System;
using System.Runtime.ExceptionServices;

namespace assign_2
{
    class Program
    {
        //creating the menu.
        static public int menu()
        {
            Console.WriteLine("menu::");
            Console.WriteLine("1.Enter the triangle dimention");
            Console.WriteLine("2.Exit");
            var a = Console.ReadLine();
            return Convert.ToInt32(a);
        }
        public static void Main(string[] args)
        {
            //calling that menu.
            var a = menu();
            //int user_input = 0;
            if (a == 1)
            {
                do
                {
                    //user_input = menu();
                    string triangle;

                    int sidea, sideb, sidec;
                    //get the input from the user.
                    Console.Write("Check whether a triangle is Equilateral, Isosceles or Scalene:\n");

                    Console.Write("Input side 1 of triangle: ");
                    sidea = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Input side 2 of triangle: ");
                    sideb = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Input side 3 of triangle: ");
                    sidec = Convert.ToInt32(Console.ReadLine());
                    //logic for checking the user enter the correct details or not 
                    if ( (sidea + sideb + sidec)  == 180)
                    {
                        Console.WriteLine("the triangle is valid");
                        //calling the trianglesolver class to main class for checking the triangle.
 
                        triangle = TriangleSolver.Analyze(sidea, sideb, sidec);
                        Console.WriteLine(triangle);
                        
                    }
                    else
                    {
                        Console.WriteLine("the triangle is not valid");
                    }


                    menu();

                } while (a > 1);
            }
                Console.WriteLine("exit...");
            
        }
    }
}
