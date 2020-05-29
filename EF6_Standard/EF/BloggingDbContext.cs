namespace EF6_DotNetStandard
{
    using System.Data.Entity;
    using EF6_DotNetStandard.EF;

    public partial class BloggingDbContext : DbContext
    {
        public BloggingDbContext()
            : base("name=BloggingContext")
        {
            // Database.SetInitializer(new BlogDBInitializer());
        }

        public BloggingDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}