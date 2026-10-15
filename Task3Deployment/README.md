# Task 3: Azure Cloud Deployment Portfolio

**Student:** Shin Thant Thi Ri (104842811)  
**Unit:** SWE40006 Software Deployment and Evolution  
**Semester:** Semester 2, 2026

## Overview

This folder contains source code artifacts for Task 3, demonstrating cloud deployment to Microsoft Azure across three progressive sub-tasks (Pass, Credit, HD levels).

## Live Deployments

- **Task 3.1 & 3.2 (C# ASP.NET Core):** [https://swe40006-pass-104842811.azurewebsites.net](https://swe40006-pass-104842811.azurewebsites.net)
- **Task 3.3 (PHP):** [https://swe40006-php-104842811.azurewebsites.net](https://swe40006-php-104842811.azurewebsites.net)

## Repository Contents

```
Task3Deployment/
├── Task3.2-CSharp/          # ASP.NET Core Razor Pages application
│   ├── Index.cshtml         # Frontend view template
│   ├── Index.cshtml.cs      # Backend page model
│   ├── Program.cs           # Application entry point
│   └── App.csproj           # Project configuration
└── Task3.3-PHP/             # PHP web application
    └── index.php            # Single-page PHP application
```

## Technologies

- **Task 3.1 & 3.2:** ASP.NET Core 8.0 (LTS), C# Razor Pages, Azure App Service (Windows)
- **Task 3.3:** PHP 8.5, Bootstrap 5, Azure App Service (Linux)

## Deployment Method

All applications deployed via Azure Kudu Zip Deploy after local compilation, utilizing decoupled artifact pipeline to resolve MFA authentication constraints.
