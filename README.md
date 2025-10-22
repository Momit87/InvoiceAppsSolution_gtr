<!DOCTYPE html>
<html lang="en" class="dark">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale-1.0">
    <title>InvoiceApps Solution README</title>
    <!-- Import Tailwind CSS -->
    <script src="https://cdn.tailwindcss.com"></script>
    
    <!-- Import Inter font -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600;700;800&display=swap" rel="stylesheet">
    
    <style>
        /* Use Inter as the default font */
        body {
            font-family: 'Inter', sans-serif;
        }
        
        /* Style for inline code */
        code:not(pre code) {
            @apply bg-gray-700 text-pink-400 px-2 py-0.5 rounded-md font-mono text-sm;
        }

        /* Style for list markers */
        li::marker {
            @apply text-blue-400;
        }
    </style>
</head>
<body class="bg-gray-900 text-gray-100 antialiased">

    <!-- Main Content Container -->
    <div class="max-w-5xl mx-auto p-6 sm:p-10 bg-gray-800 rounded-lg shadow-2xl my-10 border border-gray-700">

        <!-- Header -->
        <header class="mb-10">
            <h1 class="text-4xl sm:text-5xl font-extrabold text-blue-400 mb-3">InvoiceApps Solution</h1>
            <p class="text-lg sm:text-xl text-gray-300">
                This repository contains the solution for the "INTERN ASP.NET" assignment for <strong>Genuine Technology & Research Ltd.</strong> It is a .NET 8 application demonstrating a decoupled architecture with an ASP.NET Core Web API backend and an ASP.NET Core MVC client.
            </p>
        </header>

        <!-- Overview Section -->
        <section>
            <h2 class="text-3xl font-bold text-white border-b-2 border-blue-500 pb-2 mb-6 mt-12">Overview</h2>
            <p class="text-gray-300 text-base leading-relaxed mb-6">
                The solution implements a simple employee management system. It consists of two main projects:
            </p>
            <ol class="list-decimal list-inside space-y-3 text-gray-300 text-base">
                <li><strong class="font-semibold text-white">InvoiceApps.Api:</strong> A .NET 8 Web API backend responsible for all data operations (CRUD), user authentication, and business logic.</li>
                <li><strong class="font-semibold text-white">InvoiceApps.MvcClient:</strong> A .NET 8 MVC client application that consumes the API, providing a user interface for managing employees, departments, and designations. It also integrates a third-party API.</li>
            </ol>
        </section>

        <!-- Features Section -->
        <section>
            <h2 class="text-3xl font-bold text-white border-b-2 border-blue-500 pb-2 mb-6 mt-12">Features</h2>
            
            <h3 class="text-2xl font-semibold text-gray-200 mt-8 mb-4">Backend (InvoiceApps.Api)</h3>
            <ul class="list-disc list-inside space-y-2 text-gray-300">
                <li><strong class="font-semibold text-white">RESTful API:</strong> Full CRUD (Create, Read, Update, Delete) operations for Employees, Departments, and Designations.</li>
                <li><strong class="font-semibold text-white">Authentication:</strong> Simple user login and management using <code>ASP.NET Core Identity</code>.</li>
                <li><strong class="font-semibold text-white">File Handling:</strong> API endpoints for uploading and downloading files.</li>
                <li><strong class="font-semibold text-white">API Documentation:</strong> <code>Swagger UI</code> enabled for easy API testing and documentation.</li>
                <li><strong class="font-semibold text-white">CORS:</strong> Configured to allow requests from the MVC client.</li>
            </ul>

            <h3 class="text-2xl font-semibold text-gray-200 mt-8 mb-4">Data Access</h3>
            <ul class="list-disc list-inside space-y-2 text-gray-300">
                <li><strong class="font-semibold text-white">Repository Pattern:</strong> Abstracts data access logic for cleaner, more maintainable code.</li>
                <li><strong class="font-semibold text-white">Hybrid ORM Strategy:</strong>
                    <ul class="list-disc list-inside space-y-2 text-gray-300 ml-6 mt-2">
                        <li><strong class="font-semibold text-white">Entity Framework Core:</strong> Used for all write operations (Insert, Update, Delete).</li>
                        <li><strong class="font-semibold text-white">Dapper & ADO.NET:</strong> Used for all read operations via <code>SQL Stored Procedures</code> for optimized performance.</li>
                    </ul>
                </li>
                <li><strong class="font-semibold text-white">Database:</strong> Includes SQL scripts for schema, seed data, stored procedures, and triggers.</li>
            </ul>

            <h3 class="text-2xl font-semibold text-gray-200 mt-8 mb-4">Frontend (InvoiceApps.MvcClient)</h3>
            <ul class="list-disc list-inside space-y-2 text-gray-300">
                <li><strong class="font-semibold text-white">Modern UI:</strong> Built with ASP.NET Core MVC and Razor Views.</li>
                <li><strong class="font-semibold text-white">AJAX-Driven:</strong> Uses vanilla JavaScript/jQuery for asynchronous CRUD operations, providing a smooth user experience without full-page reloads.</li>
                <li><strong class="font-semibold text-white">External API Integration:</strong> Fetches and displays a product list from an external API (<code>https://www.pqstec.com/InvoiceApps/values/GetProductListAll</code>).</li>
            </ul>
        </section>

        <!-- Technology Stack Section -->
        <section>
            <h2 class="text-3xl font-bold text-white border-b-2 border-blue-500 pb-2 mb-6 mt-12">Technology Stack</h2>
            <div class="grid grid-cols-2 sm:grid-cols-3 gap-4">
                <span class="bg-gray-700 text-white text-sm font-medium px-4 py-2 rounded-full text-center">.NET 8</span>
                <span class="bg-gray-700 text-white text-sm font-medium px-4 py-2 rounded-full text-center">ASP.NET Core Web API</span>
                <span class="bg-gray-700 text-white text-sm font-medium px-4 py-2 rounded-full text-center">ASP.NET Core MVC</span>
                <span class="bg-gray-700 text-white text-sm font-medium px-4 py-2 rounded-full text-center">ASP.NET Core Identity</span>
                <span class="bg-gray-700 text-white text-sm font-medium px-4 py-2 rounded-full text-center">Entity Framework Core 8</span>
                <span class="bg-gray-700 text-white text-sm font-medium px-4 py-2 rounded-full text-center">Dapper</span>
                <span class="bg-gray-700 text-white text-sm font-medium px-4 py-2 rounded-full text-center">SQL Server</span>
                <span class="bg-gray-700 text-white text-sm font-medium px-4 py-2 rounded-full text-center">JavaScript (jQuery/AJAX)</span>
                <span class="bg-gray-700 text-white text-sm font-medium px-4 py-2 rounded-full text-center">Swagger / OpenAPI</span>
            </div>
        </section>

        <!-- Project Structure Section -->
        <section>
            <h2 class="text-3xl font-bold text-white border-b-2 border-blue-500 pb-2 mb-6 mt-12">Project Structure</h2>
            <pre class="bg-gray-900 p-4 rounded-md overflow-x-auto font-mono text-sm text-gray-200 border border-gray-700">
<code class="language-text">
InvoiceAppsSolution
│
├── InvoiceApps.Api             # Web API backend
│   ├── Controllers            # API controllers
│   ├── Data                   # EF Core DbContext
│   ├── Models                 # Entity models (Employee, Department)
│   ├── Repositories           # Repository interfaces and implementations
│   ├── Services               # Dapper and helper services
│   ├── Properties             # launchSettings.json
│   ├── Program.cs             # API middleware, DI, Swagger setup
│   └── appsettings.json       # Connection strings
│
├── InvoiceApps.MvcClient       # MVC Client frontend
│   ├── Controllers            # MVC controllers
│   ├── Views                  # Razor views
│   ├── wwwroot                # Static files (js, css)
│   ├── Program.cs             # MVC app middleware
│   └── appsettings.json       # MVC client config
│
├── sql                        # SQL scripts
│   ├── schema.sql             # Database schema (tables)
│   ├── seed.sql               # Sample seed data
│   ├── sprocstriggers.sql     # Stored procedures and triggers
│
└── asp_projects.sln           # Visual Studio solution file
</code>
</pre>
        </section>

        <!-- Prerequisites Section -->
        <section>
            <h2 class="text-3xl font-bold text-white border-b-2 border-blue-500 pb-2 mb-6 mt-12">Prerequisites</h2>
            <ul class="list-disc list-inside space-y-2 text-gray-300">
                <li><a href="https://dotnet.microsoft.com/en-us/download/dotnet/8.0" target="_blank" class="text-blue-400 hover:underline">.NET 8 SDK</a></li>
                <li><a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads" target="_blank" class="text-blue-400 hover:underline">SQL Server</a> (or SQL Server Express)</li>
                <li><a href="https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms" target="_blank" class="text-blue-400 hover:underline">SQL Server Management Studio</a> (or a similar tool like <code>sqlcmd</code>)</li>
                <li><a href="https://visualstudio.microsoft.com/" target="_blank" class="text-blue-400 hover:underline">Visual Studio 2022</a> (or VS Code)</li>
            </ul>
        </section>

        <!-- Setup Section -->
        <section>
            <h2 class="text-3xl font-bold text-white border-b-2 border-blue-500 pb-2 mb-6 mt-12">Setup and Running Instructions</h2>

            <h3 class="text-2xl font-semibold text-gray-200 mt-8 mb-4">1. Configure the Database</h3>
            <p class="text-gray-300 text-base leading-relaxed mb-4">
                Use SQL Server Management Studio or <code>sqlcmd</code> to run the following SQL scripts from the <code>/sql/</code> folder <strong>in this specific order</strong>:
            </p>
            <ol class="list-decimal list-inside space-y-2 text-gray-300 bg-gray-900 p-4 rounded-md border border-gray-700">
                <li><code>schema.sql</code> (Creates the database, tables, and relationships)</li>
                <li><code>seed.sql</code> (Inserts sample data for Departments, Designations, etc.)</li>
                <li><code>sprocstriggers.sql</code> (Creates all required stored procedures and triggers)</li>
            </ol>

            <h3 class="text-2xl font-semibold text-gray-200 mt-8 mb-4">2. Configure Connection Strings</h3>
            <p class="text-gray-300 text-base leading-relaxed mb-4">
                Open the <code>appsettings.json</code> file in the <strong><code>InvoiceApps.Api</code></strong> project:
            </p>
            <pre class="bg-gray-900 p-4 rounded-md overflow-x-auto font-mono text-sm text-gray-200 border border-gray-700">
<code class="language-json">
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=InvoiceAppsDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
}
</code>
</pre>
            <p class="text-gray-300 text-base leading-relaxed mt-4">
                Update <code>Server=YOUR_SERVER_NAME</code> to match your local SQL Server instance name (e.g., <code>localhost</code>, <code>.\SQLEXPRESS</code>).
            </p>

            <h3 class="text-2xl font-semibold text-gray-200 mt-8 mb-4">3. Run the Applications</h3>
            <p class="text-gray-300 text-base leading-relaxed mb-4">
                You need to run both the API and the MVC client simultaneously.
            </p>
            
            <strong class="text-lg text-white">In Terminal 1 (Run the API):</strong>
            <pre class="bg-gray-900 p-4 rounded-md overflow-x-auto font-mono text-sm text-gray-200 border border-gray-700 my-2">
<code class="language-bash">
# Navigate to the API project folder
cd InvoiceAppsSolution/InvoiceApps.Api

# Restore dependencies and build
dotnet restore
dotnet build

# Run the API
dotnet run
</code>
</pre>
            <p class="text-gray-300 text-base leading-relaxed mb-4">
                The API will typically start on <code>https://localhost:5001</code>.
            </p>

            <strong class="text-lg text-white">In Terminal 2 (Run the MVC Client):</strong>
            <pre class="bg-gray-900 p-4 rounded-md overflow-x-auto font-mono text-sm text-gray-200 border border-gray-700 my-2">
<code class="language-bash">
# Navigate to the MVC project folder
cd InvoiceAppsSolution/InvoiceApps.MvcClient

# Restore dependencies and build
dotnet restore
dotnet run --urls "http://localhost:5002;http://localhost:5003"

# Run the MVC Client
dotnet run
</code>
</pre>
            <p class="text-gray-300 text-base leading-relaxed mb-4">
                The MVC client will typically start on <code>https://localhost:5002</code>.
            </p>

            <h3 class="text-2xl font-semibold text-gray-200 mt-8 mb-4">4. Access the Applications</h3>
            <ul class="list-disc list-inside space-y-2 text-gray-300">
                <li><strong>MVC Client UI:</strong> <a href="https://localhost:5002" target="_blank" class="text-blue-400 hover:underline">https://localhost:7125</a> (Check your terminal for the exact port)</li>
                <li><strong>Web API Swagger UI:</strong> <a href="https://localhost:5001/swagger" target="_blank" class="text-blue-400 hover:underline">https://localhost:5001/swagger</a> (Check your terminal for the exact port)</li>
            </ul>
        </section>

        <!-- Known Issues Section -->
        <section>
            <h2 class="text-3xl font-bold text-white border-b-2 border-blue-500 pb-2 mb-6 mt-12">Known Issues</h2>
            <ul class="list-disc list-inside space-y-2 text-gray-300">
                <li><strong class="font-semibold text-white">HTTPS Certificate:</strong> Your browser may show a warning about the local development certificate. To fix this, run <code>dotnet dev-certs https --trust</code> in your terminal.</li>
                <li><strong class="font-semibold text-white">File Uploads:</strong> Uploaded files are saved to an <code>Uploads</code> folder in the <code>InvoiceApps.Api</code> project root. Ensure the application has write permissions to this directory.</li>
            </ul>
        </section>

        <!-- Contact Section -->
        <section>
            <h2 class="text-3xl font-bold text-white border-b-2 border-blue-500 pb-2 mb-6 mt-12">Contact</h2>
            <p class="text-gray-300 text-base leading-relaxed">
                For any questions regarding this solution, please contact:
                <br>
                <strong class="font-semibold text-white">Name: Momitul Hoque Chowdhury </br>Email: momituledu@gmail.com</strong>
            </p>
        </section>

    </div> <!-- /End Main Content Container -->

</body>
</html>
