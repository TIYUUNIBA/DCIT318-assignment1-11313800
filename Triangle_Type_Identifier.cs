using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Triangle Type Identifier");
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");
        
        // Get user input for three sides
        Console.Write("Side 1: ");
        double side1 = double.Parse(Console.ReadLine());
        
        Console.Write("Side 2: ");
        double side2 = double.Parse(Console.ReadLine());
        
        Console.Write("Side 3: ");
        double side3 = double.Parse(Console.ReadLine());
        
        // Validate triangle inequality theorem
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            // Determine triangle type
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This is an Equilateral triangle (all sides equal).");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("This is an Isosceles triangle (two sides equal).");
            }
            else
            {
                Console.WriteLine("This is a Scalene triangle (no sides equal).");
            }
        }
        else
        {
            Console.WriteLine("Error: These side lengths cannot form a valid triangle.");
            Console.WriteLine("The sum of any two sides must be greater than the third side.");
        }
    }
}