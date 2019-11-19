using System.Collections.Generic;
using TestSystem.Common;

namespace WebApiServer.Repositories
{
    interface ISubjectRepository
    {
        IEnumerable<Subject> Get();
        Subject Get(int id);
        int Create(Subject subject);
        Subject Update(Subject subject);
        int Delete(int id);
    }
}
