using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countdown
{
    public class LetterContainer
    {
        private List<char> _letterList = new List<char>();

        public void AddLetter(char letter)
        {
            if (_letterList.Count < 10)
            {
                _letterList.Add(letter);
            }
            else ;
        }

        public List<char> GetLetterList()
        {
            return _letterList;
        }

    }
}
