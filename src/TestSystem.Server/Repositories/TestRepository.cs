using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Newtonsoft.Json;
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
            var face = new Test();
            var faceTest =  JsonConvert.SerializeObject(face);

            //TODO Ask about Content
            var idTeacher = _sqlConnection.Query<int>($"SELECT Id FROM Teacher WHERE FullName ='{test.Author}'").First();
            var idSubject = _sqlConnection.Query<int>($"SELECT Id FROM Subject WHERE Name = '{test.Subject}'").First();
            var query = $"INSERT INTO Test(Name, Id_Teacher,Id_Subject,Date, Content)VALUES('{test.Name}',{idTeacher},{idSubject},'{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}','{JsonConvert.SerializeObject(test)}' )";
             _sqlConnection.Query(query);
            var res = _sqlConnection.Query<int>($"SELECT * FROM Test Where Name ='{test.Name}'").First();//TODO test.id
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

        public IEnumerable<TestExam> GetExams()
        {
            var tests = _sqlConnection.Query<(int Id, string Content, int Result)>("SELECT Id, Content, TestResult as Result FROM Test");
            foreach (var test in tests)
            {
                var result = new TestExam
                {
                    Id = test.Id, 
                    BodyTest = JsonConvert.DeserializeObject<Test>(test.Content),
                    Result = test.Result,
                    IsAvailable = test.Result == 0
                };
                yield return result;
            }   
        }

        public void PassExam(TestExam test)
        {
            _sqlConnection.Execute(@"
                UPDATE Test 
                SET TestResult = @TestResult, 
                Date = @Now 
                WHERE Id = @Id", new
            {
                Id = test.Id,
                TestResult = test.Result,
                Now = DateTime.Now
            });
        }
    }
}
