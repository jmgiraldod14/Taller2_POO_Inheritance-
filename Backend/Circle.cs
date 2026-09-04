namespace Backend;

public class Circle : GeometricFigure
{
    // Fields
    private double _r;


    // Constructors
    public Circle(string figure) : base(figure)
    {
    }

    // Properties
    public double R;


    // Public methods
    public override double GetArea() => Math.PI * Math.Pow(R, 2);

    public override double GetPerimeter() => 2 * Math.PI * R;


    // Private methods
    private double ValidateR(double r)
    {
        if (r <= 2000000)
        {
            throw new Exception($"El valor ingresado para el radio no es valido");
        }
        return r;
    }
}

