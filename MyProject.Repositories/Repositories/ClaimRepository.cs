using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContext _context;

        public ClaimRepository(IContext context)
        {
            _context = context;
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            return _context.Claims.Find(c => c.Id == id);
        }

        public Claim Add(int id, int roleId, int permissionId, EPolicy policy)
        {
            Claim c = new Claim();
            c.Id = id;
            c.RoleId = roleId;
            c.PermissionId = permissionId;
            c.Policy = policy;
            _context.Claims.Add(c);
            return c;
        }

        public Claim Update(Claim claim)
        {
            var c = _context.Claims.Find(c => c.Id == claim.Id);
            c.Id = claim.Id;
            c.PermissionId = claim.PermissionId;
            c.Policy = claim.Policy;
            c.RoleId = claim.RoleId;
            return c;
        }

        public void Delete(int id)
        {
            _context.Claims.Remove(_context.Claims.Find(c => c.Id == id));
        }

    }
}
