using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPQuest
{
    class Word
    {
        List<String> listOrd;
        List<String> listSpråk;
        public Word()
        {
            listOrd = new List<String>();
            listSpråk = new List<String>();
        }
        public void AddNewTranslation(string ordet, string språket)
        {
            listOrd.Add(ordet);
            listSpråk.Add(språket);
        }
    }
}
