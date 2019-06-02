using System;
using System.Collections.Generic;

namespace CalculationChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatures temps = new Temperatures();

            for (int i = 0; i < 101; i++)
            {
                Random random = new Random();
                int rTemp = random.Next(0, 100);
                temps.Insert(rTemp);
                temps.Print();
                
            }
            Console.ReadKey();
        }
    }

    class Temperatures
    {
        private List<int> temps = new List<int>();
        private int min = 100;
        private int max = 0;
        private double avg = 0;
        private int count = 0;
        public void Insert(int temp)
        {
            count++;
            if (temp < min)
            {
                min = temp;
            }

            if (temp > max)
            {
                max = temp;
            }

            avg = ((avg * (count - 1)) + temp) / count;

            temps.Add(temp);
        }

        public void Print()
        {
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Avg: " + avg);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("*******************");
        }
    }
}
