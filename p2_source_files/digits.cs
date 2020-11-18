using System;

/* Counters of number of digits a is for one digit,
 * b is for 2 digits, c is for 3 digits and d is for more than 3 digits
 */

class digits
{
    static void Main()
    {
        int a = 0, b = 0, c = 0, d = 0;

        Console.Write("Insert a number: ");
        string e = Console.ReadLine();

        while (e != "end")
        {
            int input = Convert.ToInt32(e);
            if (input != 0)
            {

                if (input / 10 == 0)
                    a++;
                else
                if (input / 100 == 0)
                    b++;
                else
                if (input / 1000 == 0)
                    c++;
                else
                    d++;
            }

            e = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", a, b, c, d);

    }
}