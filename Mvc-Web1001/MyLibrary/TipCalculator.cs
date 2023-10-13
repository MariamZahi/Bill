using System;

public class TipCalculator
{
    public decimal CalculateTipPerPerson(decimal totalPrice, int numberOfPatrons, float tipPercentage)
    {
        if (totalPrice <= 0 || numberOfPatrons <= 0 || tipPercentage < 0)
        {
            throw new ArgumentException("Invalid input values.");
        }

        decimal totalTip = totalPrice * (decimal)(tipPercentage / 100);
        decimal tipPerPerson = totalTip / numberOfPatrons;

        return tipPerPerson;
    }
}