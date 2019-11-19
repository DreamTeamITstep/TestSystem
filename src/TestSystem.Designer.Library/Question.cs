using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    [Serializable]
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
        //public Question() { Answers = new List<Answer>(); }
        //public Question(List<Answer> answers, string text = "")
        //{
        //    Answers = answers;
        //    Text = text;
        //}
    }
}
