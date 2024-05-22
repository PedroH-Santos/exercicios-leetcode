public class SolutionAma3
{
    public int LengthOfLongestSubstring(string s)
    {
        if(s.Length == 1) { return 1; }
        int bigger = 0;
        String current = "";
        int inital = 0;
        int count = inital;
        while (count < s.Length) {
            if (!current.Contains(s[count]))
            {
                current += s[count];
                if (current.Length > bigger)
                {
                    bigger = current.Length;
                }
            }
            else
            {
                inital++;
                count = inital;
                current = s[count].ToString();
            }

            count++;
        }


        return bigger;
    }
}