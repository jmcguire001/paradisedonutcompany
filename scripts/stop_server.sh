#!/bin/bash

sudo systemctl stop nginx

# Find all processes with 'dotnet' in their command
pids=$(pgrep -f 'dotnet')

if [ -z "$pids" ]; then
  echo "No dotnet processes found."
  exit 0
fi

# Kill each found process
for pid in $pids; do
  echo "Killing process with PID $pid (dotnet)"
  kill -SIGTERM "$pid"
done

echo "All dotnet processes have been terminated."
