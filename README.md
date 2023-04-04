
# ImageResizer.AspNetCore

## Development 



[![Build status](https://img.shields.io/appveyor/ci/keyone2693/imageresizer-aspnetcore.svg)](https://ci.appveyor.com/project/keyone2693/imageresizer-aspnetcore)
[![NuGet](https://img.shields.io/nuget/v/ImageResizer.AspNetCore.svg)](https://www.nuget.org/packages/ImageResizer.AspNetCore/)
[![GitHub issues](https://img.shields.io/github/issues/keyone2693/ImageResizer.AspNetCore.svg?maxAge=25920?style=plastic)](https://github.com/keyone2693/ImageResizer.AspNetCore/issues)
[![GitHub stars](https://img.shields.io/github/stars/keyone2693/ImageResizer.AspNetCore.svg?maxAge=25920?style=plastic)](https://github.com/keyone2693/ImageResizer.AspNetCore/stargazers)
[![GitHub license](https://img.shields.io/github/license/keyone2693/ImageResizer.AspNetCore.svg?maxAge=25920?style=plastic)](https://github.com/keyone2693/ImageResizer.AspNetCore/blob/master/LICENSE)


### You can see the DEMO here: [Demo](http://imageresizer.keyone2693.ir/)

### Before posting new issues: [Test samples](https://github.com/keyone2693/ImageResizer.AspNetCore/tree/master/TestExample)


#### Current version: 2.0.x [Stable]
In this version:
all main functionality working
except for disk cache and watermark which will be added soon
the watermark as a text just added but need some bug fix

## Overview

## it's for DotNetCore only
aspnetcore 2.0 +

## Easy to install
Use the library as dll, reference from [nuget](https://www.nuget.org/packages/ImageResizer.AspNetCore/)
or use this in package manager console
```c#
Install-Package ImageResizer.AspNetCore
```



# Wiki

for using this awesome library, you only need to add two things

first:
add this line of code to your Startup.cs


```c#
public void ConfigureServices(IServiceCollection services)
{
  services.AddSingleton<IFileProvider>(_ => new PhysicalFileProvider(_env.WebRootPath ?? _env.ContentRootPath));
  //...
  services.AddImageResizer();
  //...
}
```

you may need this:

```c#
 private readonly IWebHostEnvironment _env;
 public Startup(IWebHostEnvironment env)
 {
     _env = env;
     var builder = new ConfigurationBuilder()
       .SetBasePath(env.ContentRootPath)
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
       .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
       .AddEnvironmentVariables();
       Configuration = builder.Build();
}
```

Then this one :

```c#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
  //...
  // services.AddSingleton<IFileProvider>(_ => new PhysicalFileProvider(_env.WebRootPath ?? _env.ContentRootPath));
   app.UseImageResizer();
   app.UseStaticFiles();
 
  //...
}
```
and you can use it in your client-side(html,css,ts,...) just like below:

Simple As That Enjoy :))

```html
<img src="~/images/mardinCity.jpg?w=200" />
<img src="~/images/mardinCity.jpg?h=300" />
<img src="~/images/mardinCity.jpg?format=png" />
<img src="~/images/mardinCity.jpg?format=jpg" />
<img src="~/images/mardinCity.jpg?format=jpeg" />
<img src="~/images/mardinCity.jpg?w=100&h=200&mode=pad" />
<img src="~/images/mardinCity.jpg?w=100&h=200&mode=max" />
<img src="~/images/mardinCity.jpg?w=100&h=200&mode=crop" />
<img src="~/images/mardinCity.jpg?w=100&h=200&mode=stretch" />
<img src="~/images/mardinCity.jpg?autorotate=true" />
<img src="~/images/mardinCity.jpg?autorotate=false" />
<img src="~/images/mardinCity.jpg?quality=5" />
<img src="~/images/mardinCity.jpg?w=400&quality=80" />

```

