using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google50.Medium
{
    internal class LetterCombinationOfPhoneNumber
    {
        public List<string> findLetter(string digits)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits)) { return result; }
            Dictionary<string, List<string>> map = getMap();
            if (digits.Length == 1)
            {
                if (map.ContainsKey(digits))
                {
                    return map[digits];
                }
                else
                {
                    return result;
                }
            }
            string current = string.Empty;
            find(digits, result, current, map);

            return result;
        }

        private void find(string digits, List<string> result, string current, Dictionary<string, List<string>> map)
        {
            if (digits.Length == 0)
            { 
                result.Add(current);
                return;
            }

            string currentDigit = digits.Substring(0,1);
            foreach (string s in map[currentDigit])
            {
                current += s;
                
                find(digits.Substring(1), result, current, map);

                current = current.Substring(0, current.Length - 1);

            }
        }

        private Dictionary<string, List<string>> getMap()
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            map["2"] = new List<string> { "a", "b", "c" };
            map["3"] = new List<string> { "d", "e", "f" };
            map["4"] = new List<string> { "g", "h", "i" };
            map["5"] = new List<string> { "j", "k", "l" };
            map["6"] = new List<string> { "m", "n", "o" };
            map["7"] = new List<string> { "p", "q", "r", "s" };
            map["8"] = new List<string> { "t", "u", "v" };
            map["9"] = new List<string> { "w", "x", "y", "z" };

            return map;
        }
    }
}