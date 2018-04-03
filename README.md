# Addresses.Addresses.DatabaseContext

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-addresses-databasecontext.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/addresses-addresses-databasecontext)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.Addresses.DatabaseContext.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Addresses.Addresses.DatabaseContext)

## Description

EntityFrameworkCore database context for Address entities

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Addresses.Addresses](https://github.com/CDorst/Addresses.Addresses) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-addresses.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-addresses) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.Addresses.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.Addresses)
[CDorst.Addresses.StateCityZips.DatabaseContext](https://github.com/CDorst/Addresses.StateCityZips.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-statecityzips-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-statecityzips-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StateCityZips.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.StateCityZips.DatabaseContext)

## Dependents

The project below uses this repository as a direct dependency.

Name | Status
---- | ------
[Addresses.Addresses.ApiController](https://github.com/CDorst/Addresses.Addresses.ApiController) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-addresses-apicontroller.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-addresses-apicontroller) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.Addresses.ApiController.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.Addresses.ApiController)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Addresses.Addresses.DatabaseContext](https://www.nuget.org/packages/CDorst.Addresses.Addresses.DatabaseContext)

## Version

1.0.2

## Metaproject

Addresses.Addresses.DatabaseContext is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

