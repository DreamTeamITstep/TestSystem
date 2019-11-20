using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public class SubjectRepository: ISubjectRepository
    {
        private readonly SqlConnection _sqlConnection;
        public SubjectRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public IEnumerable<Subject> Get()
        {
            return _sqlConnection.Query<Subject>("SELECT Id, Name FROM Subject");
        }

        public Subject Get(int id)
        {
            return _sqlConnection.Query<Subject>($"SELECT * FROM Subject Where Id ={id}").First();
        }

        public int Create(Subject subject)
        {
            _sqlConnection.Query<Subject>(
                $"INSERT INTO Subject(Name)VALUES({subject.Name})");
            var res = _sqlConnection.Query<Subject>($"SELECT * FROM Subject Where Name ={subject.Name}").First();
            return res != null ? 1 : 0;
        }

        public Subject Update(Subject subject)
        {
            _sqlConnection.Query<Subject>(
                $"UPDATE Subject SET Name ='{subject.Name}'WHERE Name ={subject.Name}");
            return _sqlConnection.Query<Subject>($"SELECT * FROM Subject WHERE Name = {subject.Name}").First();
        }

        public int Delete(int id)
        {
            _sqlConnection.Query<Subject>($"DELETE * FROM Subject WHERE Id = {id}");
            var res = _sqlConnection.Query<Admin>($"SELECT * FROM Subject Where Id ={id}").First();
            return res != null ? 0 : 1;
        }
    }
}
