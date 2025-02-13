using System;
using Sup5;
namespace Supplement5;
/// <summary>
/// Main class that inherits from Shape3D
/// </summary>
public class Sphere : Shape3D
{
    private double radius;

  /// <summary>
  /// Creates a sphere class with radius
  /// </summary>
  /// <param name="radius">radius must be greater than 0</param>
    public Sphere(double radius)
    {
        Validate(radius);
        this.radius = radius;
    }
    /// <summary>
    ///  Validates the radius value to make sure it is greater than 0
    /// </summary>
    /// <param name="radius"></param>
    /// <exception cref="ArgumentException"></exception>

    private void Validate(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than 0.");
        }
    }

   /// <summary>
   /// Equation for the volume
   /// </summary>
   /// <returns>The volume</returns>
    public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }

    /// <summary>
    /// Equation for Getsurface 
    /// </summary>
    /// <returns>surface area of given 3d shape</returns>
    public override double GetSurfaceArea()
    {
        return 4 * Math.PI * Math.Pow(radius, 2);
    }
/// <summary>
///  Returns a formatted string representation of the sphere
/// </summary>
/// <returns>string describing the sphere with its surface area and volume</returns>
    public override string Dump()
{
    return $"Shape: Sphere, Surface Area: {GetSurfaceArea():F5}, Volume: {GetVolume():F5}";
}
}