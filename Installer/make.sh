echo Current config file: 
cat ../GGC_FlightSheet/bin/Debug/FlightSheetSettings.xml
echo
echo -n cr to proceed:
read a
makensis BuildGFS.nsi
