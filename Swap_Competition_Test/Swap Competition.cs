using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Competition_Test
{
    
        public class SwapCompetetion
        {
            public bool CanRearrange(string word1, string word2)
            {
                if (word1.Length != word2.Length)
                {
                    return false;
                }
                int[] charCounts = new int[26];

                for (int i = 0; i < word1.Length; i++)
                {
                    charCounts[word1[i] - 'a']++;
                    charCounts[word2[i] - 'a']--;
                }

                for (int i = 0; i < 26; i++)
                {
                    if (charCounts[i] != 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    
}

