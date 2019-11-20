using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestSystem.Common;
using TestSystem.Server.Repositories;

namespace TestSystem.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController
    {
        private readonly ITestsRepository _testsRepository;
        public TestController(ILogger<TestController> logger, ITestsRepository testsRepository)
        {
            _testsRepository = testsRepository;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<Test> Get()
        {
            return _testsRepository.Get();
        }

        [HttpGet("exam")]
        public IEnumerable<TestExam> GetExam()
        {
            return _testsRepository.GetExams();
        }

        [HttpPost("exam")]
        public void PassExam([FromBody]TestExam testExam)
        { 
            _testsRepository.PassExam(testExam);
        }

        [HttpGet("{id}")]
        public Test Get(int id)
        {
            return _testsRepository.Get(id);
        }

        [HttpPost]
        public int Create(Test test)
        {
            return _testsRepository.Create(test);
        }

        [HttpPut]
        public Test Update(Test test)
        {
            return _testsRepository.Update(test);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _testsRepository.Delete(id);
        }
    }
}
