using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countdown
{
    public class Dictionary
    {
        private List<string> _dictionaryList = new List<string>();
        private WordReader _wordReader = new WordReader();

        public void CreateDictionary()
        {
            _wordReader.GetWordList(_dictionaryList);
        }

        public List<string> GetDictionary()
        {
            return _dictionaryList;
        }
    }
}
