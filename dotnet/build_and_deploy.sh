#!/usr/bin/env bash

printf '\n\nBuilding the Dotnet Lambda Function!\n\n'
dotnet build "$PWD/helloworlddotnet/HelloWorld/src/HelloWorld/HelloWorld.csproj"
if [ $? -ne 0 ]; then
  printf '\n\nDotnet application build failed! No new Lambda Function will be deployed!!!i\n'
  exit -1
fi

printf '\n\nStarting the Terraforming!\n\n'
cd terraform
terraform plan -out=plan.out
terraform apply plan.out
