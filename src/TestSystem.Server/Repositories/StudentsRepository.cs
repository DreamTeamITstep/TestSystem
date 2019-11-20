using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly SqlConnection _sqlConnection;

        public StudentsRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public IEnumerable<Student> Get()
        {
            return _sqlConnection.Query<Student>("SELECT Id, FullName, Id_Role as RoleId, Id_Group as GroupId, Password FROM Student");
        }

        public Student Get(int id)
        {
            return _sqlConnection.Query<Student>($"SELECT * FROM Student Where Id ={id}").First();
        }

        public int Create(Student student)
        {
            _sqlConnection.Query<Student>(
                $"INSERT INTO Student(FullName, Id_Role, Password, Id_Group )VALUES({student.FullName},{student.RoleId},{student.Password},{student.GroupId})");
            var res = _sqlConnection.Query<Student>($"SELECT * FROM Student Where FullName ={student.FullName}").First();
            return res != null ? 1 : 0;
        }

        public Student Update(Student student)
        {
            var res = _sqlConnection.Query<Student>($"SELECT * FROM Student WHERE FullName = '{student.FullName}'");
            if (res != null)
            {
                _sqlConnection.Query<Student>(
                    $"UPDATE Student SET FullName ='{student.FullName}',Id_Role ='{student.RoleId}', Id_Group = '{student.GroupId}',Password = '{student.Password}'WHERE FullName ={student.FullName}");
                return _sqlConnection.Query<Student>($"SELECT * FROM Student WHERE FullName = {student.FullName}")
                    .First();
            }
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            _sqlConnection.Query<Student>($"DELETE * FROM Student WHERE Id = {id}");
            var res = _sqlConnection.Query<Student>($"SELECT * FROM Student Where Id ={id}").First();
            return res != null ? 0 : 1;
        }
    }
}
