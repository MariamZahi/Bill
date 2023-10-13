using System;

public class SplitAmountCalculator
{
    public double CalculateSplitAmount(double totalAmount, int numberOfPeople, double[] weights)
    {
        if (numberOfPeople <= 0)
        {
            throw new ArgumentException("Number of people must be greater than zero.");
        }

        if (totalAmount <= 0)
        {
            throw new ArgumentException("Total amount must be greater than zero.");
        }

        if (weights == null || weights.Length != numberOfPeople)
        {
            throw new ArgumentException("Invalid weights array. It must have the same length as the number of people.");
        }

        double totalWeight = 0;
        foreach (var weight in weights)
        {
            if (weight < 0)
            {
                throw new ArgumentException("Weights must be non-negative values.");
            }
            totalWeight += weight;
        }

        if (totalWeight == 0)
        {
            throw new InvalidOperationException("Sum of weights cannot be zero.");
        }

        double weightedAverage = 0;
        for (int i = 0; i < numberOfPeople; i++)
        {
            weightedAverage += (weights[i] / totalWeight) * totalAmount;
        }

        return weightedAverage;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage of the CalculateSplitAmount method
        double totalAmount = 100.00; // Total amount in currency
        int numberOfPeople = 5; // Number of people splitting the amount
        double[] weights = { 1, 2, 1, 1, 1 }; // Example weights for each person

        SplitAmountCalculator calculator = new SplitAmountCalculator();
        double splitAmount = calculator.CalculateSplitAmount(totalAmount, numberOfPeople, weights);

        Console.WriteLine($"Total Amount: {totalAmount:C}");
        Console.WriteLine($"Number of People: {numberOfPeople}");
        Console.WriteLine($"Weights: {string.Join(", ", weights)}");
        Console.WriteLine($"Split Amount per Person: {splitAmount:C}");
    }
}