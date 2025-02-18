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

    // Method to get the shape at a specific index
    public Shape3D Get(int index)
    {
        if (index < 0 || index >= shapes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        return shapes[index];  // Return the shape at the specified index
    }
    // Method to delete the shape at a specific index
    public void Delete(int index)
    {
        if (index < 0 || index >= shapes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        shapes.RemoveAt(index);  // Remove the shape at the specified index
    }
    
    
    }
}