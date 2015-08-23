# Getting Started

Enter text in [Markdown](http://daringfireball.net/projects/markdown/). Use the toolbar above, or click the **?** button for formatting help.


## Features

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
You can start the API by simply running the **ef-api** project in the debugger.

## Make API calls
You should, now, be able to test the live API by issuing GET and POST requests the API endpoint, http://localhost:4315/api/registrations.
