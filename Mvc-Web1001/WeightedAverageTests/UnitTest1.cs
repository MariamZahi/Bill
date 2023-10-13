using System;
using System.Collections.Generic;
using Xunit;

public class TipCalculatorTests
{
    [Fact]
    public void CalculateTipPerPerson_ValidInput_ShouldReturnCorrectAmount()
    {
        // Arrange
        var calculator = new TipCalculator();
        decimal totalPrice = 100.0m;
        int numberOfPatrons = 4;
        float tipPercentage = 15.0f;

        // Act
        var tipPerPerson = calculator.CalculateTipPerPerson(totalPrice, numberOfPatrons, tipPercentage);

        // Assert
        Assert.Equal(3.75m, tipPerPerson);
    }

    [Fact]
    public void CalculateTipForEachPerson_ValidInput_ShouldReturnCorrectTipAmounts()
    {
        // Arrange
        var calculator = new TipCalculator();
        var mealCosts = new Dictionary<string, decimal>
        {
            {"Alice", 20.0m},
            {"Bob", 30.0m},
            {"Charlie", 25.0m}
        };
        float tipPercentage = 10.0f;

        // Act
        var tipAmounts = calculator.CalculateTipForEachPerson(mealCosts, tipPercentage);

        // Assert
        Assert.Equal(4.0m, tipAmounts["Alice"]);
        Assert.Equal(6.0m, tipAmounts["Bob"]);
        Assert.Equal(5.0m, tipAmounts["Charlie"]);
    }

    [Fact]
    public void CalculateTipForEachPerson_EmptyMealCosts_ShouldThrowException()
    {
        // Arrange
        var calculator = new TipCalculator();
        var mealCosts = new Dictionary<string, decimal>();
        float tipPercentage = 15.0f;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calculator.CalculateTipForEachPerson(mealCosts, tipPercentage));
    }
}