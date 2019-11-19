using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestSystem.Common;
using WebApiServer.Repositories;

namespace WebApiServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectController
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectController(ILogger<SubjectController> logger, ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<Subject> Get()
        {
            return _subjectRepository.Get();
        }

        [HttpGet("{id}")]
        public Subject Get(int id)
        {
            return _subjectRepository.Get(id);
        }

        [HttpPost]
        public int Create(Subject subject)
        {
            return _subjectRepository.Create(subject);
        }

        [HttpPut]
        public Subject Update(Subject subject)
        {
            return _subjectRepository.Update(subject);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _subjectRepository.Delete(id);
        }
    }
}
