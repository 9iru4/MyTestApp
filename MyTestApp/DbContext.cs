namespace MyTestApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Empoyee> Empoyee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Department1)
                .WithOptional(e => e.Department2)
                .HasForeignKey(e => e.ParentDepartmentID);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Empoyee)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empoyee>()
                .Property(e => e.ID)
                .HasPrecision(5, 0);
        }
    }
}
