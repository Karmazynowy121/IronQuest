namespace IronQuest.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
