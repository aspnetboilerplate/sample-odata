# Sample OData usage with ASP.NET Boilerplate

* This is a sample project to show usage of OData within an ABP based application.
* It also shows how to host a Web API in an empty Web application.

# How to test

* Restore all nuget packages.
* Set AbpODataDemo.WebHost as startup project
* Perform a GET request to http://localhost:61842/odata/Persons to get list of people.
* Perform a GET request to http://localhost:61842/odata/$metadata#Persons to get person metadata.
