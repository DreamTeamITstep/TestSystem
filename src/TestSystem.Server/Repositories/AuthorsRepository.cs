using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public class AuthorsRepository:IAuthorsRepository
    {
        private readonly SqlConnection _sqlConnection;

        public AuthorsRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public IEnumerable<Author> Get()
        {
            //TODO Ask about query stile for instance _sqlConnection.Query<Author>("SELECT * FROM Author "); it might be important!!!
            //TODO Ask about different tables name Author and Teacher
            return _sqlConnection.Query<Author>("SELECT Id, FullName, Id_Role as RoleId, Password FROM Teacher");
        }

        public Author Get(int id)
        {
            return _sqlConnection.Query<Author>($"SELECT * FROM Teacher Where Id ={id}").First();
        }

        public int Create(Author author)
        {
            _sqlConnection.Query<Author>(
                $"INSERT INTO Teacher(FullName, Id_Role, Password)VALUES({author.FullName},{author.RoleId},{author.Password})");
            var res = _sqlConnection.Query<Author>($"SELECT * FROM Teacher Where FullName ={author.FullName}").First();
            return res != null ? 1 : 0;
        }

        public Author Update(Author author)
        {
            //TODO What's better WHERE FullName = {author.FullName}" or WHERE Id = {author.id}"
            var res =_sqlConnection.Query<Author>($"SELECT * FROM Teacher WHERE FullName = '{author.FullName}'");
            if (res != null)
            {
                _sqlConnection.Execute(
                    $"UPDATE Teacher SET FullName ='{author.FullName}',Id_Role ='{author.RoleId}',Password = '{author.Password}'WHERE FullName ={author.FullName}");
                return _sqlConnection.Query<Author>($"SELECT * FROM Teacher WHERE FullName = {author.FullName}")
                    .First();
            }
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            _sqlConnection.Query<Author>($"DELETE * FROM Teacher WHERE Id = {id}");
            var res = _sqlConnection.Query<Author>($"SELECT * FROM Teacher Where Id ={id}").First();
            return res != null ? 0 : 1;
        }
    }
}
