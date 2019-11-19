using System.Collections.Generic;
using TestSystem.Common;

namespace WebApiServer.Repositories
{
    public interface ITestResultsRepository
    {
        IEnumerable<TestResult> Get();
        TestResult Get(int id);
        int Create(TestResult testResult);
        TestResult Update(TestResult testResult);
        int Delete(int id);
    }
}
