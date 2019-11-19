using System.Data.Common;

namespace TestSystem.Common
{
    public class Admin
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
    }
}
