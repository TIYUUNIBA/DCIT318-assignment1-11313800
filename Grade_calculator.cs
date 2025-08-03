using System;

class GradeCalculator
{
    static void Main()
    {
        // Prompt the user for a numerical grade
        Console.Write("Enter the numerical grade (0-100): ");
        
        // Read input and try to parse it as a double
        if (double.TryParse(Console.ReadLine(), out double grade))
        {
            // Validate the input
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Error: Grade must be between 0 and 100");
            }
            else
            {
                // Determine the letter grade
                string letterGrade;
                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }
                
                // Display the result
                Console.WriteLine($"The letter grade for {grade} is {letterGrade}");
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid number");
        }
    }
}