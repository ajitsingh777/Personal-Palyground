
namespace DSPractice.gfg.stringsProblems.videos
{
    internal class LexographicRankOfString
    {
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/video/MTYxNA%3D%3D
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LexRank(string s)
        {
            long res = 0;
            int[] count = new int[256];
            int m = 1000000007;
            int n = s.Length;
            long[] fact = new long[26];
            fact[0] = 1;
            fact[1] = 1;
            for (int i = 2; i < 26; i++)
                fact[i] = (i * fact[i - 1]) % m;


            /// count every element in string
            for (int i = 0; i < n; i++)
            {
                if (count[s[i]] > 0)
                {
                    return 0;
                }
                count[s[i]]++;
            }
            /// cumulative count of every later as it will give number of smaller elments than this letter
            for (int i = 1; i < 256; i++)
            {
                count[i] += count[i - 1];
            }

            /// smaler rank strings for any character will be !n * smaller numbers count
            for (int i = 0; i < n - 1; i++)
            {
                res = (res + (count[s[i] - 1] * fact[n - i - 1])) % m;
                ///reduce smaller letters count by 1 as we will check for next position now
                for (int j = s[i]; j < 256; j++)
                {
                    count[j]--;
                }
            }
            return (int)res + 1;
        }
    }
}
