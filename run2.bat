@echo off

%~d0
cd "%~dp0"

if "%1"=="" (
  echo Usage %~nx0 ^<filename^>
  exit
)

rem set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v3.5
set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727
rem set NETSDK_HOME=C:\Program Files\Microsoft Visual Studio 8\SDK\v2.0
set NETSDK_HOME=C:\Program Files\Microsoft SDKs\Windows\v7.0A


set CSC="%NET_HOME%\csc"
set ILASM="%NET_HOME%\ilasm"
set ILDASM="%NETSDK_HOME%\bin\ildasm"



set FILENAME=%~1

.\bin\Debug\MathExpr.exe %FILENAME%
