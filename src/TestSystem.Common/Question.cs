using System;
using System.Collections.Generic;

namespace TestSystem.Common
{
    [Serializable]
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; } = null;
        public Question() { Answers = new List<Answer>(); }
        public Question(List<Answer> answers, string text = "")
        {
            Answers = answers;
            Text = text;
        }
    }
}
