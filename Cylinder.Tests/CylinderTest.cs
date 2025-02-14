using System;
using Xunit;
using Sup5;

namespace Supplement5.Tests
{
    public class CylinderTests
    {
        [Fact]
        public void Cylinder_ValidateTest()
        {
            // Ensures the constructor throws exceptions for invalid values
            Assert.Throws<ArgumentException>(() => new Cylinder(0, 5));
            Assert.Throws<ArgumentException>(() => new Cylinder(3, 0));
            Assert.Throws<ArgumentException>(() => new Cylinder(-3, 5));
            Assert.Throws<ArgumentException>(() => new Cylinder(3, -5));
        }

        [Fact]
        public void Cylinder_VolumeTest()
        {
            // Arrange
            Cylinder cylinder = new Cylinder(3, 5);

            // Act
            double volume = cylinder.GetVolume();

            // Assert
            Assert.Equal(141.37167, volume, 5);  // Volume = π * r² * h
        }

         [Fact]
        public void Cylinder_SurfaceAreaTest()
        {
            
            Cylinder cylinder = new Cylinder(3, 5);

            
            double surfaceArea = cylinder.GetSurfaceArea();

            
            Assert.Equal(150.79645, surfaceArea, 5); // Surface Area = 2πrh + 2πr²
        }

        [Fact]
        public void Cylinder_DumpTest()
        {
            
            Cylinder cylinder = new Cylinder(3, 5);
            string expected = "Shape: Cylinder, Surface Area: 150.79645, Volume: 141.37167";

            
            string dump = cylinder.Dump();

            
            Assert.Equal(expected, dump);
        }

    }
}