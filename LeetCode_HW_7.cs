/*
    Hayden Hartmann
    4/7/2025
    Leet Code #2
*/

// practice Stacks and Ques

public class MyMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine(MaxNumberOfBalloons("krhizmmgmcrecekgyljqkldocicziihtgpqwbticmvuyznragqoyrukzopfmjhjjxemsxmrsxuqmnkrzhgvtgdgtykhcglurvppvcwhrhrjoislonvvglhdciilduvuiebmffaagxerjeewmtcwmhmtwlxtvlbocczlrppmpjbpnifqtlninyzjtmazxdbzwxthpvrfulvrspycqcghuopjirzoeuqhetnbrcdakilzmklxwudxxhwilasbjjhhfgghogqoofsufysmcqeilaivtmfziumjloewbkjvaahsaaggteppqyuoylgpbdwqubaalfwcqrjeycjbbpifjbpigjdnnswocusuprydgrtxuaojeriigwumlovafxnpibjopjfqzrwemoinmptxddgcszmfprdrichjeqcvikynzigleaajcysusqasqadjemgnyvmzmbcfrttrzonwafrnedglhpudovigwvpimttiketopkvqw"));

        Console.ReadKey();
    }
    // Number of Segments in a String
    public int CountSegments(string s)
    {

        int segments = 0;
        if (s.Length == 0)
        {
            return segments;
        }
        for (int i = 0; i <= s.Length - 1; i++)
        {
            if (s[i] != ' ' && ((i < s.Length - 1 && s[i + 1] == ' ') || i == s.Length - 1))
            {
                segments++;
            }
        }
        return segments;

    }


    // First Unique Character in a String
    public int FirstUniqChar(string s)
    {
        int position = -1;
        if (s.Length == 1)
        {
            return 0;
        }
        for (int i = 0; i <= s.Length - 1; i++)
        {
            for (int j = 0; j <= s.Length - 1; j++)
            {
                if ((s[i] != s[j] && i != j) || (i == s.Length - 1 && j == s.Length - 1))
                {
                    position = i;
                    if (j == s.Length - 1 && position != -1)
                    {
                        return position;
                    }
                }
                else
                {
                    position = -1;
                    if (i != j)
                    {
                        break;
                    }
                }
            }
        }
        return position;
    }


    // Merge Strings Alternately
    public string MergeAlternately(string word1, string word2)
    {

        string myWord = "";

        if (word1.Length >= word2.Length)
        {
            for (int i = 0; i <= word1.Length - 1; i++)
            {
                myWord += word1[i];
                if (i <= word2.Length - 1)
                {
                    myWord += word2[i];
                }
            }
        }
        else
        {
            for (int i = 0; i <= word2.Length - 1; i++)
            {
                if (i <= word1.Length - 1)
                {
                    myWord += word1[i];
                }
                myWord += word2[i];
            }
        }
        return myWord;

    }


    // find-the-difference
    public static char FindTheDifference(string s, string t)
    {

        char[] s2 = s.ToCharArray(); Array.Sort(s2);
        char[] t2 = t.ToCharArray(); Array.Sort(t2);

        for (int i = 0; i <= s2.Length - 1; i++)
        {
            if (s2[i] != t2[i])
            {
                return t2[i];
            }
        }
        return t2[t2.Length - 1];

    }

    // maximum-number-of-balloons
    public static int MaxNumberOfBalloons(string text)
    {
        int b = 0; int a = 0; int l = 0; int o = 0; int n = 0;

        for (int i = 0; i <= text.Length - 1; i++)
        {

            switch (text[i])
            {
                case 'b':
                    b++;
                    break;
                case 'a':
                    a++;
                    break;
                case 'l':
                    l++;
                    break;
                case 'o':
                    o++;
                    break;
                case 'n':
                    n++;
                    break;
                default:
                    break;
            }
        }
        l = l / 2;
        o = o / 2;
        int min = b;
        int[] myArray = new int[] { b, a, l, o, n };
        foreach (int num in myArray)
        {
            if (min > num)
            {
                min = num;
            }
        }
        return min;
    }

    // robot-return-to-origin
    public static bool JudgeCircle(string moves)
    {

        int u = 0; int d = 0; int l = 0; int r = 0;

        for (int i = 0; i <= moves.Length - 1; i++)
        {
            switch (moves[i])
            {
                case 'U':
                    u++;
                    d--;
                    break;
                case 'D':
                    d++;
                    u--;
                    break;
                case 'L':
                    l++;
                    r--;
                    break;
                case 'R':
                    r++;
                    l--;
                    break;
                default:
                    break;
            }
        }
        if (u == 0 && d == 0 && l == 0 && r == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


