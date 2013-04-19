using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace au.org.GGC {

    public partial class ChangeAirfield : Form {
        public ChangeAirfield(string airfield) {
            InitializeComponent();
            Airfield = airfield;
            InitFields();
            EnableButtons();
        }

        public string Airfield;

        void InitFields() {
            comboBoxAirfield.DataSource = Csv.Instance.GetAirfieldsList();
            comboBoxAirfield.DisplayMember = "DisplayName";
            comboBoxAirfield.SelectedIndex = -1;
            comboBoxAirfield.Text = Airfield;
        }

        private void comboBoxAirfield_TextChanged(object sender, System.EventArgs e) {
            EnableButtons();
        }

        void EnableButtons() {
            buttonCreateNew.Enabled = RealAirfield().Length != 0;
        }

        string RealAirfield() {
            if (comboBoxAirfield.SelectedItem == null)
                return comboBoxAirfield.Text.Trim();
            else
                return ((Displayable)comboBoxAirfield.SelectedItem).RealName;
        }

        private void buttonCreateNew_Click(object sender, System.EventArgs e) {
            Airfield = RealAirfield();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e) {
            new HelpSheet().ShowDialog();
        }

    }
}
