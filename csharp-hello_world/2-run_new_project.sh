#!/usr/bin/env bash
set -e

# Create project directory
mkdir -p 2-new_project
cd 2-new_project || exit 1

# Initialize C# console project
dotnet new console --force

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the project
dotnet run
