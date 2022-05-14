using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4Lab2_CircleLab
{
    public class Circle
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            return (2 * Math.PI * Radius);
        }

        public string CalculateFormattedCircumference()
        {
            return $"The Circumference of this circle, rounded to the nearest tenth, is {FormatNumber(CalculateCircumference())}.";
        }

        public double CalculateArea()
        {
            return (Math.PI*(Radius*Radius));
        }

        public string CalculateFormattedArea()
        {
            return $"The Area of this circle, rounded to the nearest tenth, is {FormatNumber(CalculateArea())}.";
        }

        private string FormatNumber(double x)
        {
            return String.Format("{0:0.00}", x);
        }
    }
}
