using System;
using System.Collections.Generic;
using TestSystem.Common;

namespace TestSystem.Server.Repositories
{
    public class AuthorsRepository:IAuthorsRepository
    {
        public IEnumerable<Author> Get()
        {
            throw new NotImplementedException();
        }

        public Author Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Create(Author author)
        {
            throw new NotImplementedException();
        }

        public Author Update(Author author)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
