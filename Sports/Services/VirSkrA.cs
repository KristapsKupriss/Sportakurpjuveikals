using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sports.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace Sports.Services
{
    public class VirSkrA
    {
        protected readonly ApplicationDbContext _dbcontext;
        public VirSkrA(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<ViriesuSkriesanasApavi> DisplayVSA()
        {
            return _dbcontext.VSA.ToList();
        }
    }
}
