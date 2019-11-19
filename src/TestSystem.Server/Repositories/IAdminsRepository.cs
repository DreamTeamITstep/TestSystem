using System.Collections.Generic;
using TestSystem.Common;


namespace WebApiServer.Repositories
{
    public interface IAdminsRepository
    {
        IEnumerable<Admin> Get();
        Admin Get(int id);
        int Create(Admin admin);
        Admin Update(Admin admin);
        int Delete(int id);
    }
}
