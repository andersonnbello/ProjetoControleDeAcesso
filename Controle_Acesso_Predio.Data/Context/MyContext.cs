using Controle_Acesso_Predio.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Controle_Acesso_Predio.Data.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<ControlPerson> ControlPerson { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ControlPerson>().HasKey(x => x.Id);
            modelBuilder.Entity<ControlPerson>().Property(x => x.Id).HasColumnName("Id").UseIdentityColumn();
            modelBuilder.Entity<ControlPerson>().Property(x => x.IdPerson).HasColumnName("IdPerson");
            modelBuilder.Entity<ControlPerson>().Property(x => x.Date).HasColumnName("Date").HasColumnType("datetime");
            modelBuilder.Entity<ControlPerson>().HasMany(x => x.Persons).WithOne(x => x.ControlPerson);

            modelBuilder.Entity<Person>().HasKey(x => x.Id);
            modelBuilder.Entity<Person>().Property(x => x.Id).HasColumnName("Id").UseIdentityColumn();
            modelBuilder.Entity<Person>().Property(x => x.Document).HasColumnName("Document");
            modelBuilder.Entity<Person>().Property(x => x.Name).HasColumnName("Name");
            modelBuilder.Entity<Person>().Property(x => x.Phone).HasColumnName("Phone");
            modelBuilder.Entity<Person>().HasOne(x => x.ControlPerson).WithMany(x => x.Persons);

            base.OnModelCreating(modelBuilder);
        }
    }
}
