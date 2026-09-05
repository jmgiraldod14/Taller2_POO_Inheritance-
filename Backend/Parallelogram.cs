namespace Backend;

public class Parallelogram : Rectangle
{
    // Fields
    private double _h;


    // Constructors
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }


    // Properties
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }


    // Public methods
    public override double GetArea() => B * H;

    public override double GetPerimeter() => 2 * (A + B);


    // Private methods
    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new Exception($"El valor ingresado para el lado no es valido");
        }
        return h;
    }
}
