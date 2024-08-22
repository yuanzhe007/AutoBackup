::[Bat To Exe Converter]
::
::YAwzoRdxOk+EWAnk
::fBw5plQjdG8=
::YAwzuBVtJxjWCl3EqQJgSA==
::ZR4luwNxJguZRRnk
::Yhs/ulQjdF+5
::cxAkpRVqdFKZSTk=
::cBs/ulQjdF+5
::ZR41oxFsdFKZSDk=
::eBoioBt6dFKZSDk=
::cRo6pxp7LAbNWATEpCI=
::egkzugNsPRvcWATEpCI=
::dAsiuh18IRvcCxnZtBJQ
::cRYluBh/LU+EWAnk
::YxY4rhs+aU+JeA==
::cxY6rQJ7JhzQF1fEqQJQ
::ZQ05rAF9IBncCkqN+0xwdVs0
::ZQ05rAF9IAHYFVzEqQJQ
::eg0/rx1wNQPfEVWB+kM9LVsJDGQ=
::fBEirQZwNQPfEVWB+kM9LVsJDGQ=
::cRolqwZ3JBvQF1fEqQJQ
::dhA7uBVwLU+EWDk=
::YQ03rBFzNR3SWATElA==
::dhAmsQZ3MwfNWATElA==
::ZQ0/vhVqMQ3MEVWAtB9wSA==
::Zg8zqx1/OA3MEVWAtB9wSA==
::dhA7pRFwIByZRRnk
::Zh4grVQjdCODJE6L5kkjOBpXSTiBMW+KFLoW7evv/NaGt1kSVuM8c5rL5oaLLOUS+UCqdpsp6mpIl8weDRZMbBOoax16rHZH1g==
::YB416Ek+ZG8=
::
::
::978f952a14a936cc963da21a135fa983
@echo off
chcp 65001
:head
::read file
type config.ini | find /i "traceprogram" > traceprogramread.tmp

set /p backupto=<backupto.dat
set /p set_tpg=<traceprogramread.tmp
del /F /Q traceprogramread.tmp

set %set_tpg%

:tracer
set /p isClose=<quitTrace.dat
if /i "%isClose%"=="true" exit
timeout 2 >nul
tasklist | find /i "%traceprogram%"
if "%errorlevel%"=="0" goto tracer
echo [%date% %time%] Program traced "%traceprogram%" has quit! >>programtracer.log
echo [%date% %time%] Backuping... >>programtracer.log
copy "%backupto%\backups\nearest\*" "%backupto%\backups\recovery\" >> programtracer.log
echo [%date% %time%] Backup completed. >>programtracer.log

:cooldowns
set /p isClose=<quitTrace.dat
if /i "%isClose%"=="true" exit
timeout 5 >nul
tasklist | find "%traceprogram%" > nul
if "%errorlevel%"=="0" goto tracer
goto cooldowns
