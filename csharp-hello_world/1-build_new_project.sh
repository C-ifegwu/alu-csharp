#!/usr/bin/env bash

# create the folder
mkdir -p 1-new_project

# Cd into the folder 
cd 1-new_project

# initialize the folder with dotnet
dotnet new console --force 

# Build the project 
dotnet build
