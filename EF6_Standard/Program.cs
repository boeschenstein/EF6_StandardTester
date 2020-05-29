using System;

namespace EF6_DotNetStandard
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = new BloggingDbContext();
            foreach (var item in x.Blogs)
            {
                Console.WriteLine($"Blog: {item.BlogId} {item.Name}");
            }
        }
    }
}