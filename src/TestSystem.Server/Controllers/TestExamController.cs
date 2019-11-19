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
    public class TestExamController
    {
        private readonly ITestExamRepository _testExamRepository;
        public TestExamController(ILogger<TestExamController> logger, ITestExamRepository testsRepository)
        {
            _testExamRepository = testsRepository;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<TestExam> Get()
        {
            return _testExamRepository.Get();
        }

        [HttpGet("{id}")]
        public TestExam Get(int id)
        {
            return _testExamRepository.Get(id);
        }

        [HttpPost]
        public int Create(TestExam test)
        {
            return _testExamRepository.Create(test);
        }

        [HttpPut]
        public TestExam Update(TestExam test)
        {
            return _testExamRepository.Update(test);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _testExamRepository.Delete(id);
        }
    }
}
