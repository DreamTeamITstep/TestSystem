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
    public class StudentController
    {
        private readonly IStudentsRepository _studentsRepository;

        public StudentController(ILogger<StudentController> logger, IStudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentsRepository.Get();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _studentsRepository.Get(id);
        }

        [HttpPost]
        public int Create(Student student)
        {
            return _studentsRepository.Create(student);
        }

        [HttpPut]
        public Student Update(Student student)
        {
            return _studentsRepository.Update(student);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _studentsRepository.Delete(id);
        }
    }
}
