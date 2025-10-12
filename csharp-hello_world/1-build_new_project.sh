#!/usr/bin/env bash
# Initialize and build a new C# project inside 1-new_project
set -e

DIR="1-new_project"

# Ensure a clean setup
if [ -d "$DIR" ]; then
  rm -rf "$DIR"
fi

# Initialize the console project
# Suppress template creation logs to keep output minimal
dotnet new console -o "$DIR" >/dev/null

# Build the project and print only the summary lines
if ! build_output=$(dotnet build "$DIR/$DIR.csproj" 2>&1); then
  echo "$build_output" >&2
  exit 1
fi
# Extract counts robustly and print the exact expected lines
warnings=$(printf "%s\n" "$build_output" | awk '/Warning\(s\)/{w=$1} END{if(w=="")print 0; else print w}')
errors=$(printf "%s\n" "$build_output" | awk '/Error\(s\)/{e=$1} END{if(e=="")print 0; else print e}')
printf "Build succeeded.\n    %s Warning(s)\n    %s Error(s)\n" "$warnings" "$errors"