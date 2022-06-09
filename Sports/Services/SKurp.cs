using Sports.Data;


namespace Sports.Services
{
    public class SKurp
    {
        private readonly ApplicationDbContext _dbcontext;
        public SKurp(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<SievKurpes> DisplayS()
        {
            return _dbcontext.S.ToList();
        }
    }
}