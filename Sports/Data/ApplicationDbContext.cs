using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace Sports.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }
        public virtual DbSet<Bernufutbolabuci> BFB { get; set; }
        public virtual DbSet<Sieviesufutbolabuci> SFB { get; set; }
        public virtual DbSet<Viriesufutbolabuci> VFB { get; set; }
        public virtual DbSet<BernuSportaKurpes> B { get; set; }
        public virtual DbSet<BernuSkriesanasApavics> BSA { get; set; }
        public virtual DbSet<SieviesuSkriesanasApavi> SSA { get; set; }
        public virtual DbSet<ViriesuSkriesanasApavi> VSA { get; set; }
        public virtual DbSet<VirKurpes> V { get; set; }
        public virtual DbSet<SievKurpes> S { get; set; }


    }
}
