namespace Supplement5.Tests{
    public class ShapeContainerTests
{
    [Fact]
    public void AddMultipleShapesToList()
    {
        // Arrange: Create the container and multiple shapes
        var container = new ShapeContainer();
        var shape1 = new Cube(3);       
        var shape2 = new Sphere(3);    
        var shape3 = new Cylinder(3, 5); 

        // Act: Add shapes to the container using Create method
        container.Create(shape1);
        container.Create(shape2);
        container.Create(shape3);

        // Assert: Verify that the shapes were added correctly
        Assert.Equal(shape1, container.Get(0));  // The first shape should be the Cube
        Assert.Equal(shape2, container.Get(1));  // The second shape should be the Sphere
        Assert.Equal(shape3, container.Get(2));  // The third shape should be the Cylinder
    }
    [Fact]
   public void Get_SpecificIndex()
    {
        // Arrange: Set up shapes and add them
        var container = new ShapeContainer();
        var shape1 = new Cube(3);
        var shape2 = new Sphere(5);
        container.Create(shape1);
        container.Create(shape2);

        // Act: Retrieve a shape at index 1
        var retrievedShape = container.Get(1);

        // Assert: Check if the retrieved shape is the Sphere
        Assert.Equal(shape2, retrievedShape);
    }


    [Fact]
    public void Delete_fromIndex()
    {
        // Arrange: Set up a container and add a shape
        var container = new ShapeContainer();
        var shape = new Cylinder(3, 7);
        container.Create(shape);

        // Act: Delete the shape at index 0
        container.Delete(0);

        // Assert: Verify that shape is deleted
        Assert.Throws<ArgumentOutOfRangeException>(() => container.Get(0));  // Trying to get it should throw an exception
    }
}
}

