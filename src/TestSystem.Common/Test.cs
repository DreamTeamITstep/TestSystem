using System;
using TestLibrary;

namespace TestSystem.Common
{
    [Serializable]
    public class Test
    {
        public TestLibrary.Test BodyTest { get; set; } = new TestLibrary.Test();
        public int Result { get; set; }
    }
}
