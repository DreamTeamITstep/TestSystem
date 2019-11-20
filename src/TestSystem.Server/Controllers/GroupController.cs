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
    public class GroupController:ControllerBase

    {
        private readonly IGroupsRepository _groupsRepository;

        public GroupController(ILogger<AuthorController> logger, IGroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<Group> Get()
        {
            return _groupsRepository.Get();
        }

        [HttpGet("{id}")]
        public Group Get(int id)
        {
            return _groupsRepository.Get(id);
        }

        [HttpPost]
        public int Create(Group author)
        {
            return _groupsRepository.Create(author);
        }

        [HttpPut]
        public Group Update(Group author)
        {
            return _groupsRepository.Update(author);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _groupsRepository.Delete(id);
        }
    }
}
