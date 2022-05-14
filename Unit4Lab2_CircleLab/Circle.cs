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
        public double Circumference;
        public double Area;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            return (2 * Math.PI * Radius);
        }

        public string CalculateFormattedCircumference(Circle thisCircle)
        {
            return $"The Circumference is {CalculateCircumference()}";
        }

        public double CalculateArea()
        {
            return Area;
        }

        public string CalculateFormattedArea()
        {
            return "";
        }

        private string FormatNumber(double x)
        {
            return x.ToString();
        }
    }
}
