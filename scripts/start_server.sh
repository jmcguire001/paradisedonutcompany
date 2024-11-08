#!/bin/bash
cd ~/paradisedonutcompany
sudo dotnet run --project paradisedonutcompany.csproj &
sudo systemctl start nginx
