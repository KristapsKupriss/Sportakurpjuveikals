using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sports.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace Sports.Services
{
    public class SievFutB
    {
        protected readonly ApplicationDbContext _dbcontext;
        public SievFutB(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<Sieviesufutbolabuci> DisplaySFB()
        {
            return _dbcontext.SFB.ToList();
        }
    }
}
