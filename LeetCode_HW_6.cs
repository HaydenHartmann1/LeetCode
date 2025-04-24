/*
    Hayden Hartmann
    3/30/2025
    Leet Code Problems
*/


public class MyMain
{
    public static void Main(string[] args)
    {

        Console.WriteLine(StrStr("my payday", "pay"));

        int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        //                       1, 6, 3, 6, 5, 5, 5
        int x = RemoveElement(nums, 2);
        Console.WriteLine(x + " this");
        foreach(int num in nums)
        {
            Console.Write(num + ", ");
        }

        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        Merge2(nums1, 3, nums2, 3);
        Console.WriteLine("TESTING");
        foreach(int num in nums1)
        {
            Console.Write(num + ", ");
        }

        Console.ReadKey();
    }
    public static int[] SortArrayByParity(int[] nums)
    {

        if (nums.Length == 1)
        {
            return nums;
        }
        else
        {
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evens.Add(nums[i]);
                }
                else
                {
                    odds.Add(nums[i]);
                }
            }
            for (int i = 0; i <= evens.Count - 1; i++)
            {
                nums[i] = evens[i];
            }
            for (int i = 0; i <= odds.Count - 1; i++)
            {
                nums[i + evens.Count] = odds[i];
            }
        }
        return nums;

    }
    /*
    public static int[] SortArrayByParity2(int[] nums)
    {

        if (nums.Length == 1)
        {
            return nums;
        }
        else
        {
            int count = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    for 
                }
            }
        }
        return nums;

    }
    */
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {

        if (n != 0)
        {
            int[] myNums = new int[m + n];
            for (int i = 0; i <= nums1.Length - 1; i++)
            {
                myNums[i] = nums1[i];
            }
            for (int i = m; i <= nums2.Length + m - 1; i++)
            {
                myNums[i] = nums2[i - m];
            }
            Array.Sort(myNums);
            for (int i = 0; i <= nums1.Length - 1; i++)
            {
                nums1[i] = myNums[i];
            }
        }
    }
    // shorter
    public static void Merge2(int[] nums1, int m, int[] nums2, int n)
    {

        if (n != 0)
        {
            int[] myNums = new int[m + n];
            for (int i = m; i <= nums1.Length - 1; i++)
            {
                nums1[i] = nums2[i - m];
            }
            Array.Sort(nums1);
        }
    }

    public static int RemoveElement(int[] nums, int val)
    {
        //find how many "vals" are in array
        int count = 0;
        foreach (int num in nums)
        {
            if (num == val)
            {
                count++;
            }
        }
        //loops through nums
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] == val)
            {
                // loops through nums again and if the last position - j == val then swap current and last position, 
                // but checks first if j <= count. count essentially means that we can only swap last positions
                // prevents vals from swapping with previous values
                for (int j = 1; j <= nums.Length; j++)
                {
                    if (nums[nums.Length - j] != val && j <= count)
                    {
                        (nums[i], nums[nums.Length - j]) = (nums[nums.Length - j], nums[i]);
                        break;
                    }
                }
            }
        }
        return count;

    }

    public int[] TwoSum(int[] nums, int target) {

        int count = 0;

        while (true) {

            for (int i = 0; i <= nums.Length - 1; i++) {

                if (count != i && nums[count] + nums[i] == target) {
                    int[] numbers = new int[] { count, i };
                    return numbers;
                }
            }
        count++;
        }
    }

    public static int StrStr(string haystack, string needle)
    {
        // string needle in haystack? were at 
        // abc abc

        //checks if needle is shorter than haystack
        if (needle.Length > haystack.Length)
        {
            return -1;
        }

        // loops through haystack letters
        for (int i = 0; i <= haystack.Length - 1; i++)
        {
            string mySubstring = "";
            // loops through needle letters and compares them to haystack
            for (int j = 0; j <= needle.Length - 1; j++) 
            {
                if (i + j < haystack.Length && haystack[i + j] == needle[j])
                {
                    mySubstring += needle[j];
                }
                else
                {
                    break;
                }
                if (mySubstring == needle)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}

