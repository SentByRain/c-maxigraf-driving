using System;

namespace Flood_Fill__test_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Flood Fill do you wanna use? (ADA/ACA");
            string an0 = Console.ReadLine();
            string ADA = "ADA";
            if (an0 == ADA)
            {
                string an1;
                Console.WriteLine("StartX");
                an1 = Console.ReadLine();
                float anc1 = Convert.ToSingle(an1);

                string an2;
                Console.WriteLine("StartY");
                an2 = Console.ReadLine();
                float anc2 = Convert.ToSingle(an2);

                string an3;
                Console.WriteLine("R1");
                an3 = Console.ReadLine();
                float anc3 = Convert.ToSingle(an3);

                string an4;
                Console.WriteLine("R2");
                an4 = Console.ReadLine();
                float anc4 = Convert.ToSingle(an4);

                string an5;
                Console.WriteLine("Angle");
                an5 = Console.ReadLine();
                int anc5 = Convert.ToInt32(an5);

                string an6;
                Console.WriteLine("DeltaAngle");
                an6 = Console.ReadLine();
                int anc6 = Convert.ToInt32(an6);

                string k;
                Console.WriteLine("Amout of Up&Down Rows");
                k = Console.ReadLine();
                int knew = Convert.ToInt32(k);

                int rows_amount = 1;
                do
                {
                    Rows.UpRow(anc1, anc2, anc3, anc4, anc5, anc6);
                    double sqr = Math.Sqrt(3);
                    float sqrt = (float)sqr;
                    anc1 += anc4;
                    anc2 -= anc4 * sqrt;
                    Rows.DownRow(anc1, anc2, anc3, anc4, anc5, anc6);
                    anc1 += anc4;
                    anc2 -= anc4 * sqrt;
                    rows_amount++;
                }
                while (rows_amount <= knew);
            }
            else
            {
                string an1;
                Console.WriteLine("StartX");
                an1 = Console.ReadLine();
                float anc1 = Convert.ToSingle(an1);

                string an2;
                Console.WriteLine("StartY");
                an2 = Console.ReadLine();
                float anc2 = Convert.ToSingle(an2);

                string an3;
                Console.WriteLine("R1");
                an3 = Console.ReadLine();
                float anc3 = Convert.ToSingle(an3);

                string an4;
                Console.WriteLine("R2");
                an4 = Console.ReadLine();
                float anc4 = Convert.ToSingle(an4);

                string an5;
                Console.WriteLine("FillAngle");
                an5 = Console.ReadLine();
                int anc5 = Convert.ToInt32(an5);

                string an6;
                Console.WriteLine("AmountOfLines");
                an6 = Console.ReadLine();
                int anc6 = Convert.ToInt32(an6);

                string k;
                Console.WriteLine("Amout of Up&Down Rows");
                k = Console.ReadLine();
                int knew = Convert.ToInt32(k);

                int rows_amount = 1;
                do
                {
                    Rows.UpRow(anc1, anc2, anc3, anc4, anc5, anc6);
                    double sqr = Math.Sqrt(3);
                    float sqrt = (float)sqr;
                    anc1 += anc4;
                    anc2 -= anc4 * sqrt;
                    Rows.DownRow(anc1, anc2, anc3, anc4, anc5, anc6);
                    anc1 += anc4;
                    anc2 -= anc4 * sqrt;
                    rows_amount++;
                }
                while (rows_amount <= knew);

            }
        }
    }
}
