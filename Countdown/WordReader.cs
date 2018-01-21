using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countdown
{
    class WordReader
    {
        StreamReader fileReader = new StreamReader(@"words.txt");

        public List<string> GetWordList(List<string> wordList)
        {
            string line;
            while ((line = fileReader.ReadLine()) != null)
            {
                wordList.Add(line);
            }
            return wordList;
        }
    }
}
