namespace DSPractice.gfg.stringsProblems.PatternSearch
{
    internal class RabinKarpAlgorithm
    {
        // d is the number of characters in 
        // the input alphabet
        public const int d = 256;

        /* pat -> pattern
            txt -> text
            q -> A prime number
        */
        /// <summary>
        /// https://practice.geeksforgeeks.org/batch/dsa-4/track/DSASP-Strings/article/MjMxMg%3D%3D
        /// </summary>
        /// <param name="pat"></param>
        /// <param name="txt"></param>
        /// <param name="q"></param>
        internal void search(string pat, string txt, int q)
        {
            int M = pat.Length;
            int N = txt.Length;
            int i, j;
            int p = 0; // hash value for pattern
            int t = 0; // hash value for txt
            int h = 1;

            /// The value of h would be "pow(d, M-1)%q"
            /// we will use this value to remove leading digit
            /// here d is 256 but we can take any other number as number of digit in pattern
            for (i = 0; i < M - 1; i++)
                h = (h * d) % q;

            // Calculate the hash value of pattern and first
            // window of text
            for (i = 0; i < M; i++)
            {
                p = (d * p + pat[i]) % q;
                t = (d * t + txt[i]) % q;
            }

            // Slide the pattern over text one by one
            for (i = 0; i <= N - M; i++)
            {

                // Check the hash values of current window of text
                // and pattern. If the hash values match then only
                // check for characters on by one
                if (p == t)
                {
                    /* Check for characters one by one */
                    for (j = 0; j < M; j++)
                    {
                        if (txt[i + j] != pat[j])
                            break;
                    }

                    // if p == t and pat[0...M-1] = txt[i, i+1, ...i+M-1]
                    if (j == M)
                        Console.WriteLine("Pattern found at index " + i);
                }

                // Calculate hash value for next window of text: Remove
                // leading digit, add trailing digit
                if (i < N - M)
                {
                    t = (d * (t - txt[i] * h) + txt[i + M]) % q;

                    // We might get negative value of t, converting it
                    // to positive
                    if (t < 0)
                        t = t + q;
                }
            }
        }
    }
}
