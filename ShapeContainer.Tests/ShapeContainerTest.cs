namespace Supplement5.Tests{
    public class ShapeContainertest
{
       [Fact]
    public void ShouldAddShapesToList()
    {
        // Create the container and multiple shapes
        var container = new ShapeContainer();
        var shape1 = new Cube(3);       
        var shape2 = new Sphere(3);    
        var shape3 = new Cylinder(3, 5); 

        // Act: Add shapes to the container
        container.Create(shape1);
        container.Create(shape2);
        container.Create(shape3);

        // Assert: Verify that the shapes were added correctly
        Assert.Equal(shape1, container.Get(0));  // The first shape should be the Cube
        Assert.Equal(shape2, container.Get(1));  // The second shape should be the Sphere
        Assert.Equal(shape3, container.Get(2));  // The third shape should be the Cylinder
    }

    }
}

