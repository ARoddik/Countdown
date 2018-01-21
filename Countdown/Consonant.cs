using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countdown
{
    class Consonant
    {
        private static readonly List<char> ConsonantList = new List<char>
        {
            'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','z'
        };

        public static char GetRandomConsonant()
        {
            Random rand = new Random();
            char returnValue = ConsonantList[rand.Next(0, ConsonantList.Count)];

            return returnValue;
        }
    }
}
