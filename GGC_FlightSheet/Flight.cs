using System;

namespace au.org.GGC {
    // These are the objects held in the FlightSheet DataGridView.
    // They are loaded from and written to the FlightEntry objects stored in the .csv file.
    // They are also loaded into and read from the EntryForm.
    
    public class Flight {
        public Flight Clone() {
            return (Flight)this.MemberwiseClone();
        }
        public DateTime? this[int i] {
            get {
                if (i == 0) return TakeOff;
                if (i == 1) return TugDown;
                if (i == 2) return GliderDown;
                return null;
            }
            set {
                if (i == 0) TakeOff = value;
                if (i == 1) TugDown = value;
                if (i == 2) GliderDown = value;
            }
        }
        public bool IsEmpty { get { return FlightNo == null; } }
        public String Edit { get { return IsEmpty ? "New" : "Edit"; } }
        public int? FlightNo { get; set; }
        public DateTime? Logged { get; set; }
        public String Pilot1 { get; set; }
        public String Pilot1ID { get; set; }
        public String Pilot2 { get; set; }
        public String Pilot2ID { get; set; }
        public String Tug { get; set; }
        public String Glider { get; set; }
        public DateTime? TakeOff { get; set; }
        public DateTime? TugDown { get; set; }
        public DateTime? GliderDown { get; set; }
        public String AnnualCheck { get; set; }
        public String Mutual { get; set; }
        public String AEFType { get; set; }
        public String ChargeTo { get; set; }
        public String ChargeToID { get; set; }
        public String Notes { get; set; }
        public String Clerk { get; set; }
        public String TowTime { get; set; }
        public String FlightTime { get; set; }
        public string New { get; set; }

        public bool IsInTow {
            get {
                return (this.TugDown == null);
            }
        }

        public int GetTowMinutes() {
            if (this.TakeOff != null) {
                DateTime takeoff = (DateTime)this.TakeOff;
                DateTime tugdown = DateTime.Now;
                if (this.TugDown != null) tugdown = (DateTime)this.TugDown;
                return Convert.ToInt32(Math.Round((tugdown - takeoff).TotalMinutes));
            }
            return 0;
        }

        public int GetFlightMinutes() {
            if (this.TakeOff != null) {
                DateTime takeoff = (DateTime)this.TakeOff;
                DateTime gliderdown = DateTime.Now;
                if (this.GliderDown != null) gliderdown = (DateTime)this.GliderDown;
                return Convert.ToInt32(Math.Round((gliderdown - takeoff).TotalMinutes));
            }
            return 0;
        }
    }
}
