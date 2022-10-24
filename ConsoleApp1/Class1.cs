using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public  class ProgramBase
    {
        public static int maxDepth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(maxDepth(node.left), maxDepth(node.right)) + 1;
        }

        public static string addBinary(string a, string b)
        {
            string s = "";
            int x = a.Length;
            int y = b.Length;
            int diff = x - y;
            if (diff < 0) diff = diff * -1;
            if (x > y)
            {
                while (diff > 0)
                {
                    diff--;
                    b = "0" + b;
                }
            }
            else
            {
                while (diff > 0)
                {
                    diff--;
                    a = "0" + a;
                }
            }
            String carry = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == '0' && b[i] == '0' && carry=="")
                {
                    s = "0" +s;
                    carry = "";
                }
                else if ((a[i] == '0' && b[i] == '1' && carry =="") || (a[i] == '1' && b[i] == '0' && carry==""))
                {
                    s =  "1" + s;
                    carry = "";
                }
                else if (a[i] == '1' && b[i] == '1' && carry =="")
                {
                    s="0" + s;
                    carry = "1";
                }
                else if (a[i] == '0' && b[i] == '0' && carry=="1")
                {
                    s = "1" + s;
                    carry = "";
                }
                else if ((a[i] == '1' && b[i] == '0' && carry=="1") || (a[i] == '0' && b[i] == '1' && carry=="1"))
                {
                    s = "0" + s;
                    carry = "1";
                }
                else if ((a[i] == '1' && b[i] == '1') && carry=="1")
                {
                    s = "1" + s;
                    carry = "1";
                }
            }
            if (carry != "")
                s = carry + s;
            return s;
        }

        public string ConvertToTitle(int columnNumber)
        {
            Stack<char> chars = new Stack<char>();
            StringBuilder columnName = new StringBuilder();
            while (columnNumber > 0)
            {
                chars.Push((char)('A' + (columnNumber - 1) % 26));
                columnNumber = (columnNumber - 1) / 26;
            }
            foreach (var item in chars)
            {
                columnName.Append(item);
            }
            return columnName.ToString();
        }

        public static int TitleToNumber(string columnTitle)
        {
            char[] chars = columnTitle.ToCharArray();
            int columnNumber = 0, ba = 1;

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                columnNumber += ba * ((chars[i] - 'A') + 1);
                ba *= 26;

            }
            return columnNumber;
        }

        public static bool IsHappy(int n)
        {
           HashSet<int> set = new HashSet<int>();

            while(n !=1 || set.Contains(n))
            {
                set.Add(n);
                n = getNextNum(n);
            }

            return n == 1;
        }

        public static int getNextNum(int n)
        {
            int totalSum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                totalSum += digit * digit;
                n /= 10;
            }
            return totalSum;
        }
    }
}