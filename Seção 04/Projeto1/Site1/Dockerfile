﻿FROM microsoft/dotnet:2.1-aspnetcore:runtime 

LABEL version="1.0" maintainer="Jonathanscrok"

WORKDIR /app

COPY .src/Site1/dist.

ENTRYPOINT ["dotnet","Site1.dll"]
