FROM mcr.microsoft.com/dotnet/core/sdk:3.1

COPY ./src ./src

RUN dotnet build /src
WORKDIR /src/bin/Debug/netcoreapp3.1
CMD dotnet Sandpit.dll
