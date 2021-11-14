using System;
using System.Collections.Generic;
using System.Text;

namespace CurvePoint
{
    class Point
    {
        public int xpoint;
        public int ypoint;

        public Point() { }

        public Point(int xpoint, int ypoint)
        {
            this.xpoint = xpoint;
            this.ypoint = ypoint;

        }

     
        public int X_Point
        {
            get 
            { 
                return xpoint; 
            }
            set 
            { 
                xpoint = value; 
            }
        }

        public int Y_Point
        {
            get 
            { 
                return ypoint; 
            }
            set 
            { 
                ypoint = value; 
            }
        }

    }
}
