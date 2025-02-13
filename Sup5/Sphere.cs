using System;
using Sup5;
namespace Supplement5;

public class Sphere : Shape3D
{
    private double radius;

  
    public Sphere(double radius)
    {
        Validate(radius);
        this.radius = radius;
    }

    private void Validate(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than 0.");
        }
    }

   
    public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }

    
    public override double GetSurfaceArea()
    {
        return 4 * Math.PI * Math.Pow(radius, 2);
    }

    public override string Dump()
{
    return $"Shape: Sphere, Surface Area: {GetSurfaceArea():F5}, Volume: {GetVolume():F5}";
}
}