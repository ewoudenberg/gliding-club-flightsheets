using System;
using System.Collections.Generic;


namespace au.org.GGC {
    [Serializable]
    public class FlightSheetSettings {
        public String FlightSheetsFolder { get; set; }
        public String GridFontSize { get; set; }
        public String TowAlarmThreshold { get; set; }
        public String Airfield { get; set; }

        public FlightSheetSettings() {
            FlightSheetsFolder = "GGC_FlightSheets";
            GridFontSize = "0";
            TowAlarmThreshold = "10";
            Airfield = "Bacchus Marsh";
        }
        public FlightSheetSettings(bool initialize) {
             FlightSheetsFolder = "GGC_FlightSheets";
             GridFontSize = "0";
             TowAlarmThreshold = "10";
             Airfield = "Bacchus Marsh";
        }
    }
}
