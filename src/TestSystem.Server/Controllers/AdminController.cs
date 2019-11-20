using System;
using System.Collections.Generic;
using System.Linq;
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
            //example of how to extract user id and role base on token
            var userId = Convert.ToInt32(User.Identity.Name);
            var role = User.Claims
                .First(c => c.Type.Equals("http://schemas.microsoft.com/ws/2008/06/identity/claims/role")).Value;
            
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
