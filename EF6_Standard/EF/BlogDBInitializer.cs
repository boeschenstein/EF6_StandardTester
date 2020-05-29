using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EF6_DotNetStandard.EF
{
    public class BlogDBInitializer : DropCreateDatabaseAlways<BloggingDbContext>
    {
        public BlogDBInitializer()
        {
            Console.WriteLine("create new database now...");
        }

        protected override void Seed(BloggingDbContext context)
        {
            Console.WriteLine("seeding now...");

            IList<Blogs> defaultStandards = new List<Blogs>();

            defaultStandards.Add(new Blogs() { Name = "Blog from database A" });
            defaultStandards.Add(new Blogs() { Name = "Blog from database B" });
            defaultStandards.Add(new Blogs() { Name = "Blog from database C" });

            context.Blogs.AddRange(defaultStandards);

            base.Seed(context);
        }
    }
}