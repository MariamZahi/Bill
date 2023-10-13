using System;

public class TipCalculator
{
    public decimal CalculateTipPerPerson(decimal totalPrice, int numberOfPatrons, float tipPercentage)
    {
        public Dictionary<string, decimal> CalculateTipForEachPerson(Dictionary<string, decimal> mealCosts, float tipPercentage)
    {
        if (mealCosts == null || mealCosts.Count == 0 || tipPercentage < 0)
        {
            throw new ArgumentException("Invalid input values.");
        }

        decimal totalCost = 0;
        foreach (var cost in mealCosts.Values)
        {
            totalCost += cost;
        }

        decimal totalTip = totalCost * (decimal)(tipPercentage / 100);
        decimal tipPerPerson = totalTip / mealCosts.Count;

        Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();
        foreach (var pair in mealCosts)
        {
            decimal tip = pair.Value * (decimal)(tipPercentage / 100);
            tipAmounts[pair.Key] = tipPerPerson + tip;
        }

        return tipAmounts;
    }
}
        if (totalPrice <= 0 || numberOfPatrons <= 0 || tipPercentage < 0)
        {
            throw new ArgumentException("Invalid input values.");
        }

        decimal totalTip = totalPrice * (decimal)(tipPercentage / 100);
        decimal tipPerPerson = totalTip / numberOfPatrons;

        return tipPerPerson;
    }