#!/usr/bin/env bash

# Initialize a new C# console project in a folder named 1-new_project
dotnet new console -o 1-new_project

# Modify the .csproj file to target .NET 7.0
sed -i 's/<TargetFramework>.*<\/TargetFramework>/<TargetFramework>net7.0<\/TargetFramework>/g' 1-new_project/1-new_project.csproj

# Build the project
dotnet build 1-new_project
