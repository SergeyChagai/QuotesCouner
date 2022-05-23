using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuotesCounter
{
    public static class Parser
    {
        public static bool CheckQuotesEquality(string enter)
        {
            var balance = 0;

            foreach(char c in enter)
            {
                if (c == '(' || c == '{' || c == '[')
                    balance++;
                if (c == ')' || c == '}' || c == ']')
                    balance--;
            }
            return balance == 0;
        }
    }
}
