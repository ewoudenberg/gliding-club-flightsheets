using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FileHelpers;
using System.IO;

namespace au.org.GGC {
    public class Csv {

        static public Csv Instance = new Csv();

        static List<Displayable> PilotsList = null;
        static List<Displayable> TugsList = null;
        static List<Displayable> GlidersList = null;
        static List<Displayable> AirfieldsList = null;
        static List<Displayable> AefTypesList = null;

        public List<Displayable> GetPilotsList() {
            if (PilotsList == null)
                PilotsList = LoadPilotsList(isMember: false);
            return new List<Displayable>(PilotsList);
        }
        public List<Displayable> GetTugsList() {
            if (TugsList == null)
                TugsList = LoadAircraftList(tug: true);
            return TugsList;
        }
        public List<Displayable> GetGlidersList() {
            if (GlidersList == null)
                GlidersList = LoadAircraftList(tug: false);
            return GlidersList;
        }
        public List<Displayable> GetAirfieldsList() {
            if (AirfieldsList == null)
                AirfieldsList = LoadAirfieldList();
            return AirfieldsList;
        }

        public List<Displayable> GetAefTypesList() {
            if (AefTypesList == null)
                AefTypesList = LoadAefTypes();
            return AefTypesList;
        }

        const string DropdownHelp = "-- Select from list or Type in --";

        public List<Displayable> LoadPilotsList(bool isMember=false) {
            List<Displayable> final = new List<Displayable>();
            final.Add(new Displayable() { DisplayName = DropdownHelp, RealName = "" });
            FileHelperEngine<Pilot> engine = new FileHelperEngine<Pilot>();
            engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;
            Pilot[] res = engine.ReadFile(@"programdata/pilots.csv");
            if (engine.ErrorManager.ErrorCount > 0)
                engine.ErrorManager.SaveErrors("Errors.txt");
            foreach (Pilot pilot in res) {
                if (isMember && pilot.Club.ToLower() != "ggc")
                    continue;
                string name = pilot.LastName;
                if (pilot.FirstName != "")
                    name += ", " + pilot.FirstName;
                name += ClubSuffix(pilot.Club);
                Displayable d = new Displayable();
                d.DisplayName = name;
                d.RealName = name;
                d.AuxData = pilot.ID;
                final.Add(d);
                if (pilot.FirstName != "") {
                    d = new Displayable();
                    d.DisplayName = pilot.FirstName + " " + pilot.LastName + ClubSuffix(pilot.Club);
                    d.RealName = name;
                    final.Add(d);
                }
            }
            final.Sort(CompareDisplays);
            return final;
        }

        List<Displayable> LoadAircraftList(bool tug) {
            List<Displayable> final = new List<Displayable>();
            final.Add(new Displayable() { DisplayName = DropdownHelp, RealName = "" });
            FileHelperEngine<Aircraft> engine = new FileHelperEngine<Aircraft>();
            engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;
            Aircraft[] res = engine.ReadFile(@"programdata/aircraft.csv");
            if (engine.ErrorManager.ErrorCount > 0)
                engine.ErrorManager.SaveErrors("Errors.txt");
            foreach (Aircraft aircraft in res) {
                string actype = aircraft.Type.ToLower();
                bool isTug = (actype == "t" || actype == "m");
                bool isGlider = (actype == "g" || actype == "m");
                if (tug && isTug || !tug && isGlider) {
                    string name = aircraft.Reg + " " + aircraft.Name + ClubSuffix(aircraft.Club);
                    Displayable d = new Displayable();
                    d.DisplayName = d.RealName = name;
                    final.Add(d);
                    if (aircraft.Name != "") {
                        d = new Displayable();
                        d.DisplayName = aircraft.Name + " " + aircraft.Reg + ClubSuffix(aircraft.Club);
                        d.RealName = name;
                        final.Add(d);
                    }
                }
            }
            final.Sort(CompareDisplays);
            return final;
        }

        List<Displayable> LoadAirfieldList() {
            List<Displayable> final = new List<Displayable>();
            // Commented out because I prefer to have Bacchus Marsh be the default
            //final.Add(new Displayable() { DisplayName = DropdownHelp, RealName = "" });
            FileHelperEngine<Airfield> engine = new FileHelperEngine<Airfield>();
            engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;
            var res = engine.ReadFile(@"programdata/airfields.csv");
            if (engine.ErrorManager.ErrorCount > 0)
                engine.ErrorManager.SaveErrors("Errors.txt");
            foreach (Airfield airfield in res) {
                Displayable d = new Displayable();
                d.DisplayName = d.RealName = airfield.Name;
                final.Add(d);
            }
            return final;
        }

        public List<FlightEntry> LoadFlightEntries(string filename) {
            FileHelperEngine<FlightEntry> engine = new FileHelperEngine<FlightEntry>();
            engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;
            FlightEntry[] res = new FlightEntry[0];
            if (File.Exists(filename)) {
                res = engine.ReadFile(filename);
                if (engine.ErrorManager.ErrorCount > 0)
                    engine.ErrorManager.SaveErrors("Errors.txt");
            }
            return new List<FlightEntry>(res);
        }

        public List<Displayable> LoadAefTypes() {
            FileHelperEngine<AefType> engine = new FileHelperEngine<AefType>();
            engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;
            var res = engine.ReadFile(@"programdata/aeftypes.csv");
            if (engine.ErrorManager.ErrorCount > 0)
                engine.ErrorManager.SaveErrors("Errors.txt");

            List<Displayable> final = new List<Displayable>();
            foreach (AefType aefType in res)
                final.Add(new Displayable(
                    aefType.Name, 
                    aefType.Code + " " + aefType.Name));
            return final;
        }

        // Sort alphabetically but put GGC entries first
        int CompareDisplays(Displayable a, Displayable b) {
            bool aclub = a.DisplayName.Contains("[");
            bool bclub = b.DisplayName.Contains("[");
            if (aclub ^ bclub)
                return (aclub ? 1 : -1);
            else
                return string.Compare(a.DisplayName, b.DisplayName);
        }

        string ClubSuffix(string club) {
            string name = "";
            if (club.ToLower() != "ggc" && club != "")
                name = " [" + club + "]";
            return name;
        }
    }

    public class Displayable {
        public Displayable() { this.AuxData = ""; }
        public Displayable(string DisplayName, string RealName) {
            this.DisplayName = DisplayName;
            this.RealName = RealName;
            this.AuxData = "";
        }
        public String DisplayName { get; set; }
        public String RealName { get; set; }
        public String AuxData { get; set; }
        public static string DisplayToReal(List<Displayable> dlist, string display) {
            foreach (var d in dlist)
                if (d.DisplayName == display)
                    return d.RealName;
            return "";
        }
        public static string RealToDisplay(List<Displayable> dlist, string real) {
            foreach (var d in dlist)
                if (d.RealName == real)
                    return d.DisplayName;
            return "";
        }
    }

    [DelimitedRecord(",")]
    public sealed class AefType {
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Code;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Name;
    }

    [DelimitedRecord(",")]
    public sealed class Pilot {
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String LastName;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String FirstName;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String ID;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Club;
    }

    [DelimitedRecord(",")]
    public sealed class Aircraft {
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Reg;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Type;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Club;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Seats;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Name;
    }

    [DelimitedRecord(",")]
    public sealed class Airfield {
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Name;
    }

    [DelimitedRecord(",")]
    [IgnoreFirst] 
    public sealed class FlightEntry {
        public static string Header="FltDate,FltSheetRef,FltNo,Place,P1Name,P1MemID,P2Name,P2MemID,Tug,Glider,TakeOff,TugDown,GliderDown,GliderDuration,TugDuration,FltShtType,Mutual,TIFType,AnnualChk1,AnnualChk2,AnnualChkOK,Solo,Kms,AltPay1,AltPay1MemID,AltPay2,AltPay2MemID,AltPayAll,AltPayAllMemID,Notes,ImpExpFlag,Clerk";
        [FieldQuoted('"', QuoteMode.OptionalForRead)] 
        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd HH:mm:ss")]  public DateTime? FltDate; 
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String FltSheetRef;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String FltNo;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Place;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String P1Name;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String P1MemID;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String P2Name;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String P2MemID;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Tug;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Glider;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] 
        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd HH:mm:ss")]  public DateTime? TakeOff;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] 
        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd HH:mm:ss")]  public DateTime? TugDown;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] 
        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd HH:mm:ss")]  public DateTime? GliderDown;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String GliderDuration;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String TugDuration;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String FltShtType;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Mutual;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String TIFType;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String AnnualChk1;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String AnnualChk2;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String AnnualChkOK;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Solo;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Kms;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String AltPay1;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String AltPay1MemID;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String AltPay2;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String AltPay2MemID;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String AltPayAll;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String AltPayAllMemID;
        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)] public String Notes;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String ImpExpFlag;
        [FieldQuoted('"', QuoteMode.OptionalForRead)] public String Clerk;
    }
}

