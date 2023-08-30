| Name          | Description   |
| ------------- | ------------- |
| Northwind.Common | A class library project for common types like interfaces, enums, classes, records, and structs, used across multiple projects.  |
| Northwind.Common.EntityModels  | A class library project for common EF Core entity models. Entity models are often used on both the server and clientside, so it is best to separate dependencies on specific database providers.  |
| Northwind.Common.DataContext  | A class library project for the EF Core database context with dependencies on specific database providers.  |
| Northwind.Web  | An ASP.NET Core project for a simple website that uses a mixture of static HTML files and dynamic Razor Pages.  |
| Northwind.Razor.Component  | A class library project for Razor Pages used in multiple projects.  |
| Northwind.Mvc  | An ASP.NET Core project for a complex website that uses the MVC pattern and can be more easily unit tested.  |
| Northwind.WebApi  | An ASP.NET Core project for an HTTP API service. A good choice for integrating with websites because it can use any JavaScript library or Blazor to interact with the service.  |
| Northwind.BlazorServer  | An ASP.NET Core Blazor Server project. |
| Northwind.BlazorWasm.Client  | An ASP.NET Core Blazor WebAssembly client-side project.  |
| Northwind.BlazorWasm.Server  | An ASP.NET Core Blazor WebAssembly server-side project.  |
