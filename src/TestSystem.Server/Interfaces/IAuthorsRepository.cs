﻿using System.Collections.Generic;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public interface IAuthorsRepository
    {
        IEnumerable<Author> Get();
        Author Get(int id);
        int Create(Author author);
        Author Update(Author author);
        int Delete(int id);
    }
}
