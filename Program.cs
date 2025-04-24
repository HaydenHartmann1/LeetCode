/*
    Hayden Hartmann
    4/22/2025
    Leet Code Problems: Homework Set 9
*/

using System.Runtime.CompilerServices;

public class MyMain
{
    public static void Main(string[] args)
    {
        bool test = IsHappy(19);
        //MoveZeros([0, 1, 0, 3, 12]);
        Console.ReadKey();
    }

    // Happy number   keep running value through to get a 'n' value less than 10, if its not 1 or 7, will loop infinitly
    public static bool IsHappy(int n)
    {
        if (n < 10)
        {
            if (n == 1 || n == 7) // if its 1 or 7, it will work
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return IsHappy(sum);
    }

    // Move Zeros
    public static void MoveZeros(int[] nums)
    {
        int previous = 0;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] != 0)
            {
                nums[previous] = nums[i];
                previous++;
            }
        }
        for (int i = previous; i <= nums.Length - 1; i++)
        {
            nums[i] = 0;
        }
    }

    // Length of Last Word
    public static int LengthOfLastWord(string s)
    {

        int len = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                for (int j = i; j >= 0; j--)
                {
                    if (j == 0 && s[j] != ' ')
                    {
                        len++;
                        return len;
                    }
                    else if (s[j] != ' ')
                    {
                        len++;
                    }
                    else
                    {
                        return len;
                    }
                }
            }
        }
        return len;

    }

    // Reverse String
    public static void ReverseString(char[] s)
    {
        int count = s.Length - 1;
        for (int i = 0; i < count; i++)
        {
            (s[i], s[count]) = (s[count], s[i]);
            count--;
        }
    }

    // Major Element
    public static int MajorityElement(int[] nums)
    {
        Dictionary<int, int> myNumbers = new Dictionary<int, int>();
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (myNumbers.ContainsKey(nums[i]))
            {
                myNumbers[nums[i]] += 1;
            }
            else
            {
                myNumbers[nums[i]] = 0;
            }
        }
        int max = 0;
        int maxKey = 0;
        foreach (KeyValuePair<int, int> pair in myNumbers)
        {
            if (pair.Value >= max)
            {
                max = pair.Value;
                maxKey = pair.Key;
            }
        }
        return maxKey;
    }
}

