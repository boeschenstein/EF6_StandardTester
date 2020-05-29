# EF6_StandardTester

dll as EF 6 in .NET Standard. Test Clients for .NET Framework 4.6.1 and .NET Standard 2.1

## What I need

I need a .NET dll which calls EF 6 and needs do be consumed from .NET Framework 4.6.1 and .NET Core 3.1.

## .NET Standard

According [.NET Standard documentation](https://docs.microsoft.com/en-us/dotnet/standard/net-standard), .NET Standard 2.1 is not compatible with .NET Framework.

## Issue: cannot compile dll to .NET Standard 2.0

Question: why is my .NET Standard 2.0 dll with EF6 (EF6_Standard) not compiling with .NET Standard 2.0?

On the other hand, the EF Team gives a different [answer](https://devblogs.microsoft.com/dotnet/announcing-entity-framework-6-3-preview-with-net-core-support/):

Question: I would like to adopt this by sharing my “Model” project which contain by DBContext and is currently being used by .net 4.6 with a .net core v3 app.  
Would I need to uprgade my “Model” project to be on .net standard, so that both my new .net core v3 projects and my .net 4 projects can co-exist?

Answer: Diego Vega (Microsoft) May 16, 2019 1:24:
To do this, you can create a library project that targets both .NET 4.5 and .NET Standard 2.1. 
