using System;

namespace TestSystem.Common
{
    public class TestExam
    {
        public int IdTest { get; set; }
        public int Result { get; set; }
        public bool IsAvailable { get; set; }
        public Test BodyTest { get; set; } = new Test();
    }
}
