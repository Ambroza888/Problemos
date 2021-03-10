namespace Problems
{
  class BackCaseString
  {
    public static bool backcase(string S, string T)
    {
              // abc#d abzz##d => abd = abd
        int s = S.Length-1;
        int t = T.Length-1;

        while (s >= 0 || t >= 0)
        {
            int countS = 0;
            while (s >= 0 && (S[s] == '#' || countS > 0))
            {
                if (S[s] == '#')
                {
                    countS++;
                } else {
                    countS--;
                }

                s--;
            }
            int countT = 0;
            while (t >= 0 && (T[t] == '#' || countT > 0))
            {
                if (T[t] == '#')
                {
                    countT++;
                } else {
                    countT--;
                }

                t--;
            }

            if (s < 0 && t < 0) return true;

            if (s >= 0 && t >= 0 && S[s] == T[t])
            {
                s--;
                t--;
            } else {
                return false;
            }
        }
        return true;
    }
  }
}