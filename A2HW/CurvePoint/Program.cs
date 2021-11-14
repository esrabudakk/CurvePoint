using System;

namespace CurvePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Curve curve = new Curve();


            bool exit = true;
            while (exit)
            {
                Console.WriteLine("                                                       ");
                Console.WriteLine("------------------- PLEASE SELECT OPERATION -------------------");
                Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''");
                Console.WriteLine("xoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxox");
                Console.WriteLine("-------------------- ADD POINTS    -----------------------> (a)");
                Console.WriteLine("-------------------- REMOVE POINTS -----------------------> (r)");
                Console.WriteLine("-------------------- PRINT POINTS  -----------------------> (p)");
                Console.WriteLine("-------------------- LENGTH BETWEEN TWO POINTS  ----------> (l)");
                Console.WriteLine("-------------------- CURVE LENGTH  -----------------------> (c)");
                Console.WriteLine("-------------------- EXIT  -------------------------------> (e)");
                Console.WriteLine("xoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxoxox");
                Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''");
               

                string home = Console.ReadLine();

                switch (home)
                {
                    case "a":
                        curve.AddPoints();
                        break;

                    case "r":
                        curve.RemovePoints();
                        break;

                    case "p":
                        curve.PrintPoints();
                        break;

                    case "l":
                        double a = (double)curve.Length;
                        Console.WriteLine(a);
                        break;

                    case "c":
                        Console.WriteLine(curve.CurveLength());
                        break;
                    
                    case "e":
                    default:
                        exit = false;
                        break;
                }
            }

            Console.ReadKey();
        }

    }
}

