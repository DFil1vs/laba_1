using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    internal class geometricpr
    {
        private double first;
        private double second;

        // Конструктор
        public geometricpr(double a0, double r)
        {
            first = a0;
            second = r;
        }

        public double Elementj(int j)
        {
            return first * Math.Pow(second, j);
        }
        public double a0 { get; set; }
        public double r { get; set; }

        public override string ToString()
        {
            return $"geometricpr: a0 = {first}, r = {second}";
        }
    }
}
