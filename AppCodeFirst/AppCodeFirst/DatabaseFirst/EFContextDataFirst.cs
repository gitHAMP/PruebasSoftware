namespace AppCodeFirst.DatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFContextDataFirst : DbContext
    {
        public EFContextDataFirst()
            : base("name=EFContextDataFirst")
        {
        }

        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.Task)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.AssignedTo_UserId);
        }
    }
}
