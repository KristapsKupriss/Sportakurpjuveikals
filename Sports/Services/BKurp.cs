using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sports.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace Sports.Services
{
    public class BKurp
    {
        private readonly ApplicationDbContext _dbcontext;
        public BKurp(ApplicationDbContext _db)
        {
            this._dbcontext = _db;
        }
    public List<BernuSportaKurpes> DisplayB()
        {
            return _dbcontext.B.ToList();
        }
    }
}