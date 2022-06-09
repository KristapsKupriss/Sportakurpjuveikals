using Sports.Data;


namespace Sports.Services
{
    public class VKurp
    {
        private readonly ApplicationDbContext _dbcontext;
        public VKurp(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<VirKurpes> DisplayV()
        {
            return _dbcontext.V.ToList();
        }
    }
}