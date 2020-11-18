using System;

public class Average
{
    public static void Main()
    {
        double number1 = 0, number2, number3 = 0, average;
        string mark;

        Console.Write("Insert a mark: ");
        mark = Console.ReadLine();

        while (mark != "end")
        {
            number2 = Convert.ToDouble(s);
            number3++;
            number1 += number2;
            Console.Write("Insert a mark: ");
            mark = Console.ReadLine();
        }

        if (number3 != 0)
        {
            average = number1 / number3;
            Console.WriteLine("The average is {0}.", average);
        }
    }
}
