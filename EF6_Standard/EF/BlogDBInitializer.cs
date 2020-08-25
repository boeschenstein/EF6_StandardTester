using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EF6_DotNetStandard.EF
{
    public class BlogDBInitializer : DropCreateDatabaseAlways<BloggingDbContext>
    {
        public BlogDBInitializer()
        {
            Console.WriteLine("Creating new database now...");
        }

        protected override void Seed(BloggingDbContext context)
        {
            Console.WriteLine("Seeding now...");

            IList<Blogs> defaultStandards = new List<Blogs>();

            defaultStandards.Add(new Blogs() { Name = "Blog from database A " + DateTime.Now });
            defaultStandards.Add(new Blogs() { Name = "Blog from database B " + DateTime.Now });
            defaultStandards.Add(new Blogs() { Name = "Blog from database C " + DateTime.Now });

            context.Blogs.AddRange(defaultStandards);

            base.Seed(context);
        }
    }
}