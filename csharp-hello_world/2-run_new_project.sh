#!/usr/bin/env bash

# Define the project directory
PROJECT_DIR="csharp-hello_world/2-new_project"

# Navigate to the directory
cd "$PROJECT_DIR" || { echo "Directory $PROJECT_DIR not found."; exit 1; }

# Initialize a new C# console project
dotnet new console -o . 

# Replace Program.cs with the required code
echo 'using System; class Program { static void Main(string[] args) { Console.WriteLine("Hello World!"); } }' > 2-new_project.cs

# Build the project
dotnet build -o bin

# Run the project
dotnet run
