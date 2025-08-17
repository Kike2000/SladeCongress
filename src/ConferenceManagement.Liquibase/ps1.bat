@echo off
echo ===============================
echo Ejecutando Liquibase Migration
echo ===============================

set "LIQUIBASE_HOME=YOURLIQUIBASEPATH"
set "PROPS_FILE=liquibase.properties"

"%LIQUIBASE_HOME%\liquibase.bat" --defaultsFile="%PROPS_FILE%" update

pause
