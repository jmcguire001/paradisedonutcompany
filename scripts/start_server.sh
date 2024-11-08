#!/bin/bash
cd /home/ec2-user/paradisedonutcompany
sudo dotnet run --project paradisedonutcompany.csproj &
sudo systemctl start nginx
