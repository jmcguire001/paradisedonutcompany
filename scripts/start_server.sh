#!/bin/bash
sudo systemctl start nginx
cd ~/paradisedonutcompany
sudo dotnet run --project paradisedonutcompany.csproj &
