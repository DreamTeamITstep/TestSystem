using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            return _sqlConnection.Query<Admin>($"SELECT * FROM Admin Where Id ={id}").First();
        }

        public int Create(Admin admin)
        {
            _sqlConnection.Query<Admin>(
                $"INSERT INTO Admin(FullName, Id_Role, Password)VALUES({admin.FullName},{admin.RoleId},{admin.Password})");
            var res = _sqlConnection.Query<Admin>($"SELECT * FROM Admin Where Id ={admin.Id}").First();
            return res != null ? 1 : 0;
        }

        public Admin Update(Admin admin)
        {
            var res = _sqlConnection.Query<Admin>($"SELECT * FROM Admin WHERE FullName = '{admin.FullName}'");
            if (res != null)
            {
                _sqlConnection.Query<Admin>(
                    $"UPDATE Admin SET FullName ='{admin.FullName}',Id_Role ='{admin.RoleId}',Password = '{admin.Password}'WHERE FullName ={admin.FullName}");
                return _sqlConnection.Query<Admin>($"SELECT * FROM Admin WHERE FullName = {admin.FullName}")
                    .First();
            }
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            _sqlConnection.Query<Admin>($"DELETE * FROM Admin WHERE Id = {id}");
            var res = _sqlConnection.Query<Admin>($"SELECT * FROM Admin Where Id ={id}").First();
            return res != null ? 0 : 1;
        }
    }
}
