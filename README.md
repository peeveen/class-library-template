# Class Library solution template

This is a template for `dotnet new`, facilitating the easy creation of:

- A class library project for .NET Core or Standard
- An [xUnit](https://xunit.net/) test project for the class library
- A [BenchmarkDotNet](https://benchmarkdotnet.org/) project for performing benchmarking.
- Project files initialized with:
  - NuGet metadata (description, copyright, icon, etc)
  - Code Analysis settings
    - [SonarAnalyzer](https://www.nuget.org/packages/SonarAnalyzer.CSharp/) pre-installed
    - Uses [`latest`](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props#analysislevel) analysis level
    - Treats warnings as errors to prevent them piling up over time
- A solution file that references all projects.
- Basic `.gitignore` and `README.md` files.

## Installation

```bash
dotnet new install Peeveen.Templates.DotNet.ClassLibrarySolution
```

> If already installed, it will be upgraded to the latest available version.

## Usage

Create a folder for your solution, `cd` into it, and:

```bash
dotnet new peeeveenclasslibsln --name What.Ever.Name.You.Want --framework netstandard2.0
```

> If not specified, `framework` will be `net10.0`, and `name` will be the name of the folder you are in.

> Your project folders, `csproj` files, and code namespaces will be `name` and `name.Test`

## Standard project setup

If/when you push your created solution to a GitLab project, be sure to follow the [standard project setup](https://gitlab.peeveen.com/peeveen/development/information/-/wikis/standard-project-setup) guidelines.
