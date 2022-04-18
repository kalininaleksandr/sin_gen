using System;
using System.Collections.Generic;
using System.Text;

namespace sin_gen
{
    class Sin
    {
        public int amp, numPoints;
        double[,] points;
        double freq;
        public Sin()
        {
            Console.WriteLine("Введите значение амплитуды: ");
            amp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение частоты: ");
            freq = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество рассчитываемых координат: ");
            numPoints = Convert.ToInt32(Console.ReadLine());

        }
        public void calcPoints()
        {
            double j = 0.0;
            points = new double[numPoints,2];
            for (int i = 0; i < numPoints; i++)
            {
                points[i, 0] = Math.Round(j,2);
                points[i, 1] = Math.Round(amp * Math.Sin(2 * Math.PI * freq * j), 2);
                j += 0.1;
            }
        }
        public void showPoints()
        {
            Console.WriteLine("x    #y  ");
            for (int i = 0; i < numPoints; i++)
            {
                Console.WriteLine(points[i,0] + "  #" + "   " + points[i, 1]);
            }
        }

    }
}
