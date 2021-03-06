﻿using System;

namespace CoreConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World from .NET Core 3.1!");

            EF6_DotNetStandard.DatabaseAccess.InitializeDB();

            var x = new EF6_DotNetStandard.DatabaseAccess("data source=(localdb)\\mssqllocaldb;initial catalog=EF6test;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

            var items = x.GetAllBlogsFromConnectionString();
            foreach (var item in items)
            {
                Console.WriteLine($".NET Core 3.1 reads data from EF: Blog: {item.BlogId} {item.Name}");
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}