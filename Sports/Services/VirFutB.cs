using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sports.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace Sports.Services
{
    public class VirFutB
    {
        protected readonly ApplicationDbContext _dbcontext;
        public VirFutB(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<Viriesufutbolabuci> DisplayVFB()
        {
            return _dbcontext.VFB.ToList();
        }
    }
}
