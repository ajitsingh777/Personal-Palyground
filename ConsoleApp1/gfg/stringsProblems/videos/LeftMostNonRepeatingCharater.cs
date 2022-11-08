using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.gfg.stringsProblems.videos
{
    internal class LeftMostNonRepeatingCharater
    {
        ///256 for all ascii character if only english alphabates the array length can be 52
        const int CHAR = 256;


        /// <summary>
        /// Naive appraoch,use two for Loop and check for every character
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstNonRepeaetingCharacter_Approach1(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                bool flag = true;
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j && s[j] == s[i])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    return i + 1;
                }
            }
            return -1;

        }

        /// <summary>
        /// count the frequency of every element and then in second iteration check first element with 1 frequency
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstNonRepeaetingCharacter_Approach2(string s)
        {

            int[] count = new int[CHAR];

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (count[s[i]] == 1)
                {
                    // added +1 for correct position
                    return i + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// take a 256 array with default vaule is -1
        /// -1 means that character is not present in array
        /// -2 means repeating character
        /// >=0 means index of non repeating character, find min of those.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstNonRepeaetingCharacter_Approach3(string s)
        {

            int[] storeIndex = new int[CHAR];
            Array.Fill(storeIndex, -1);
            int res = int.MaxValue;

            for (int i = 0; i < s.Length; i++)
            {
                /// mark all repeating element's index as -2
                if (storeIndex[s[i]] == -1)
                {
                    storeIndex[s[i]] = i;
                }
                else
                {
                    storeIndex[s[i]] = -2;
                }
            }

            for (int i = 0; i < CHAR; i++)
            {
                if (storeIndex[i] >= 0)
                {
                    res = Math.Min(res, storeIndex[i]);
                }
            }
            return res == int.MaxValue ? -1 : res + 1;
        }
    }
}
