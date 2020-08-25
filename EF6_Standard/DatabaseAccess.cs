using System;
using System.Collections.Generic;
using System.Data.Entity;
using EF6_DotNetStandard.EF;

namespace EF6_DotNetStandard
{
    public class DatabaseAccess
    {
        private readonly string connectionString;

        public DatabaseAccess()
        {
        }

        public DatabaseAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public static void InitializeDB()
        {
            Database.SetInitializer(new BlogDBInitializer());
        }

        private void HackForMissingDll()
        {
            // https://stackoverflow.com/questions/14033193/entity-framework-provider-type-could-not-be-loaded
            var dummy1 = typeof(System.Data.Entity.SqlServer.SqlProviderServices);

            // https://stackoverflow.com/questions/14033193/entity-framework-provider-type-could-not-be-loaded
            // var dummy2 = typeof(System.Configuration.ConfigurationManager);

            // https://stackoverflow.com/questions/14033193/entity-framework-provider-type-could-not-be-loaded
            // var dummy3 = typeof(System.Data.SqlClient.ApplicationIntent);
        }

        public IEnumerable<Blog> GetAllBlogs()
        {
            HackForMissingDll();

            var x = new BloggingDbContext();
            foreach (var item in x.Blogs)
            {
                Console.WriteLine($".NET Standard dll says: Blog: {item.BlogId} {item.Name}");
                yield return new Blog { BlogId = item.BlogId, Name = item.Name };
            }
        }

        public IEnumerable<Blog> GetAllBlogsFromConnectionString()
        {
            HackForMissingDll();

            var x = new BloggingDbContext(connectionString);
            foreach (var item in x.Blogs)
            {
                Console.WriteLine($".NET Standard dll says: Blog: {item.BlogId} {item.Name}");
                yield return new Blog { BlogId = item.BlogId, Name = item.Name };
            }
        }
    }
}