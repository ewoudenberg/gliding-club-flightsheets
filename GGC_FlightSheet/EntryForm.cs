using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using FileHelpers;

namespace au.org.GGC {
    public partial class EntryForm : Form {
        public EntryForm() {
            InitializeComponent();
            InitFields();
            LoadFormFields(new Flight());
        }

        public EntryForm(Flight flight) {
            InitializeComponent();
            InitFields();
            LoadFormFields(flight.Clone());
        }

        public Flight Flight;

        void LoadFormFields(Flight flight) {
            Flight = flight;
            Pilot1Name = Flight.Pilot1;
            Pilot2Name = Flight.Pilot2;
            Tug = Flight.Tug;
            Glider = Flight.Glider;
            TakeOff = Flight.TakeOff;
            TugDown = Flight.TugDown;
            GliderDown = Flight.GliderDown;
            AnnualCheck = Flight.AnnualCheck;
            Mutual = Flight.Mutual;
            AEFType = Flight.AEFType;
            ChargeTo = Flight.ChargeTo;
            Notes = Flight.Notes;
            FixBlankSelectors();
            SetFlightTitle();
        }

        void SetFlightTitle() {
            if (Flight.IsEmpty)
                labelTitle.Text = "New Flight Information";
            else
                labelTitle.Text = String.Format("Flight #{0} Information", Flight.FlightNo);
        }

        void FixBlankSelectors() {
            SetBlankSelectorToHelpText(comboBoxPilot1);
            SetBlankSelectorToHelpText(comboBoxPilot2);
            SetBlankSelectorToHelpText(comboBoxTug);
            SetBlankSelectorToHelpText(comboBoxGlider);
            SetBlankSelectorToHelpText(comboBoxChargeTo);
        }

        void SetBlankSelectorToHelpText(ComboBox c) {
            if (c.Text == "") c.SelectedIndex = 0;
        }

        void StoreFormFields() {
            Flight.Pilot1 = Pilot1Name;
            Flight.Pilot1ID = Pilot1ID;
            Flight.Pilot2 = Pilot2Name;
            Flight.Pilot2ID = Pilot2ID;
            Flight.Tug = Tug;
            Flight.Glider = Glider;
            Flight.TakeOff = TakeOff;
            Flight.TugDown = TugDown;
            Flight.GliderDown = GliderDown;
            Flight.AnnualCheck = AnnualCheck;
            Flight.Mutual = Mutual;
            Flight.AEFType = AEFType;
            Flight.ChargeTo = ChargeTo;
            Flight.ChargeToID = ChargeToID;
            Flight.Notes = Notes;
        }

        public string Pilot1Name { 
            get { return RealName(comboBoxPilot1); }
            set { comboBoxPilot1.SelectedIndex = -1; comboBoxPilot1.Text = value; } 
        }
        public string Pilot1ID {get { return AuxData(comboBoxPilot1); }}
        public string Pilot2Name {
            get { return RealName(comboBoxPilot2); }
            set { comboBoxPilot2.SelectedIndex = -1; comboBoxPilot2.Text = value; }
        }
        public string Pilot2ID { get { return AuxData(comboBoxPilot2); } }
        public string ChargeTo {
            get { return RealName(comboBoxChargeTo); }
            set { comboBoxChargeTo.SelectedIndex = -1; comboBoxChargeTo.Text = value; }
        }
        public string ChargeToID { get { return AuxData(comboBoxChargeTo); } }
        public string Tug {
            get { return RealName(comboBoxTug);  }
            set { comboBoxTug.SelectedIndex = -1; comboBoxTug.Text = value; }
        }
        public string Glider {
            get { return RealName(comboBoxGlider); }
            set { comboBoxGlider.SelectedIndex = -1; comboBoxGlider.Text = value; }
        }
        public DateTime? TakeOff {
            get { return ParseTime(textBoxTakeoff.Text); }
            set { textBoxTakeoff.Text = DisplayTime(value); }
        }
        public DateTime? TugDown {
            get { return ParseTime(textBoxTugDown.Text); }
            set { textBoxTugDown.Text = DisplayTime(value); }
        }
        public DateTime? GliderDown {
            get { return ParseTime(textBoxGliderDown.Text); }
            set { textBoxGliderDown.Text = DisplayTime(value); }
        }
        public string AnnualCheck {
            get { return checkBoxAnnual.Checked ? "X" : ""; }
            set { checkBoxAnnual.Checked = (value == "X"); }
        }
        public string Mutual {
            get { return checkBoxMutual.Checked ? "X" : ""; }
            set { checkBoxMutual.Checked = (value == "X"); }
        }
        public string AEFType {
            get { return comboBoxAEF.Text; }
            set { comboBoxAEF.Text = value; }
        }
        public string Notes {
            get { return textBoxNotes.Text; }
            set { textBoxNotes.Text = value; }
        }

        String DisplayTime(DateTime? datetime) {
            if (datetime == null)
                return "";
            else
                return ((DateTime)datetime).ToString("HH:mm:ss");
        }

        DateTime? ParseTime(string text) {
            DateTime parsedTime;
            text = text.Trim();
            if (text.Length != 0) {
                if (DateTime.TryParseExact(text, "H:mm:ss", null, 
                    System.Globalization.DateTimeStyles.AllowInnerWhite, out parsedTime))
                    return parsedTime;
                if (DateTime.TryParseExact(text, "H:mm", null, 
                    System.Globalization.DateTimeStyles.AllowInnerWhite, out parsedTime))
                    return parsedTime;
            }
            return null;
        }

        string RealName(ComboBox c) {
            if (c.SelectedItem == null)
                return c.Text;
            else
                return ((Displayable)c.SelectedItem).RealName;
        }

        string AuxData(ComboBox c) {
            if (c.SelectedItem == null)
                return "";
            else
                return ((Displayable)c.SelectedItem).AuxData;
        }
            

        void InitFields() {
            comboBoxPilot1.DataSource = Csv.Instance.GetPilotsList();
            comboBoxPilot2.DataSource = Csv.Instance.GetPilotsList();
            comboBoxChargeTo.DataSource = Csv.Instance.GetPilotsList();
            comboBoxTug.DataSource = Csv.Instance.GetTugsList();
            comboBoxGlider.DataSource = Csv.Instance.GetGlidersList();
            comboBoxAEF.DataSource = Csv.Instance.GetAefTypesList();

            comboBoxPilot1.DisplayMember = "DisplayName";
            comboBoxPilot2.DisplayMember = "DisplayName";
            comboBoxChargeTo.DisplayMember = "DisplayName";
            comboBoxTug.DisplayMember = "DisplayName";
            comboBoxGlider.DisplayMember = "DisplayName";
            comboBoxAEF.DisplayMember = "DisplayName";
        }

        private void comboBoxPilot_Leave(object sender, EventArgs e) {
            FixCombo((ComboBox)sender, Csv.Instance.GetPilotsList());
        }

        private void comboBoxTug_Leave(object sender, EventArgs e) {
            FixCombo(comboBoxTug, Csv.Instance.GetTugsList());
        }

        private void comboBoxGlider_Leave(object sender, EventArgs e) {
            FixCombo(comboBoxGlider, Csv.Instance.GetGlidersList());
        }

        void FixCombo(ComboBox c, List<Displayable> list) {
            FixCombo(c, list, c.Text);
        }

        void FixCombo(ComboBox c, List<Displayable> list, string text) {
            string prefix = text.ToLower();
            foreach (Displayable s in list) {
                if (s.DisplayName.ToLower().StartsWith(prefix)) {
                    c.Text = s.RealName;
                    break;
                }
            }
        }

        private void buttonTug_Click(object sender, EventArgs e) {
            FixCombo(comboBoxTug, Csv.Instance.GetTugsList(), ((Button)sender).Text);
        }

        private void buttonGlider_Click(object sender, EventArgs e) {
            FixCombo(comboBoxGlider, Csv.Instance.GetGlidersList(), ((Button)sender).Text);
        }

        private void buttonTakeOff_Click(object sender, EventArgs e) {
            textBoxTakeoff.Text = DisplayTime(DateTime.Now);
        }

        private void buttonTugDown_Click(object sender, EventArgs e) {
            textBoxTugDown.Text = DisplayTime(DateTime.Now);
        }

        private void buttonGliderDown_Click(object sender, EventArgs e) {
            textBoxGliderDown.Text = DisplayTime(DateTime.Now);
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            StoreFormFields();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Are you sure you want to delete this?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
                // Passes back Ignore to invoke the Delete function in the main form.
                this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
        }

        private void buttonClearTO_Click(object sender, EventArgs e) {
            textBoxTakeoff.Text = "";
        }

        private void buttonClearTD_Click(object sender, EventArgs e) {
            textBoxTugDown.Text = "";
        }

        private void buttonClearGD_Click(object sender, EventArgs e) {
            textBoxGliderDown.Text = "";
        }
    }
}
