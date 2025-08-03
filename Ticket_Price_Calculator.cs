using System;

class TicketPriceCalculator
{
    static void Main()
    {
        const double standardPrice = 10.0;
        const double discountedPrice = 7.0;
        
        // Prompt user for age
        Console.Write("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        
        // Calculate ticket price
        double price;
        if (age <= 12 || age >= 65)
        {
            price = discountedPrice;
            Console.WriteLine($"You qualify for the discounted price: GHC{price}");
        }
        else
        {
            price = standardPrice;
            Console.WriteLine($"Your ticket price is: GHC{price}");
        }
    }
}