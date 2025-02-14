using Sup5;

namespace Supplement5
{
    /// <summary>
    /// Represent 3d cylinder,inheriting from Shape3D
    /// </summary>
    public class Cylinder : Shape3D
    {
        private double radius;
        private double height;
/// <summary>
/// Initializes a new instance of cylinder class with a specified radius and height.
/// </summary>
/// <param name="radius">Must be greater than 0</param>
/// <param name="height">Must be greater than 0</param>
        public Cylinder(double radius, double height)
        {
            Validate(radius, height);
            this.radius = radius;
            this.height = height;
        }
/// <summary>
/// will validate that radius and height are greater than 0
/// </summary>
/// <param name="radius"></param>
/// <param name="height"></param>
/// <exception cref="ArgumentException"></exception>
        private void Validate(double radius, double height)
        {
            if (radius <= 0 || height <= 0)
            {
                throw new ArgumentException("Radius and height must be greater than 0.");
            }
        }
/// <summary>
/// Calculates the volume of the cylinder
/// </summary>
/// <returns>The volume of the cylinder</returns>
        public override double GetVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public override double GetSurfaceArea()
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2);
        }
/// <summary>
/// Returns a formatted string containing the shape type, surface area, and volume
/// </summary>
/// <returns></returns>
        public override string Dump()
        {
            return $"Shape: Cylinder, Surface Area: {GetSurfaceArea():F5}, Volume: {GetVolume():F5}";
        }
    }
}
