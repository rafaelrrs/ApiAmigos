using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAmigos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Amigo> Amigos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amigo>()
                .Property(p => p.Name)
                    .HasMaxLength(80);

            modelBuilder.Entity<Amigo>()
                .Property(p => p.Cpf)
                    .HasMaxLength(11);

            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            modelBuilder.Entity<Amigo>()
                .HasData(
                    new Amigo { Id = 1, Name = "Rafael", DataNascimento = date1, NameMother = "Nome do Mãe 1", NameDad = "Nome do Pai 1", Cpf = 8527410},
                    new Amigo { Id = 2, Name = "Rafa", DataNascimento = date1, NameMother = "Nome do Mãe 2", NameDad = "Nome do Pai 2", Cpf = 0148522},
                    new Amigo { Id = 3, Name = "Leafar", DataNascimento = date1, NameMother = "Nome do Mãe 3", NameDad = "Nome do Pai 3", Cpf = 36936936}
                );
        }
    }


}
