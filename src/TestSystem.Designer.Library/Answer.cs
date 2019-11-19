using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    [Serializable]
    public class Answer
    {
        public string Text { get; set; }
        public bool Correct { get; set; } = false;
        //public Answer() { }
        //public Answer(string text = "", bool correct = false)
        //{ 
        //    Text = text;
        //    Correct = correct; 
        //}
    }
}
