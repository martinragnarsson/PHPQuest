﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPQuest.Controller
{
    class WordList
    {
        public List<string> Språk1 = new List<string> { "hej", "hejdå", "hund", "katt", "dator", "cykel", "skola", "klocka", "stol", "bord", "mask", "fiska", "båt", };
        public List<string> Språk2 = new List<string> { "hello", "goodbye", "dog", "cat", "computer", "bike", "school", "clock", "chair", "table", "worm", "fish", "boat" };

        public List<Word> listWords = new List<Word>();
        
        //public List<string> Språk3 = new List<string> { "" };
        //public List<string> Språk4 = new List<string> { "" };
    }
}
