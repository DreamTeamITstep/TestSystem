﻿using System.Collections.Generic;
using TestSystem.Common;

namespace WebApiServer.Repositories
{
    public interface ITestsRepository
    {
        IEnumerable<Test> Get();
        Test Get(int id);
        int Create(Test test);
        Test Update(Test test);
        int Delete(int id);
    }
}
