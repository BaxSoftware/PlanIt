@echo off

set source=.\Final
set androiddest=..\PlanIt\PlanIt\PlanIt.Droid\Resources\drawable\
set iosdest=..\PlanIt\PlanIt\PlanIt.iOS\Resources\


echo.
echo Copying assets to Android directory
echo -----------------------------------
xcopy %source% %androiddest% /s /y
echo ===================================
echo.
echo Copying assets to iOS directory
echo -----------------------------------
xcopy %source% %iosdest% /s /y
echo ===================================
echo.
echo.
echo All Android and iOS assets have been copied
echo ===================================
echo.
pause
