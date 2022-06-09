using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sports.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace Sports.Services
{
    public class SievSkrA
    {
        protected readonly ApplicationDbContext _dbcontext;
        public SievSkrA(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<SieviesuSkriesanasApavi> DisplaySSA()
        {
            return _dbcontext.SSA.ToList();
        }
    }
}
