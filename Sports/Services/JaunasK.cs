using Sports.Data;

namespace Sports.Services
{
    public class JaunasK
    {
        private readonly ApplicationDbContext _dbcontext;
        public JaunasK(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<JaunasKurpes> DisplayJ()
        {
            return _dbcontext.Jaunumi.ToList();
        }
    }
}
