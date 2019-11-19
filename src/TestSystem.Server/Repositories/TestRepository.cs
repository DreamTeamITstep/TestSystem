using System.Collections.Generic;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public class TestRepository:ITestsRepository
    {
        public IEnumerable<Test> Get()
        {
            throw new System.NotImplementedException();
        }

        public Test Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Create(Test test)
        {
            throw new System.NotImplementedException();
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
