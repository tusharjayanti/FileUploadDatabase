namespace FileUploadDatabase.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=tblFiles")
        {
        }

        public virtual DbSet<tblFile> tblFiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblFile>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
