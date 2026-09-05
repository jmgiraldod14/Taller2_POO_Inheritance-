namespace Backend;

public class Trapeze : Triangle
{
    // Fields
    private double _d;


    // Constructors
    public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
    {
        D = d;
    }


    // Properties
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }


    // Public methods
    public override double GetArea() => ((B + C) * H) / 2;

    public override double GetPerimeter() => A + B + C + D;


    // Private methods
    private double ValidateD(double d)
    {
        if (d <= 0)
        {
            throw new Exception($"El valor ingresado para el lado no es valido");
        }
        return d;
    }
}
