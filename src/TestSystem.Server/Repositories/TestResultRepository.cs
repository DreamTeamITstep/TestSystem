using System.Collections.Generic;
using TestSystem.Common;

namespace WebApiServer.Repositories
{
    public class TestResultRepository:ITestResultsRepository
    {
        public IEnumerable<TestResult> Get()
        {
            throw new System.NotImplementedException();
        }

        public TestResult Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Create(TestResult testResult)
        {
            throw new System.NotImplementedException();
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
