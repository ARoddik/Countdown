using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countdown
{
    public class Vowel
    {
        private static readonly List<char> VoweList = new List<char>
        {
            'a','e','i','o','u','y'
        };

        public static char GetRandomVowel()
        {
            Random rand = new Random();
            char returnValue = VoweList[rand.Next(0, VoweList.Count)];

            return returnValue;
        }

    }
}
