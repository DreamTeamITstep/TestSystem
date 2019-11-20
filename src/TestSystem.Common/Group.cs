namespace TestSystem.Common
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
