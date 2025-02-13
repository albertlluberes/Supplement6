namespace Sup5;

public abstract class Shape3D
{
/// <summary>
/// This will calculate and returns the volume of the shape
/// </summary>
    public abstract double GetVolume();

      /// <summary>
   /// This will calculate and returns the Surface area of the shape
   /// </summary>
   /// <returns></returns>
    public abstract double GetSurfaceArea();
/// <summary>
/// /// <summary>
/// This will returns a string identifying the shape name, surface area, and volume
/// </summary>
/// </summary>
/// <returns></returns>
    public abstract string Dump();
}
