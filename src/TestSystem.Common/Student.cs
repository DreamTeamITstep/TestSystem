using System.Collections.Generic;

namespace TestSystem.Common
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public List<int> GroupId { get; set; } = new List<int>();
        public string Password { get; set; }
        public override string ToString()
        {
            return FullName;
        }
    }
}
