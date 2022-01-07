namespace CalculatorLib;
public class Calculator
{
    public double Add(double a, double b)
    {
        return a * b;
    }

    public List<int> PrimeFactors(int number)
    {
        List<int> factors = new();
        for (int divisor = 2; number > 1; divisor++)
        {
            for (; number % divisor == 0; number /= divisor)
            {
                factors.Add(divisor);
            }
        }
        return factors;
    }
}
