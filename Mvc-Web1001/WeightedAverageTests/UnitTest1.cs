using Xunit;
using WeightedAverageLibrary;

public class WeightedAverageCalculatorTests
{
    [Fact]
    public void CalculateWeightedAverage_ValidInput_ShouldReturnCorrectValue()
    {
        // Arrange
        var calculator = new WeightedAverageCalculator();
        var values = new double[] { 4.5, 3.2, 2.7 };
        var weights = new double[] { 0.3, 0.2, 0.5 };

        // Act
        var result = calculator.CalculateWeightedAverage(values, weights);

        // Assert
        Assert.Equal(3.29, result, 2); // The third argument is the precision (number of decimal places)
    }
}