using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sports.Data;
using Microsoft.EntityFrameworkCore;

namespace Sports.Services
{
    public class BernufutbolaBucu
    {
        protected readonly ApplicationDbContext _dbcontext;

        public BernufutbolaBucu(ApplicationDbContext _db)
        {
            this._dbcontext = _db;
        }
        public List<Bernufutbolabuci> DisplayBFB()
        {
            return _dbcontext.BFB.ToList();
        }

    }
}
