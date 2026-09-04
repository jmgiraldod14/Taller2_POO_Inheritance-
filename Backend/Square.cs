namespace Backend;

public class Square : GeometricFigure
{
    // Fields
    private double _a;


    // Constructors
    public Square(string name, double a) : base(name)
    {
        A = a;
    }


    // Properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }


    // Public methods
    public override double GetArea() => Math.Pow(A, 2);

    public override double GetPerimeter() => 4 * A;


    // Private methods
    private double ValidateA(double a)
    {
        if (a <= 2000000)
        {
            throw new Exception($"El valor ingresado para el lado no es valido");
        }
        return a;
    }
}
