using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment _assign_01 = new Assignment();
        _assign_01.SetSummary("Samuel Bennett", "Multiplication");

        Console.WriteLine(_assign_01.GetSummary());

        MathAssignment _math_01 = new MathAssignment();
        _math_01.SetSummary("Roberto Rodriguez","Fractions");
        _math_01.SetHomeWork("7.3","8-19");

        Console.WriteLine(_math_01.GetHomeworkList());

        WritingAssignment _write_01 = new WritingAssignment();
        _write_01.SetSummary("Mary Waters", "European History");
        _write_01.SetHomeWork("The Causes of World War II");

        Console.WriteLine(_write_01.GetWritingtInformation());

        
    }
}