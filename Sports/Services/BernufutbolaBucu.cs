﻿using Sports.Data;


namespace Sports.Services
{
    public class BernufutbolaBucu
    {
        private readonly ApplicationDbContext _dbcontext;
        public BernufutbolaBucu(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<Bernufutbolabuci> DisplayBFB()
        {
            return _dbcontext.BFB.ToList();
        }
    }
}

