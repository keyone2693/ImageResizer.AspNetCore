# ImageResizer.AspNetCore
Under the way :)

## Development 

### Before posting new issues: [Test samples](https://github.com/keyone2693/ImageResizer.AspNetCore/tree/master/TestExample)


[![Build status](https://img.shields.io/appveyor/ci/keyone2693/imageresizer-aspnetcore.svg)](https://ci.appveyor.com/project/keyone2693/imageresizer-aspnetcore)
[![NuGet](https://img.shields.io/nuget/v/ImageResizer.AspNetCore.svg)](https://www.nuget.org/packages/ImageResizer.AspNetCore/)
[![GitHub issues](https://img.shields.io/github/issues/keyone2693/ImageResizer.AspNetCore.svg?maxAge=25920?style=plastic)](https://github.com/keyone2693/ImageResizer.AspNetCore/issues)
[![GitHub stars](https://img.shields.io/github/stars/keyone2693/ImageResizer.AspNetCore.svg?maxAge=25920?style=plastic)](https://github.com/keyone2693/ImageResizer.AspNetCore/stargazers)
[![GitHub license](https://img.shields.io/github/license/keyone2693/ImageResizer.AspNetCore.svg?maxAge=25920?style=plastic)](https://github.com/keyone2693/ImageResizer.AspNetCore/blob/master/LICENSE)

#### Current version: 1.7.x [Stable]
In this version:
all main functinalety working
except disk catch and water mark wich will be added soon

## Overview

## its for dotnet core only
aspnetcore 2.2 +

## Easy to install
Use library as dll, reference from [nuget](https://www.nuget.org/packages/ImageResizer.AspNetCore/)
or just use this in package manager console
```c#
Install-Package ImageResizer.AspNetCore
```
# Wiki

for using these awsom library you only need do two thigs
first:

add this line of code to your Startup.cs

```c#
public void ConfigureServices(IServiceCollection services)
{
  //...
  services.AddImageResizer();
  //...
}
```

and :


```c#
public void ConfigureServices(IServiceCollection services)
{
  //...
  services.AddImageResizer();
  //...
}
```
```c#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
  //...
  app.UseImageResizer();
  //...
}
```
