using System;

namespace TestSystem.Common
{

    public class TestExam
    {
        //TODO attention bad logic!! need rewriting
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public int Result { get; set; }
        public DateTime Date { get; set; }
        public Test BodyTest { get; set; } = new Test();
        public override string ToString()
        {
            return BodyTest.Name;
        }
    }
}
