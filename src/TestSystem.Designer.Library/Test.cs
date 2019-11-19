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
      //  public Test() { Questions = new List<Question>(); }
        //public Test(string name = "", string subject = "", string theme = "", string author = "")
        //{
        //    Questions = new List<Question>();
        //    Name = name;
        //    Subject = subject;
        //    Theme = theme;
        //    Author = author;
        //}
    }
}
