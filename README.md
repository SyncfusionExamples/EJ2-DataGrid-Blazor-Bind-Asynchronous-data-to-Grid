# Blazor DataGrid Bind Asynchronous Data to Grid

## Overview

This sample demonstrates how to retrieve data asynchronously from a service and bind the resulting records to a Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid). Instead of supplying data immediately when the page is rendered, the application loads data through an asynchronous workflow and updates the Grid after the operation completes. This pattern is commonly used when data originates from APIs, databases, or external services that require asynchronous execution before records become available for display.

The repository contains a dedicated Blazor application that focuses specifically on asynchronous data loading and Grid binding behavior rather than advanced Grid editing, filtering, or remote data management scenarios.

## Key Features

- Demonstrates asynchronous retrieval of data from a service layer before rendering records in the Grid.
- Shows how a Syncfusion Blazor DataGrid can be populated after an asynchronous operation completes.
- Uses a dedicated data service located within the sample project structure to supply records.
- Separates data access logic from the UI layer through supporting files within the `Data` folder.
- Includes a Blazor application configured to render asynchronously loaded records in a Grid component.
- Provides a reference implementation for applications that must await service results before assigning a Grid data source.

## Prerequisites

* Visual Studio 2022 or Visual Studio Code

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Open the verified solution file: `CrudAsynchronousSample.sln`.
3. Restore NuGet packages.
4. Ensure the startup project is `CrudAsynchronousSample` if multiple startup projects are present.
5. Build the solution.
6. Run the application using `Ctrl+F5`.
7. Access the application at the local URL displayed by the ASP.NET Core launch output. `[VERIFY: local development URL]`

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the project directory that contains `CrudAsynchronousSample.csproj`.

```bash
dotnet restore
dotnet run
```

## Project Structure

- `Pages/` — contains the Razor page that hosts the Syncfusion DataGrid and initiates the asynchronous data-binding workflow.
- `Data/` — contains the sample models and service implementation used to generate or retrieve asynchronous data for the Grid.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official documentation related to DataGrid data binding, see https://help.syncfusion.com/grid-sdk/blazor/data-grid/data-binding

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
