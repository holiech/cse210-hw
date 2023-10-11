using System;

class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        numerator = top;
        if (bottom != 0)
        {
            denominator = bottom;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero. Setting denominator to 1.");
            denominator = 1;
        }
    }

    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int top)
    {
        numerator = top;
    }

    public int GetDenominator()
    {
        return denominator;
    }

    public void SetDenominator(int bottom)
    {
        if (bottom != 0)
        {
            denominator = bottom;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero. Did not change the denominator.");
        }
    }

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimalValue()
    {
        if (denominator != 0)
        {
            return (double)numerator / denominator;
        }
        else
        {
            Console.WriteLine("Division by zero is undefined. Returning 0.");
            return 0.0;
        }
    }
}
