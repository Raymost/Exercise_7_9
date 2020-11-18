using System;

public class Average
{

    public static void Main()
    {
        double a = 0, b, c = 0, d;
        string s;

        Console.Write("Insert a mark: ");
        s = Console.ReadLine();

        // if the mark isn't an end then we pass it to double to work with it 
        while (s != "end")
        {
            b = Convert.ToDouble(s);
            c++;
            a += b;
            Console.Write("Insert a mark: ");
            s = Console.ReadLine();
        }

        if (c != 0)
        {
            //calculate the average 
            d = a / c;
            Console.WriteLine("The average is {0}.", d);
        }
    }
}
