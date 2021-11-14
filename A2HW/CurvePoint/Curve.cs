using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CurvePoint
{

    class Curve
    {
        // Generic list that stores all the points

        public List<Point> PointList = new List<Point>();


        //Helper method for distance calculation
        public double DistanceCalculator(int v1, int v2)
        {

            var fi = PointList.ElementAt(v1);
            var si = PointList.ElementAt(v2);

            double dis = Math.Sqrt(Math.Pow((si.xpoint - fi.xpoint), 2) + Math.Pow((si.ypoint - fi.ypoint), 2));

            return dis;

        }

        //Calculates the length of given 2 points
        public double Length
        {

            get
            {
                Console.WriteLine("To calculate length please enter two points by their position \n");
                PrintPoints();
                Console.WriteLine();
                Console.Write("Please enter the first point position :");
                int pi = int.Parse(Console.ReadLine());
                Console.Write("Please enter the second point position :");
                int pj = int.Parse(Console.ReadLine());

                Console.Write("Distance Between Point : {0} and Point : {1} is: ", pi, pj);

                return DistanceCalculator(pi, pj);
            }
            set
            {
                
            }


        }


        //Calculates the Curve Length
        public double CurveLength()
        {
            double cLength = 0;

            for (int i = 0; i < PointList.Count - 1; i++)
            {

                cLength += DistanceCalculator(i, i + 1);

            }

            Console.WriteLine("The Curve Lenth is:");

            return cLength;
        }

        

        //Points Printer Method

        public void PrintPoints()
        {


            Console.WriteLine("--------------- POINTS --------------");
            Console.WriteLine("                                                      ");

            foreach (var points in PointList)
            {
                int index = PointList.IndexOf(points);
                Console.WriteLine(index + ".index ----->" + "Points: {0},{1}",
                                  points.X_Point, points.Y_Point);
            }


        }


        // Points remover method
        public void RemovePoints()
        {
            Console.WriteLine("----- Please enter the index you want to delete -----");
            Console.WriteLine("                                                       ");
            PrintPoints();
            int remove = int.Parse(Console.ReadLine());
            PointList.RemoveAt(remove);

        }

        // Point adder method
        public void AddPoints()
        {


            Console.Write("Please enter X :");

            int x = int.Parse(Console.ReadLine());

            Console.Write("Please enter Y :");

            int y = int.Parse(Console.ReadLine());

            PointList.Add(new Point(x, y));


        }

    }

}
