using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public List<Role> Get(string status)
        {
            return _roleService.GetList();
        }

        [HttpGet("{id}")]
        public Role Get(int id)
        {
            return _roleService.GetById(id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           // _roleService.Delete(id);
        }

        [HttpPost]
        public Role Post([FromBody]RoleModel model)
        {
            return new Role { Id = model.Id };
        }
    }
}

