namespace Supplement5.Tests{
    
    
    
    
    
    public class Spheretest
{
    [Fact]
    public void Spheretester()

    {
    
            Sphere sphere = new Sphere(3);

            double volume = sphere.GetVolume();

            
            Assert.Equal(4.18879, volume, 5); 

    }

     [Fact]
        public void SphereSurfaceAreaTest()
        {
        
            Sphere sphere = new Sphere(3);

            
            double surfaceArea = sphere.GetSurfaceArea();

            Assert.Equal(113.097, surfaceArea, 3);  
        }

       [Fact]
        public void SphereValidateTest()
        {
            // Assert that an exception is thrown when radius <= 0
            Assert.Throws<ArgumentException>(() => new Sphere(0));
            Assert.Throws<ArgumentException>(() => new Sphere(-5));
        }
        [Fact]
        public void SphereDumpTest()
        {
            // Arrange
            Sphere sphere = new Sphere(3);
            string expected = "Shape: Sphere, Surface Area: 113.097, Volume: 4.18879";

            // Act
            string dump = sphere.Dump();

            // Assert
            Assert.Equal(expected, dump);
            
        }
    }
}


