using Microsoft.EntityFrameworkCore;
using System;

namespace BackendWinFormTenta
{
    public class DbContextMovie :DbContext
    {
        public virtual DbSet<Kund> kunder { get; set; }
        public virtual DbSet<Bokning> bokningar { get; set; }
        //bokning är en visning + en kund + en plats 

        public virtual DbSet<Film> filmer { get; set; }
        public virtual DbSet<Salong> salonger { get; set; }
        public virtual DbSet<Visning> visningar { get; set; }
        //Visning är en salong och film + en tid.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-6GH4TEP5\SQLEXPRESS;Database=winFormTentaFilmer;Trusted_Connection=True;MultipleActiveResultSets=true");
                optionsBuilder.UseLazyLoadingProxies();
            }
        }
    }
}
