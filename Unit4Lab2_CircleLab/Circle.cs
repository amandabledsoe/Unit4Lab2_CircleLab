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

        public string CalculateFormattedCircumference()
        {
            return $"The Circumference of this circle is {CalculateCircumference()}";
        }

        public double CalculateArea()
        {
            return (Math.PI*(Radius*Radius));
        }

        public string CalculateFormattedArea()
        {
            return $"The Area of this circle is {CalculateArea()}";
        }

        private string FormatNumber(double x)
        {
            return x.ToString();
        }
    }
}
