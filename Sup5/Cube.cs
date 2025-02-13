using System;
using Sup5;
namespace Supplement5;
///
/// <summary>
/// Represents a cube.
/// Inherits from the <see cref="Shape3D"/> class.
/// </summary>
public class Cube : Shape3D
{
    private double sideLength;

    /// <summary>
    /// Initializes a new instance of the Cube"/> class.
    /// </summary>
    /// <param name="sideLength">The length of the sides of the cube</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="sideLength"/> is less than or equal to 0.</exception>
    public Cube(double sideLength)
    {
        Validate(sideLength);
        this.sideLength = sideLength;
    }

    /// <summary>
    /// Validates the side length to ensure it's greater than 0
    /// </summary>
    /// <param name="sideLength">The side length of the cube to validate.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="sideLength"/> is less than or equal to 0</exception>
    private void Validate(double sideLength)
    {
        if (sideLength <= 0)
        {
            throw new ArgumentException("Side length must be greater than 0.");
        }
    }

    /// <summary>
    // /// Gets the volume of the cub
    /// </summary>
    /// <returns>The volume of the cube, calculated as the side length cubed.</returns>
    public override double GetVolume()
    {
        return Math.Pow(sideLength, 3);
    }

    /// <summary>
    /// Gets the surface area of the cube.
    /// </summary>
    /// <returns>The surface area of the cube, calculated as 6 times the square of the side length.</returns>
    public override double GetSurfaceArea()
    {
        return 6 * Math.Pow(sideLength, 2);
    }

    /// <summary>
    /// Gets a string representation of the cube with its surface area and volume.
    /// </summary>
    /// <returns>A string in the format "Shape: Cube, Surface Area: {surface area}, Volume: {volume}".</returns>
    public override string Dump()
    {
        return $"Shape: Cube, Surface Area: {GetSurfaceArea()}, Volume: {GetVolume()}";
    }
}