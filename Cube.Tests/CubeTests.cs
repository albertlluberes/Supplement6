namespace Supplement5.Tests
{
    public class CubeTests
    {
        [Fact]
        public void CubeTest()
        {
            Cube cube = new Cube(3);  
            Assert.Equal(27, cube.GetVolume(), 0.001);
        }

        [Fact]
        public void TestCubeSurfaceArea()
        {
            Cube cube = new Cube(3);
            Assert.Equal(54, cube.GetSurfaceArea(), 0.001);
        }

        [Fact]
        public void TestCubeValidation()
        {
            Assert.Throws<ArgumentException>(() => new Cube(0));
        }

        [Fact]
        public void TestCubeDump()
        {
            Cube cube = new Cube(3);
            string expected = "Shape: Cube, Surface Area: 54, Volume: 27";
            Assert.Equal(expected, cube.Dump());
        }
    }
}