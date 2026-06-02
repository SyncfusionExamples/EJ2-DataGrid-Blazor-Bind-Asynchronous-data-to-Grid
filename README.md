# Blazor DataGrid - Bind Asynchronous Data

A sample Blazor application demonstrating how to load asynchronous data from a service and bind it to the [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) component. Perfect for learning about async data patterns in Blazor and working with real-time data sources.

## Overview

This repository shows how to wire a Blazor DataGrid component to asynchronously load data from a backend service. The sample demonstrates best practices for handling async operations in Blazor, loading indicators, and binding data to grid components while the data is being fetched.

## Features

- **Asynchronous Data Loading** - Load data from services without blocking the UI
- **Fast Rendering** - Optimized grid rendering with virtualization
- **DataGrid Features** - Sorting, filtering, grouping, and searching capabilities
- **Editing Modes** - Inline, batch, and dialog editing modes
- **Template Support** - Custom column templates, resizing, reordering, and freezing

## Prerequisites

- [.NET SDK 10.0](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/SyncfusionExamples/blazor-datagrid-bind-asynchronous-data.git
cd BindAsynchronousData
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## References

**Documentation**: https://blazor.syncfusion.com/documentation/datagrid/data-binding/local-data

**Live example**: https://blazor.syncfusion.com/demos/datagrid/overview