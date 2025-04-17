/*
    Hayden Hartmann
    4/13/2025
    Leet Code Problems!!!
*/

public class MyMain
{
    public static void Main(string[] args)
    {

        bool vaal = IsValid("(){}[]");
        Console.WriteLine(vaal);
        Console.ReadKey();

        int v = CalPoints(["5", "2", "C", "D", "+"]);
    }

    // Valid Parentheses

    public static bool IsValid(string s)
    {

        Stack<char> myStack = new Stack<char>();

        for (int i = 0; i <= s.Length - 1; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                myStack.Push(s[i]);
            }
            else if (myStack.Count == 0)
            {
                    return false;
            }
                else
            {
                char c = myStack.Pop();
                if ((c == '(' && s[i] != ')') || (c == '[' && s[i] != ']') || (c == '{' && s[i] != '}'))
                {
                    return false;
                }
            }
        }
        if (myStack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Baseball Game

    public static int CalPoints(string[] operations)
    {

        Stack<int> myStack = new Stack<int>();
        int x = 0;
        int y = 0;
        int z = 0;
        for (int i = 0; i <= operations.Length - 1; i++)
        {

            if (operations[i] != "D" && operations[i] != "+" && operations[i] != "C")
            {
                x = Convert.ToInt32(operations[i]);
                myStack.Push(x);
            }
            else
            {
                switch (operations[i])
                {
                    case "+":
                        x = myStack.Pop();
                        y = myStack.Pop();
                        z = x + y;
                        myStack.Push(x); myStack.Push(y); myStack.Push(z);
                        break;
                    case "D":
                        x = myStack.Pop();
                        y = x * 2;
                        myStack.Push(x); myStack.Push(y);
                        break;
                    case "C":
                        myStack.Pop();
                        break;
                    default:
                        break;
                }
            }
        }
        int v = 0;
        foreach (int d in myStack)
        {
            v += d;
        }
        return v;
    }

    // Find Pivot Index

    public static int PivotIndex(int[] nums)
    {

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            int left = 0;
            int right = 0;
            for (int j = 0; j <= nums.Length - 1; j++)
            {
                if (i > j)
                {
                    left += nums[j];
                }
                else if (i < j)
                {
                    right += nums[j];
                }
            }
            if (left == right)
            {
                return i;
            }
        }
        return -1;

    }

    // Number of Student That Cant Eat Lunch

    public static int CountStudents(int[] students, int[] sandwiches)
    {
        int count_0 = 0;
        int count_1 = 0;

        for (int i = 0; i <= students.Length - 1; i++)
        {
            if (students[i] == 0)
            {
                count_0++;
            }
            else
            {
                count_1++;
            }
        }

        for (int i = 0; i <= sandwiches.Length - 1; i++)
        {
            if (sandwiches[i] == 0 && count_0 > 0)
            {
                count_0--;
            }
            else if (sandwiches[i] == 1 && count_1 > 0)
            {
                count_1--;
            }
            else
            {
                break;
            }
        }

        return count_0 + count_1;
    }

}

public class RecentCounter
{

    Queue<int> queue = new Queue<int>();

    public RecentCounter()
    {
        queue = new Queue<int>();
    }

    public int Ping(int t)
    {
        queue.Enqueue(t);
        while (t - queue.Peek() > 3000)
        {
            queue.Dequeue();
        }

        return queue.Count;
    }
}