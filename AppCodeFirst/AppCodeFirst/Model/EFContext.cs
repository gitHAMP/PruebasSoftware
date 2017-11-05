namespace AppCodeFirst.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class EFContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Task> Task { get; set; }
        public EFContext()
            : base("name=EFContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();

            #region User
            modelBuilder.Entity<User>()
               .Property(x => x.FirstName)
               .HasMaxLength(50)
               .IsRequired();

            modelBuilder.Entity<User>()
               .Property(x => x.LastName)
               .HasMaxLength(50)
               .IsRequired();
            #endregion

            #region Task
            modelBuilder.Entity<Task>()
               .Property(x => x.Title)
               .HasMaxLength(50)
               .IsRequired();
            #endregion

        }
    }

    
}