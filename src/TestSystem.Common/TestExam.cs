using System;

namespace TestSystem.Common
{
    [Serializable]
    public class TestExam
    {
        public  Test BodyTest { get; set; } = new Test();
        public int Result { get; set; }
    }
}
