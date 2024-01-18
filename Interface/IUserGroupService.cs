using IronQuest.Models;

namespace IronQuest.Interface
{
    public interface IUserGroupService
    {
        List<User> GetNonGroupedUsers();
        List<Group> GetAllGroups();
        void AssignUserToGroup(User user, Group group);
        void RemoveUserFromGroup(User user);
    }
}
