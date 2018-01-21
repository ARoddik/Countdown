using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countdown
{
    public class WordChecker
    {
        private List<char> _letterList;
        private List<int> _iterations = new List<int>()
        {
            10, 9, 8, 7, 6, 5, 4, 3, 2, 1
        };

        public List<string> GetWords(List<char> letterList, List<string> dictionaryList)
        {
            IEnumerable<string> permutationList = FactorialPermutations(letterList);
            List<string> wordList = new List<string>();

            foreach (var v in permutationList)
            {
                if (dictionaryList.Contains(v))
                {
                    wordList.Add(v);
                }
                else ;
            }
            return wordList;
        }

        public int CheckWord(string word, List<string> dictionaryList)
        {
            int points;

            if (dictionaryList.Contains(word))
            {
                points = word.ToCharArray(0, word.Length).Length;
            }
            else
            {
                points = 0;
            }
            return points;
        }

        private IEnumerable<string> FactorialPermutations(List<char> letterList)
        {
            string alphabet = "" + letterList[0] + letterList[1] + letterList[2] +
                              letterList[3] + letterList[4] + letterList[5] +
                              letterList[6] + letterList[7] + letterList[8] +
                              letterList[9];

            var q = alphabet.Select(x => x.ToString());
            int size = 3;
            for (int i = 0; i < size - 1; i++)
                q = q.SelectMany(x => alphabet, (x, y) => x + y);
            return q;
        }

    }
}
