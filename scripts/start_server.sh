#!/bin/bash
nohup sudo dotnet run --project /home/ec2-user/paradisedonutcompany/paradisedonutcompany.csproj &
sudo systemctl start nginx
