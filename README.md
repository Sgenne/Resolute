Resolute is a class library containing generic results and related utilities. The project is inspired by Haskells Either monad and the .NET package FluentResults. 

When working on my own projects in .NET, I prefer wrapping the outcome of an operation in a result object that represents the success or failure of the action, rather than throwing exceptions in case of failure. While I tried using FluentResults, I found that it didn’t meet my exact needs. As a result, I decided to create my own result types.

Over time, I found myself recreating the same classes and methods in multiple projects. I thus decided to separate these types and utilities into package that I can add using NuGet.

This is very much a work in progress and is intended for use only in my personal side projects. It should not be used in production or real projects.
