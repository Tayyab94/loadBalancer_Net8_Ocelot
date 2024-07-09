##Loadbalancer using Ocelot in .NET Core
Overview
This project demonstrates a load balancer implementation using Ocelot in .NET Core. Ocelot is a .NET API Gateway that provides features like routing, request aggregation, service discovery, and load balancing.

Prerequisites
.NET Core SDK 3.1 or later
Visual Studio 2019 or later / Visual Studio Code
Getting Started
Clone the Repository
bash
Copy code
git clone https://github.com/yourusername/loadbalancer.git
cd loadbalancer
Install Dependencies
Ensure the necessary NuGet packages are installed:

bash
Copy code
dotnet add package Ocelot
dotnet add package Microsoft.Extensions.Configuration.Json
