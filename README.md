# Entity Framework Test (testoef)
This repository contains the result of some exploratory programming to demonstrate the [Entity Framework 6](https://msdn.microsoft.com/en-us/data/ee712907.aspx) Code First capability to map complex, in-memory objects to existing, flat, denormalized, database tables.  In the process, other principles and best practices are also demonstrated.

## Features
The ef-api Visual Studio solution contains examples of how to do the following:

* Map complex types to flat database structures using the Entity Framework Code First fluent API.
* Organize code using the Onion Architecture (and Domain Driven Design).
* Implement the IRepository pattern for aggregated roots (DDD concept).
* Implement a RESTful API using ASP.NET MVC.
* Implement dependency injection (DI) using Microsoft Unity.
* Map collections of objects using AutoMapper.
* Utlize the Arrange, Act, Assert pattern in unit / integration tests.

## Deployment Instructions
### Get the code

1. Fork your own copy of the walterpinson/testoef repository to your own account.
1. Clone your forked repository to your local machine.
1. Build the solution.

### Add database support
1. Create a new SQL Server database on your local machine (or accessible server).
1. Run the script, `_scripts/create.table.registration.sql`, against your newly created database.
1. Create a new SQL Server login giving it dbo and db_datawriter permissions to your new database.
1. Modify the connection string named `test` to the appropriate string for your environment in the following files:
	1. `ef-api/web.config`
    1. `Test.Integration.Infrastructure.Data.Sql/App.config`
1. Run the integration tests to make sure that everything is working properly.

### Start the API
You can start the API by simply running the **ef-api** project in the Visual Studio debugger.

## Make API calls
You should, now, be able to test the live API by issuing GET and POST requests the API endpoint, http://localhost:4315/api/registrations.
