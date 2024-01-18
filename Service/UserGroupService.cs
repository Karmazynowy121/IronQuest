using IronQuest.Interface;
using IronQuest.Models;

namespace IronQuest.Service
{
    public class UserGroupService : IUserGroupService
    {
        private List<User> _users = new List<User>
        {
        new User
        {
            Id = new Guid().ToString(),
            FirstName = "Jan",
            LastName = "Kowalski",
            AssignedGroupId = "0"
        },
        new User {
            Id = new Guid().ToString(),
            FirstName = "Marek",
            LastName = "Nowak",
            AssignedGroupId = "0"
        }
        };
        private List<Group> _groups = new List<Group>
        {
          new Group
        {
            Id = "1",
            Name = "Grupa 1"
        },
          new Group
        {
            Id = "2",
            Name = "Grupa 2"
        },
          new Group
        {
            Id = "3",
            Name = "Grupa 3"
        },
          new Group
        {
            Id = "4",
            Name = "Grupa 4"
        }
        };

        public UserGroupService()
        {

        }

        public List<User> GetNonGroupedUsers()
        {
            return _users.Where(u => u.AssignedGroup == null).ToList();
        }

        public List<Group> GetAllGroups()
        {
            return _groups;
        }

        public void AssignUserToGroup(User user, Group group)
        {
            user.AssignedGroup = group;
            group.Users.Add(user);
        }

        public void RemoveUserFromGroup(User user)
        {
            user.AssignedGroup?.Users.Remove(user);
            user.AssignedGroup = null;
        }
    }

}
