using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                byte a;
                a = 25;
                int b = a;
                short d;
                d = 2500;
                double c = d;
                uint r;
                r = 1500456U;
                long t = r;
                {
                    float i = 56.56F;
                    double o = (double)i;
                    double p = 9876433;
                    decimal l = (decimal)p;
                    ulong h = 45UL;
                    double e = (double)h;
                }

                Console.WriteLine("Преобразования верны");
            }
        }


    }
}