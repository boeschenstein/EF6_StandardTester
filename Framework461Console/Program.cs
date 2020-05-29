using System;

namespace Framework461Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World from .net framework 4.6.1!");

            EF6_DotNetStandard.DatabaseAccess.InitializeDB();

            var x = new EF6_DotNetStandard.DatabaseAccess("data source=(localdb)\\mssqllocaldb;initial catalog=EF6test;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            //var x = new EF6_Framework461.DatabaseAccess();
            var items = x.GetAllBlogsFromConnectionString();
            foreach (var item in items)
            {
                Console.WriteLine($".net framework 4.6.1 says: Blog: {item.BlogId} {item.Name}");
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}