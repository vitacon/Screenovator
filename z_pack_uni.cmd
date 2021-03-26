rem echo %date%
rem so 07.02.2015

rem 1803: 13.11.2018

if exist "\visual-work" goto WORK

rem Domácí nastavení
set PLACE=home
set mydate=%date:~9,4%%date:~6,2%%date:~3,2%
set GD=Disk Google
goto ALLSET

:WORK
rem Pracovní nastavení
set PLACE=atc
set mydate=%date:~6,4%%date:~3,2%%date:~0,2%
set GD=Disk Google

:ALLSET
set suf=
echo %mydate%

set prefix=screenovator

:SUF
set FULLNAME=..\_archive\%prefix%-%mydate%-%place%%suf%
if not exist %FULLNAME%.rar goto READY
set SUF=%SUF%x
goto SUF

:READY
"c:\Program Files\WinRAR\WinRAR.exe" a %FULLNAME% . %prefix% txt -m5 -s

copy %FULLNAME%.rar "\%GD%\eriador\%prefix%\"

pause