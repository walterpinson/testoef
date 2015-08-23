# Entity Framework Test (testoef)
This repository contains the result of some exploratory programming to demonstrate the [Entity Framework 6](https://msdn.microsoft.com/en-us/data/ee712907.aspx) Code First capability to map complex, in-memory objects to existing, flat, denormalized, database tables.  In the process, other principles and best practices are also demonstrated.

## Features
The ef-api Visual Studio solution contains examples of how to do the following:

* Map complex types to flat database structures using the Entity Framework Code First fluent API.
* Utilize EF Code First **without** migrations.
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

## <a name="callapi"/>Make API calls
You should, now, be able to test the live API by issuing GET and POST requests the API endpoint, http://localhost:4315/api/registrations.  The examples below use curl. But, you should feel free to use the API client of your choosing be that PostMan, Fiddler, or what have you.

### POST
#### Request
```
curl -H "Content-Type: application/json" -H "Accept-Charset: utf-8" --data @- http://localhost:4315/api/registrations
{
    "FirstName": "Benjamin",
    "LastName": "Fraklin",
    "Message": "Money makes money. And the money that money makes, makes more money."
}
```
#### Response
```
Cache-Control → no-cache
Content-Length → 2
Content-Type → application/json; charset=utf-8
Date → Sun, 23 Aug 2015 19:19:32 GMT
Expires → -1
Location → http://localhost:4315/api/registrations/199dee7e-54b4-4c29-a76a-d7675511b78b
Pragma → no-cache
Server → Microsoft-IIS/8.0
X-AspNet-Version → 4.0.30319
X-Powered-By → ASP.NET
```
### GET
#### Request
```
curl -H "Content-Type: application/json" -H "Accept-Charset: utf-8" http://localhost:4315/api/registrations
```
#### Response
```json
[
  {
    "Id": "73b91972-77c3-4d92-85d3-353c07454ef8",
    "FirstName": "Jimmie",
    "LastName": "Hendrix",
    "RespondedOn": "2015-08-22T03:54:33.9630846"
  },
  {
    "Id": "5ba22a54-7aa7-4b4b-ba86-388a8ac07066",
    "FirstName": "Doc",
    "LastName": "Holiday",
    "RespondedOn": "2015-08-19T23:38:16.873015"
  },
  {
    "Id": "7f85f148-1796-4962-a8e3-b3d63d3aaa38",
    "FirstName": "Prince",
    "LastName": "Nelson",
    "RespondedOn": "2015-08-20T16:25:19.6040775"
  },
  {
    "Id": "d16635a8-cc07-421d-a34c-c538145efefc",
    "FirstName": "Patrick",
    "LastName": "Henry",
    "RespondedOn": "2015-08-20T00:28:49.1465767"
  }
]
```
