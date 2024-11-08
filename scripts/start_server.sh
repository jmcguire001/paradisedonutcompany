#!/bin/bash
sudo systemctl start nginx
sudo dotnet run --project ~/paradisedonutcompany/paradisedonutcompany/paradisedonutcompany.csproj &
