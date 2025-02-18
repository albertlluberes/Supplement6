namespace Sup5
{

    public class ShapeContainer
{
    private List<Shape3D> shapes = new List<Shape3D>();

    // Method to add a shape to the container
    public void Create(Shape3D shape)
    {
        if (shape == null)
        {
            throw new ArgumentNullException(nameof(shape), "Shape cannot be null.");
        }
        shapes.Add(shape);  // Add the shape to the list
    }
    
    
    }
}