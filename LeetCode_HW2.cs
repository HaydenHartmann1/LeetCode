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


