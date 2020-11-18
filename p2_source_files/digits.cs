using System;

/* Counters of number of digits a is for one digit,
 * b is for 2 digits, c is for 3 digits and d is for more than 3 digits
 */

class digits
{
    static void Main()
    {
        int digit1 = 0, digit2 = 0, digit3 = 0, digit4 = 0;

        Console.Write("Insert a number: ");
        string number = Console.ReadLine();

        while (number != "end")
        {
            int input = Convert.ToInt32(number);
            if (input != 0)
            {

                if (input / 10 == 0)
                    digit1++;
                else
                if (input / 100 == 0)
                    digit2++;
                else
                if (input / 1000 == 0)
                    digit3++;
                else
                    digit4++;
            }

            number = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", digit1, digit2, digit3, digit4);

    }
}