namespace IronQuest.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Symbol { get; set; }
        public bool IsLocked { get; set; }
        public string AssignedGroupId { get; set; }
        public Group AssignedGroup { get; set; }
    }
}
