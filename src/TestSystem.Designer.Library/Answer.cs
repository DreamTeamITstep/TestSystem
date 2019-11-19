using System;

namespace TestSystem.Designer.Library
{
    [Serializable]
    public class Answer
    {
        public string Text { get; set; }
        public bool Correct { get; set; } = false;
    }
}
