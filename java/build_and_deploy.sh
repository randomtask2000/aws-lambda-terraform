#!/usr/bin/env bash

cd helloworldjava
printf '\n\nBuilding the Java Lambda Function!\n\n'
#mvn clean verify
gradle build --build-cache --info
if [ $? -ne 0 ]; then
  printf '\n\nJava application build failed! No new Lambda Function will be deployed!!!i\n'
  exit -1
fi

# put the gradle jar into the maven target file
mkdir -p target
cp build/libs/helloworldjava-*.jar target/helloworldjava-*.jar

cd ..
printf '\n\nStarting the Terraforming!\n\n'

cd terraform
terraform plan -out=plan.out
terraform apply plan.out
