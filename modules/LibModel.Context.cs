
namespace LibraryManagment.modules
{
    using Library_Manag.modules;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class libraryDBEntities : DbContext
    {
        public libraryDBEntities()
            : base("name=libraryDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Roll> Rolls { get; set; }
        public virtual DbSet<Shelf> Shelves { get; set; }
    }
}
