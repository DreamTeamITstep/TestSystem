﻿using System;

namespace TestSystem.Common
{
    [Serializable]
    public class Answer
    {
        public string Text { get; set; }
        public bool Correct { get; set; } = false;
    }
}
