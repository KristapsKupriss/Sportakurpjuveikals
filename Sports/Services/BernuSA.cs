using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sports.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace Sports.Services
{
    public class BernuSA
    {
        protected readonly ApplicationDbContext _dbcontext;
        public BernuSA(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<BernuSkriesanasApavics> DisplayBSA()
        {
            return _dbcontext.BSA.ToList();
        }
    }
}