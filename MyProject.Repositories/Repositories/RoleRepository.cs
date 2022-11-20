using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{

    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;

        public RoleRepository(IContext context)
        {
            _context = context;
        }

        public Role Add(int id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _context.Roles.Remove(GetById(id));
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            return _context.Roles.Find(r => r.Id == id);
        }

        public Role Update(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
