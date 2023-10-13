public class WeightedAverageCalculator
{
    public double CalculateWeightedAverage(double[] values, double[] weights)
    {
        if (values.Length != weights.Length)
        {
            throw new ArgumentException("Values and weights arrays must have the same length.");
        }

        double sum = 0;
        double weightSum = 0;

        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i] * weights[i];
            weightSum += weights[i];
        }

        if (weightSum == 0)
        {
            throw new InvalidOperationException("Sum of weights cannot be zero.");
        }

        return sum / weightSum;
    }
}