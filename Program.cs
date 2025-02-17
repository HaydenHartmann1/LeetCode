/*
    Hayden Hartmann
    2/17/2025
    Roman to Integer
*/


public class MyMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ReturnInt("II"));
        Console.WriteLine(ReturnInt("CXV"));
        Console.WriteLine(ReturnInt("XVIII"));
        Console.WriteLine();
        Console.WriteLine(ReturnInt("IV"));
        Console.WriteLine(ReturnInt("IX"));
        Console.WriteLine(ReturnInt("XL"));
        Console.WriteLine(ReturnInt("XC"));
        Console.WriteLine(ReturnInt("CD"));
        Console.WriteLine(ReturnInt("CM"));

        Console.ReadKey();
    }

    // method returns converted roman numeral to int
    public static int ReturnInt(string s)
    {
        // declares variables and assigns them
        string romanNumerals = "IVXLCDM";
        int[] nums = [1, 5, 10, 50, 100, 500, 1000];
        List<int> numbers = new List<int>();
        int value = 0;
        int skipValue = -1;

        // loops through both "s" and "romanNumerals" to find were the chars are == and then adds the corresponding number from "nums" to the list "numbers"
        for (int i = 0; i <= s.Length - 1; i++)
        {
            for (int j = 0; j <= romanNumerals.Length - 1; j++)
            {
                if (romanNumerals[j] == s[i])
                {
                    numbers.Add(nums[j]);
                }
            }
        }

        // this loops through "numbers" and adds values to "value" depending on some conditions
        for (int i = 0; i <= numbers.Count - 1; i++)
        {
            // this makes sure that we wont go out of bounds with checking next int, and then checks if the next int should be skipped
            if (i != numbers.Count - 1 && i != skipValue)
            {
                if (numbers[i] >= numbers[i + 1])
                {
                    value += numbers[i];
                }
                // if the int is less than the next in, we can then do math to find the value of both int's combined
                else if (numbers[i] < numbers[i + 1])
                {
                    // all roman numerals are either multiplied by 4 or 9 when for example IV or XC
                    if (numbers[i] * 5 == numbers[i + 1])
                    {
                        value += numbers[i] * 4;

                        // we skip the next value in the list
                        skipValue = i + 1;
                    }
                    else
                    {
                        value += numbers[i] * 9;
                        skipValue = i + 1;
                    }
                }
            }
            // if its the last int and it isn't being used with the previous int, (ie being skipped)
            else if (i != skipValue)
            {
                value += numbers[i];
            }
        }

        return value;

    }

}



