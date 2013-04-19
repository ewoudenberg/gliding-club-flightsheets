using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace au.org.GGC {
    public partial class SettingsDialog : Form {
        public SettingsDialog() {
            InitializeComponent();
        }

        public string SelectedPath {
            get { return textBoxFolderName.Text; }
            set { textBoxFolderName.Text = value; }
        }

        public int TowAlarmThreshold {
            get { return Convert.ToInt32(textBoxTowAlarmThreshold.Text); }
            set { textBoxTowAlarmThreshold.Text = value.ToString(); }
        }

        private void buttonBrowse_Click(object sender, EventArgs e) {
            folderBrowserDialog1.SelectedPath = SelectedPath;
            var result = folderBrowserDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                SelectedPath = folderBrowserDialog1.SelectedPath;
        }

        private void textBoxTowAlarmThreshold_TextChanged(object sender, EventArgs e) {
            int val;
            buttonOK.Enabled = Int32.TryParse(textBoxTowAlarmThreshold.Text, out val);
        }
    }
}
