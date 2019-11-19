using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    [Serializable]
    public class Test
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Theme { get; set; }
        public string Author { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
