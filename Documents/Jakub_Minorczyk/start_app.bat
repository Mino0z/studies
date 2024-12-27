@echo off

echo Uruchamianie serwera backendowego (C#)...
cd .\backend
winget install --id Microsoft.DotNet.SDK.8 -e --source winget
dotnet run

timeout /t 3

echo Uruchamianie serwera frontendowego (Vue.js)...
cd ..\frontend

Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
winget install OpenJS.NodeJS
npm install 
npm install -g @vue/cli
npm run serve

timeout /t 3

echo Otwieram przeglądarke...
start http://localhost:8080  # Domyślny port dla Vue.js

echo Serwery uruchomione. Aplikacja otwarta w przeglądarce.
pause
