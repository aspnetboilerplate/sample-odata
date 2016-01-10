# Sample OData usage with ASP.NET Boilerplate

* This is a sample project to show usage of OData within an ABP based application. It uses Abp.Web.Api.OData nuget package (https://www.nuget.org/packages/Abp.Web.Api.OData)
* It also shows how to host a Web API in an empty web application.

## How to test

* Restore all nuget packages.
* Set __AbpODataDemo.WebHost__ as startup project
* Open Package Manager Console, set __AbpODataDemo.EntityFramework__ as default project and run __Update-Database__ command.
* Run the application.
* Perform a GET request to __http://localhost:61842/odata/Persons__ to get list of people.
* Perform a GET request to __http://localhost:61842/odata/$metadata#Persons__ to get person metadata.
