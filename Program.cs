using System;

class Program
{
    static void Main(string[] args)
    {
        // Constants
        const double SANDWICH_COST = 4.75;
        const double TOPPING_COST = 0.55;
        const double DISCOUNT = 0.10; // 10% discount

        // Get the number of sandwiches
        Console.Write("How many sandwiches? ");
        int numberOfSandwiches = int.Parse(Console.ReadLine());

        // Get the number of toppings
        Console.Write("How many total toppings? ");
        int numberOfToppings = int.Parse(Console.ReadLine());

        // Get the tip percentage
        Console.Write("What is the tip (as a decimal)? ");
        double tipPercentage = double.Parse(Console.ReadLine());

        // Calculate the costs
        double totalSandwichCost = numberOfSandwiches * SANDWICH_COST;
        double totalToppingCost = numberOfToppings * TOPPING_COST;
        double baseCost = totalSandwichCost + totalToppingCost;
        double discountAmount = baseCost * DISCOUNT;
        double discountedCost = baseCost - discountAmount;
        double tipAmount = discountedCost * tipPercentage;
        double finalOrderCost = discountedCost + tipAmount;

        // Output the final total order cost
        Console.WriteLine($"\nTotal Order Cost: ${finalOrderCost:F2}");
    }
}
