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
    public class AdminController: ControllerBase
    {
        private readonly IAdminsRepository _adminsRepository;

        public AdminController(ILogger<AdminController> logger, IAdminsRepository adminsRepository)
        {
            _adminsRepository = adminsRepository;
        }

        [Authorize(Roles = Constants.AdminRole)]
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return _adminsRepository.Get();
        }
        [HttpGet("{id}")]
        public Admin Get(int id)
        {
            return _adminsRepository.Get(id);
        }

        [HttpPost]
        public int Create(Admin admin)
        {
            return _adminsRepository.Create(admin);
        }

        [HttpPut]
        public Admin Update(Admin admin)
        {
            return _adminsRepository.Update(admin);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _adminsRepository.Delete(id);
        }
    }
}
