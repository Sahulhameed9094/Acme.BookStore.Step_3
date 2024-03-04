#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 00000000-0000-0000-0000-000000000000 -t
    fi
    cd ../
fi

docker-compose up -d
