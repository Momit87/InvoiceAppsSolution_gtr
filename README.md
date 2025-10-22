# InvoiceApps
##### Internship Project  
<div align="center"><h3>Your .NET Web API & MVC Solution</h3></div>

## 📃 Table of Contents:
- [Introduction](#Introduction)  
- [Objective](#Objective)  
- [Setup Guide](#Setup_Guide)  
- [Working Procedure](#Working_Procedure)  
- [Technology Stack](#Technology_Stack)  
- [Usage](#Usage)  
- [Troubleshooting](#Troubleshooting)  
- [Contact](#Contact)  

---

## <h1 id="Introduction">Introduction</h1>  

InvoiceApps is a lightweight, educational web application that demonstrates a clean, decoupled .NET 8 architecture for building real-world CRUD systems. It combines an ASP.NET Core Web API (with ASP.NET Identity) and an ASP.NET Core MVC client (vanilla JavaScript / jQuery) so you can see how a modern server-side API and a classic server-rendered client interact in a professional, maintainable way.

This project intentionally focuses on practical patterns you’ll use in production:

A simple login system powered by ASP.NET Core Identity to show secure user authentication and role-aware routes.

A Repository Pattern to keep data access concerns separated and testable.

An MVC Client that uses vanilla JavaScript or jQuery to provide smooth, AJAX-driven UX while calling the Web API.

Master-detail management for Employees, Departments, and Designations — the client sends create/update/delete requests and the API performs those operations using Entity Framework Core.

A relational SQL Server (MSSQL) database as the canonical data store, with scripts for schema, seeding, and stored procedures where applicable.

Integration with a real external product API so the client can fetch and display product lists: https://www.pqstec.com/InvoiceApps/values/GetProductListAll.

Whether you’re learning how to structure a service-oriented .NET app, trying out repository and identity patterns, or preparing a basic full-stack demo to show employers, InvoiceApps ties those concepts together into a short, practical, and extendable codebase.

---

## <h2 id="Objective">Objective</h2>  

- Develop a scalable employee management API using ASP.NET Core Web API.
- Create a user-friendly frontend with ASP.NET Core MVC.
- Implement secure login system using Identity.
- Support file uploads and downloads related to employee records.
- Use EF Core and Dapper for efficient data operations.
- Document APIs using Swagger.

---

## <h2 id="Setup_Guide">Setup Guide</h2>  

### 1. Clone the Repository  
git clone https://github.com/Momit87/InvoiceAppsSolution_gtr
cd InvoiceApps


### 2. Configure the Database  
Run the SQL scripts in the `/sql` folder in this order:  
- `schema.sql`  
- `seed.sql`  
- `sprocstriggers.sql`

### 3. Update Connection Strings  
Open `InvoiceApps.Api/appsettings.json` and update `DefaultConnection` with your SQL Server instance details.

### 4. Build and Run the API  

cd InvoiceApps.Api
dotnet restore
cd InvoiceApps.Api
dotnet restore
dotnet build
dotnet run

### 5. Build and Run the MVC Client  

cd InvoiceApps.MvcClient
dotnet restore
dotnet build
dotnet run --urls "http://localhost:5002"



---

## <h2 id="Working_Procedure">Working Procedure</h2>  

- The API handles authentication, CRUD operations, and file processing.  
- The MVC client consumes these APIs asynchronously for dynamic UI updates.  
- Stored procedures and Dapper are used to optimize read operations.  
- Swagger UI is available for endpoint documentation and testing at `/swagger`.  

---

## <h2 id="Technology_Stack">Technology Stack</h2>  

- **Backend:** ASP.NET Core 8 Web API, Entity Framework Core, Dapper, SQL Server  
- **Frontend:** ASP.NET Core MVC, Razor Views, JavaScript (jQuery, AJAX)  
- **Authentication:** ASP.NET Core Identity  
- **Documentation:** Swagger (Swashbuckle)  
- **Database:** SQL Server with stored procedures and triggers  

---

## <h2 id="Usage">Usage</h2>  

- Open the MVC client at [http://localhost:5002](http://localhost:5002).  
- Perform CRUD on employees, departments, and designations.  
- Upload/download files attached to employee records.  
- Test API endpoints using Swagger UI at [https://localhost:5001/swagger](https://localhost:5001/swagger).

---

## <h2 id="Troubleshooting">Troubleshooting</h2>  

- If you get HTTPS certificate warnings, run:  

dotnet dev-certs https --trust


- To fix file upload issues, ensure the API app’s `/Uploads` folder exists and has write permissions.

---

## <h2 id="Contact">Contact</h2>  

**Name:** Momitul Hoque Chowdhury  
**Email:** [momituledu@gmail.com](mailto:momituledu@gmail.com)  

---

<div align="center">  
<h3>🚀 Ready to Manage Employees Efficiently?</h3>  
<p>Run the application locally and explore its features!</p>  
</div>

