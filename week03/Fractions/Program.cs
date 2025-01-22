using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac_1 = new Fraction();

        Console.WriteLine(frac_1.GetFractionString());
        Console.WriteLine(frac_1.GetDecimalValue());

        Fraction frac_2 = new Fraction(5);

        Console.WriteLine(frac_2.GetFractionString());
        Console.WriteLine(frac_2.GetDecimalValue());

        Fraction frac_3 = new Fraction( 3, 4);

        Console.WriteLine(frac_3.GetFractionString());
        Console.WriteLine(frac_3.GetDecimalValue());

        Fraction frac_4 = new Fraction( 1, 3);

        Console.WriteLine(frac_4.GetFractionString());
        Console.WriteLine(frac_4.GetDecimalValue());

    }
}