// See https://aka.ms/new-console-template for more information
using Sup5;
using System;
using System.Collections.Generic;
namespace Supplement5{

        class Program
    {
        static void Main(string[] args)
        {
           
            ShapeContainer container = new ShapeContainer();
            string input;

            Console.WriteLine("Welcome to my Shape3D Creator");
            Console.WriteLine("You can create, get, and delete shapes.");
            Console.WriteLine("Available commands for user are: create, retrieve, delete,  orr exit");

            // REPL loop
            while (true)
            {
                Console.WriteLine("\nEnter a command (create, get, delete, exit):");
                input = Console.ReadLine().Trim().ToLower();

                if (input == "exit")
                {
                    break;
                }

                if (input == "create")
                {
                    CreateShape(container);
                }
                else if (input == "get")
                {
                    GetShape(container);
                }
                else if (input == "delete")
                {
                    DeleteShape(container);
                }
                else
                {
                    Console.WriteLine("Invalid command! Please enter 'create', 'get', 'delete', or 'exit'.");
                }
            }

            Console.WriteLine("\nThanks for participating! Goodbye!");
        }

        static void CreateShape(ShapeContainer container)
        {
            Console.WriteLine("\nEnter the shape type (Cube, Sphere, Cylinder):");
            string shapeType = Console.ReadLine().Trim().ToLower();
            Shape3D shape = null;

            try
            {
                if (shapeType == "cube")
                {
                    Console.WriteLine("Enter the side length for the Cube:");
                    double sideLength = double.Parse(Console.ReadLine());
                    shape = new Cube(sideLength);
                }
                else if (shapeType == "sphere")
                {
                    Console.WriteLine("Enter the radius for the Sphere:");
                    double radius = double.Parse(Console.ReadLine());
                    shape = new Sphere(radius);
                }
                else if (shapeType == "cylinder")
                {
                    Console.WriteLine("Enter the radius for the Cylinder:");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height for the Cylinder:");
                    double height = double.Parse(Console.ReadLine());
                    shape = new Cylinder(radius, height);
                }
                else
                {
                    Console.WriteLine("Invalid shape type! Please try again.");
                    return;
                }

                // Add shape to container and print details
                container.Create(shape);
                Console.WriteLine("Shape created and added to container:");
                Console.WriteLine(shape.Dump());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter valid numerical values.");//if input is invalid
            }
        }

        static void GetShape(ShapeContainer container)
        {
            Console.WriteLine("\nEnter the index of the shape to retrieve:");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                try
                {
                    Shape3D shape = container.Get(index);
                    Console.WriteLine("Retrieved shape:");
                    Console.WriteLine(shape.Dump());
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Invalid index! No shape exists at this index.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid index number.");
            }
        }

        static void DeleteShape(ShapeContainer container)
        {
            Console.WriteLine("\nEnter the index of the shape to delete:");//deletes the shape fucntion
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                try
                {
                    container.Delete(index);
                    Console.WriteLine("Shape successfully deleted.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Invalid index! No shape exists at this index.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid index number.");
            }
        } 
    

    }
}