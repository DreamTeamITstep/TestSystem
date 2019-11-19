using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public interface ITestExamRepository
    {
        IEnumerable<TestExam> Get();
        TestExam Get(int id);
        int Create(TestExam test);
        TestExam Update(TestExam test);
        int Delete(int id);
    }
}
