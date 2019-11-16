using System;
using System.Collections.Generic;
using System.Text;

namespace Flood_Fill__test_
{
    class FloodFill
    {
        public static void LinesAtDiffAngl(float StartX, float StartY, float r1, float r2, int angle, int n)
        {
            double dA = n * Math.PI / 180;
            double angrad = angle * Math.PI / 180;
            string lasermode = "ModeStruct";
            while (angrad < 1.99 * Math.PI)
            {
                //Coordinates of a Line
                double cos = Math.Cos(angrad);
                double sin = Math.Sin(angrad);
                double x0 = r1 * cos + StartX;
                double y0 = r1 * sin + StartY;
                double x1 = r2 * cos + StartX;
                double y1 = r2 * sin + StartY;
                //Round
                x0 = Math.Round(x0, 3, MidpointRounding.ToEven);
                y0 = Math.Round(y0, 3, MidpointRounding.ToEven);
                x1 = Math.Round(x1, 3, MidpointRounding.ToEven);
                y1 = Math.Round(y1, 3, MidpointRounding.ToEven);
                //Coverting to String
                string newX0;
                newX0 = Convert.ToString(x0);
                string newY0;
                newY0 = Convert.ToString(y0);
                string newX1;
                newX1 = Convert.ToString(x1);
                string newY1;
                newY1 = Convert.ToString(y1);
                //Replacing "," by "."
                newX0 = newX0.Replace(',', '.');
                newY0 = newY0.Replace(',', '.');
                newX1 = newX1.Replace(',', '.');
                newY1 = newY1.Replace(',', '.');
                Console.WriteLine("Line({0},{1},{2},{3},{4})", newX0, newY0, newX1, newY1,lasermode);
                angrad += dA;
            }
        }
        public static void LinesAtConstatAngle (float StartX, float StartY, float r1, float r2, int fillingagle, int n)
        {
            double dA = n * Math.PI / 180;
            double farad = fillingagle * Math.PI / 180;
            while (dA<2* Math.PI)
            {
                //Coordinates of a Line
                double cos0 = Math.Cos(dA);
                double sin0 = Math.Sin(dA);
                double cos1 = Math.Cos(dA + farad);
                double sin1 = Math.Sin(dA + farad);
                double x0 = r1 * cos0 + StartX;
                double y0 = r1 * sin0 + StartY;
                double x1 = r2 * cos1 + StartX;
                double y1 = r2 * sin1 + StartY;
                //Round
                x0 = Math.Round(x0, 3, MidpointRounding.ToEven);
                y0 = Math.Round(y0, 3, MidpointRounding.ToEven);
                x1 = Math.Round(x1, 3, MidpointRounding.ToEven);
                y1 = Math.Round(y1, 3, MidpointRounding.ToEven);
                //Coverting to String
                string newX0;
                newX0 = Convert.ToString(x0);
                string newY0;
                newY0 = Convert.ToString(y0);
                string newX1;
                newX1 = Convert.ToString(x1);
                string newY1;
                newY1 = Convert.ToString(y1);
                //Replacing "," by "."
                newX0 = newX0.Replace(',', '.');
                newY0 = newY0.Replace(',', '.');
                newX1 = newX1.Replace(',', '.');
                newY1 = newY1.Replace(',', '.');
                Console.WriteLine("Line({0},{1},{2},{3}", newX0, newY0, newX1, newY1);
                dA += dA;
            }
        }
    }
}
