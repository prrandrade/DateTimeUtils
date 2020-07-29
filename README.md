# DateTimeUtils

[Introduction](#introduction)
[Package installation](#package-installation)
[Usage](#usage)

# Introduction

This project intends to resolve a problem taht many project have when dealing with business rules related to `DateTime.Now` - Unit tests that fails because they are running at a different date or time! The solution is simple - let's inject DateTime as a dependency!

Nuget package: https://www.nuget.org/packages/DateTimeUtils/.

# Package Installation

Using the native .NET Core dependency injection framework, the installation consists of a single extension method that adds the injection in a `IServiceCollection`. For a .NET Core API project, for example, the configuration is added on the `ConfigureServices` method.

```csharp
public void ConfigureServices(IServiceCollection services)
{
	services.AddDateTimeUtils();
}
```

For a console application, the `ServiceCollection` must be manually initialized:

```csharp
var services = new ServiceCollection();
services.AddDateTimeUtils();
```

If you use another dependency injection framework, one dependency must be injected:

- Interface `IDateTimeUtils` and implementation `DateTimeUtils`.

The interface `IDateTimeUtils` can be injected on classes that will access DateTime Values.

# Usage

Using dependency injection, you can use the `IDateTimeUtils` interface like this:

```csharp
public class SomeClass
{
    private readonly IDateTimeUtils _dateTimeUtils;
    
    public SomeClass(IDateTimeUtils dateTimeUtils) {
        _dateTimeUtils = dateTimeUtils;
    }
}
```

With it, you can access five `DateTime` values (that can be mocked during Unit Tests!):

```csharp
_dateTimeUtils.MinValue(); // same as DateTime.MinValue
_dateTimeUtils.MaxValues(); // same as DateTime.MaxValue
_dateTimeUtils.Now(); // same as DateTime.Now
_dateTimeUtils.UtcNow(); // same as DateTime.UtcNow
_dateTimeUtils.Today(); // same as DateTime.Today
```

