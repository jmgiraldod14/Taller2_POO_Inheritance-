namespace Backend;

public abstract class GeometricFigure
{
    // Constructors
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    // Properties
    public string Name { get; set; }

    // Public Methods
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),12:N5}      Perimeter: {GetPerimeter(),12:F5}";
    }
}
