namespace Supplement5.Tests{
    
    
    
    
    
    public class Spheretest
{
    [Fact]
public void Spheretester()
{
    
    Sphere sphere = new Sphere(3);

    
    double volume = sphere.GetVolume();

    
    Console.WriteLine($"Calculated Volume: {volume}");


    Assert.Equal(113.09734, volume, 5);
}
     [Fact]
        public void SphereSurfaceAreaTest()
        {
        
            Sphere sphere = new Sphere(3);

            
            double surfaceArea = sphere.GetSurfaceArea();

            Assert.Equal(113.09734, surfaceArea, 5);  
        }

       [Fact]
        public void SphereValidateTest()
        {
            
            Assert.Throws<ArgumentException>(() => new Sphere(0));
            Assert.Throws<ArgumentException>(() => new Sphere(-5));
        }
   [Fact]
public void SphereDumpTest()
{
    // Arrange
    Sphere sphere = new Sphere(3);
    string expected = "Shape: Sphere, Surface Area: 113.09734, Volume: 113.09734"; 

    // Act
    string dump = sphere.Dump();
    Console.WriteLine($"Actual Dump Output: {dump}");

    // Assert
    Assert.Equal(expected, dump);
}
    }
}


