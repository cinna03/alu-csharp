#!/usr/bin/env bash
# Initialize, build, and run a new C# project in 2-new_project
set -e

DIR="2-new_project"

# Initialize the console project only if it doesn't exist
if [ ! -d "$DIR" ]; then
  dotnet new console -o "$DIR" >/dev/null
fi

# Restore, build, and run the project
# Suppress restore and build logs to ensure only the program output is shown
dotnet restore "$DIR/$DIR.csproj" >/dev/null
dotnet build "$DIR/$DIR.csproj" >/dev/null
# Run without building again so only the program's output is printed
dotnet run --no-build --project "$DIR/$DIR.csproj"