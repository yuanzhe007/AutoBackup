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
::Zh4grVQjdCODJE6L5kkjOBpXSTiBMW+KFLoW7evv/NaGt1kSVuM8c5rL5oaLLOUS+UCqdpsp6m5Tlc4eQh5Ae3I=
::YB416Ek+ZG8=
::
::
::978f952a14a936cc963da21a135fa983
@echo off
chcp 65001
:head
type config.ini | find /i "autobackuptime" > outdat.tmp
set /p set_abut=<outdat.tmp
del /F /Q outdat.tmp
set %set_abut%
goto cycle_isreceived
:timer
echo Running - Timer [%autobackuptime% s].
timeout /NOBREAK %autobackuptime%
set /p isClose=<quitTrace.dat
if /i "%isClose%"=="true" exit
echo true>timeArrived.dat
set timeArrivedTrace=null
:cycle_isreceived
set /p isClose=<quitTrace.dat
if /i "%isClose%"=="true" exit
set /p timeArrivedTrace=<timeArrived.dat
if /i "%timeArrivedTrace%"=="false" goto timer
timeout 1 >nul
goto cycle_isreceived
















