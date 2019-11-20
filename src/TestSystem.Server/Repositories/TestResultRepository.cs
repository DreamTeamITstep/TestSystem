using Dapper;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public class TestResultRepository:ITestResultsRepository
    {
        private readonly SqlConnection _sqlConnection;
        public TestResultRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public IEnumerable<TestResult> Get()
        {
            return _sqlConnection.Query<TestResult>("SELECT * FROM TestResult");
        }

        public TestResult Get(int id)
        {
            return _sqlConnection.Query<TestResult>($"SELECT * FROM TestResult Where Id ={id}").First();
        }

        public int Create(TestResult testResult)
        {
            //TODO Ask about Content
            var idStudent = _sqlConnection.Query<Student>($"SELECT Id FROM Atudent WHERE Id ='{testResult.IdStudent}'").First();
            var idTest = _sqlConnection.Query<Test>($"SELECT Id FROM Test WHERE Id = '{testResult.IdTest}'").First();
            _sqlConnection.Query<TestResult>(
                $"INSERT INTO Test(Date, Id_Student,Id_Test, Content)VALUES({testResult.Date},{idStudent},{idTest},{JsonConvert.SerializeObject(testResult)} )");
            var res = _sqlConnection.Query<TestResult>($"SELECT * FROM TestResult Where Id ={testResult.Id}").First();
            return res != null ? 1 : 0;
        }

        public TestResult Update(TestResult testResult)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
