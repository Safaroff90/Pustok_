using Microsoft.EntityFrameworkCore;
using Pustok.Models;

namespace Pustok.DAL
{
    public class PustokDbContext:DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext> opt) : base(opt)
        {

        }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<BtmPromotions> BtmPromotions { get; set; }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<TopPromotions> TopPromotions { get; set; }



    }
}
