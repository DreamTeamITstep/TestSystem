﻿using System.Collections.Generic;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public interface IStudentsRepository
    {
        IEnumerable<Student> Get();
        Student Get(int id);
        int Create(Student student);
        Student Update(Student student);
        int Delete(int id);
    }
}
