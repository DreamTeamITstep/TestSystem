using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public class AdminsRepository:IAdminsRepository
    {
        private readonly SqlConnection _sqlConnection;

        public AdminsRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public IEnumerable<Admin> Get()
        {
            return _sqlConnection.Query<Admin>("SELECT Id, FullName, Id_Role as RoleId, Password FROM Admin");
        }

        public Admin Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Create(Admin admin)
        {
            throw new System.NotImplementedException();
        }

        public Admin Update(Admin admin)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
