public class Circle 
{
    public double Radius;
    public double Circumference;
    public double Area;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateCircumference()
    {
        return Circumference;
    }

    public string CalculateFormattedCircumference()
    {
        return "";
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