using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public class TestRepository:ITestsRepository
    {
        private readonly SqlConnection _sqlConnection;

        public TestRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public IEnumerable<Test> Get()
        {
            return _sqlConnection.Query<Test>("SELECT * FROM Test");
        }

        public Test Get(int id)
        {
            return _sqlConnection.Query<Test>($"SELECT * FROM Test Where Id ={id}").First();
        }

        public int Create(Test test)
        {
            //TODO Ask about Content
            var idTeacher = _sqlConnection.Query<Author>($"SELECT Id FROM Teacher WHERE FullName ='{test.Author}'").First();
            var idSubject = _sqlConnection.Query<Author>($"SELECT Id FROM Subject WHERE Name = '{test.Subject}'")
                .First();
            _sqlConnection.Query<Test>(
                $"INSERT INTO Test(Name, Id_Teacher,Id_Subject,Date, Content)VALUES({test.Name},{idTeacher},{idSubject},{DateTime.Now},{test} )");
            var res = _sqlConnection.Query<Test>($"SELECT * FROM Test Where Id ={test}").First();//TODO test.id
            return res != null ? 1 : 0;
        }

        public Test Update(Test test)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
