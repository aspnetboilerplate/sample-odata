# Sample OData usage with ASP.NET Boilerplate

* This is a sample project to show usage of OData within an ABP based application. It uses Abp.AspNetCore.OData nuget package (https://www.nuget.org/packages/Abp.AspNetCore.OData)
* It also shows how to host a Web API in an empty web application.

## How to test

* Restore all nuget packages.
* Set __AbpODataDemo.Web.Host__ as startup project
* Open Package Manager Console, set __AbpODataDemo.EntityFrameworkCore__ as default project and run __Update-Database__ command.
* Run the application.
* Perform a GET request to __http://localhost:62114/odata/Persons__ to get list of people.
* Perform a GET request to __http://localhost:62114/odata/$metadata#Persons__ to get person metadata.

## Documentation

See http://aspnetboilerplate.com/Pages/Documents/OData-Integration
