using System.Collections.Generic;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public interface IGroupsRepository
    {
        IEnumerable<Group> Get();
        Group Get(int id);
        int Create(Group group);
        Group Update(Group group);
        int Delete(int id);
    }
}
