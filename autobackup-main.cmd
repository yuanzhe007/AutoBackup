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
::Zh4grVQjdCODJE6L5kkjOBpXSTiBMW+KFLoW7evv/NaGt1kSVuM8c5rL5oaLLOUS+UCqdpsp6ntPjMQODRhTawLmYw49pyBHrmHl
::YB416Ek+ZG8=
::
::
::978f952a14a936cc963da21a135fa983
@echo off
chcp 65001
echo false>quitTrace.dat
echo [COPYRIGHT] THIS PROGRAM MADE BY YZWORKSTATION.
echo Program starting up...
if exist sort.dat goto n1
echo s0>sort.dat
:n1
set /p sortraw=<sort.dat
set sort=%sortraw:~1,99999%
:head
::Read config.ini
type config.ini | find /i "backupfolder" > setbackupfolder.tmp
type config.ini | find /i "backupto" > backupto.tmp
type config.ini | find /i "delrange" > delrange.tmp
type config.ini | find /i "tracer" > tracer.tmp
set /p set_tc=<tracer.tmp
set /p set_but=<backupto.tmp
set /p set_buf=<setbackupfolder.tmp
set /p set_dr=<delrange.tmp
del /F /Q setbackupfolder.tmp
del /F /Q delrange.tmp
del /F /Q tracer.tmp
del /F /Q backupto.tmp

set %set_but%
set %set_buf%
set %set_dr%
set %set_tc%

echo %backupto%>backupto.dat

mkdir "%backupto%\backups"
mkdir "%backupto%\backups\recovery"
mkdir "%backupto%\backups\nearest"
cls

echo AutoBackup - by yzworkstation - Started. (%date% %time%) >>backup-main.log
echo Running - [%date% %time%] >>backup-main.log

echo false>timeArrived.dat
start timer
echo [Launch %date% %time%] Timer started. >>backup-main.log
if /i "%tracer%"=="false" goto listen
start programtracer
echo [Launch %date% %time%] Tracer started. >>backup-main.log

:listen
set /p isClose=<quitTrace.dat
if /i "%isClose%"=="true" exit
set /p isbackup=<timeArrived.dat
if /i "%isbackup%"=="true" goto backup-progress
set isbackup=null
goto listen

:backup-progress
echo [%date% %time%] Backuping... >>backup-main.log
echo [%date% %time%] Debug info: >>backup-main.log
echo [%date% %time%] sort= %sort% >>backup-main.log
echo [%date% %time%] delsort=%delsort% >>backup-main.log


set /a sort=%sort%+1
set /a delsort=%sort%-%delrange%
call :calctime
7z a "%backupto%\backups\nearest\sort-%sort%-backup-%timeformats%.7z" "%backupfolder%"
echo delsort="%delsort%"
echo Delhasrun &del /F "%backupto%\backups\nearest\sort-%delsort%-backup-*.7z"

echo false>timeArrived.dat
echo s%sort%>sort.dat
echo [%date% %time%] Backup completed. >>backup-main.log
goto listen

::FUNCTIONS

:calctime
set timeformats=%date:~0,4%%date:~5,2%%date:~8,2%%time:~0,2%_%time:~3,2%_%time:~6,2%
