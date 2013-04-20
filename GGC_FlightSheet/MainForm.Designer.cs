namespace au.org.GGC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FlightSheet = new System.Windows.Forms.DataGridView();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelAirfield = new System.Windows.Forms.Label();
            this.labelClerk = new System.Windows.Forms.Label();
            this.comboBoxClerk = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openArchivedFlightSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFlightSheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneSelectedFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandpaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFlightSheetFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGGCFlightSheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelClerkAlert = new System.Windows.Forms.Label();
            this.contextMenuStripFlights = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editThisEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneIntoNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxFlightSheetRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangeAirfield = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelOverTow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlightSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripFlights.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlightSheet
            // 
            this.FlightSheet.AllowUserToAddRows = false;
            this.FlightSheet.AllowUserToDeleteRows = false;
            this.FlightSheet.AllowUserToResizeColumns = false;
            this.FlightSheet.AllowUserToResizeRows = false;
            this.FlightSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightSheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.FlightSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightSheet.Location = new System.Drawing.Point(12, 104);
            this.FlightSheet.Name = "FlightSheet";
            this.FlightSheet.ReadOnly = true;
            this.FlightSheet.RowHeadersVisible = false;
            this.FlightSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.FlightSheet.Size = new System.Drawing.Size(942, 318);
            this.FlightSheet.TabIndex = 2;
            this.FlightSheet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightSheet_CellClick);
            this.FlightSheet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightSheet_CellDoubleClick);
            this.FlightSheet.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FlightSheet_ColumnHeaderMouseClick);
            this.FlightSheet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlightSheet_MouseDown);
            // 
            // Logo
            // 
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(12, 27);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(122, 71);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // labelAirfield
            // 
            this.labelAirfield.AutoSize = true;
            this.labelAirfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAirfield.Location = new System.Drawing.Point(304, 38);
            this.labelAirfield.Name = "labelAirfield";
            this.labelAirfield.Size = new System.Drawing.Size(72, 24);
            this.labelAirfield.TabIndex = 3;
            this.labelAirfield.Text = "Airfield:";
            // 
            // labelClerk
            // 
            this.labelClerk.AutoSize = true;
            this.labelClerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClerk.Location = new System.Drawing.Point(267, 70);
            this.labelClerk.Name = "labelClerk";
            this.labelClerk.Size = new System.Drawing.Size(109, 24);
            this.labelClerk.TabIndex = 4;
            this.labelClerk.Text = "Flight Clerk:";
            this.labelClerk.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxClerk
            // 
            this.comboBoxClerk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxClerk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClerk.FormattingEnabled = true;
            this.comboBoxClerk.Location = new System.Drawing.Point(373, 70);
            this.comboBoxClerk.Name = "comboBoxClerk";
            this.comboBoxClerk.Size = new System.Drawing.Size(249, 26);
            this.comboBoxClerk.TabIndex = 0;
            this.comboBoxClerk.TextChanged += new System.EventHandler(this.comboBoxClerk_TextChanged);
            this.comboBoxClerk.Leave += new System.EventHandler(this.comboBoxClerk_Leave);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Garamond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(669, 32);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(164, 72);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "12:45";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem,
            this.exitFlightSheetsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openArchivedFlightSheetToolStripMenuItem});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.archiveToolStripMenuItem.Text = "Access Archive";
            // 
            // openArchivedFlightSheetToolStripMenuItem
            // 
            this.openArchivedFlightSheetToolStripMenuItem.Name = "openArchivedFlightSheetToolStripMenuItem";
            this.openArchivedFlightSheetToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openArchivedFlightSheetToolStripMenuItem.Text = "Open Archived Flight Sheet ...";
            this.openArchivedFlightSheetToolStripMenuItem.Click += new System.EventHandler(this.openArchivedFlightSheetToolStripMenuItem_Click);
            // 
            // exitFlightSheetsToolStripMenuItem
            // 
            this.exitFlightSheetsToolStripMenuItem.Name = "exitFlightSheetsToolStripMenuItem";
            this.exitFlightSheetsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitFlightSheetsToolStripMenuItem.Text = "Exit";
            this.exitFlightSheetsToolStripMenuItem.Click += new System.EventHandler(this.exitFlightSheetsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewFlightToolStripMenuItem,
            this.editSToolStripMenuItem,
            this.cloneSelectedFlightToolStripMenuItem,
            this.deleteSelectedFileToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownClosed += new System.EventHandler(this.editToolStripMenuItem_DropDownClosed);
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // addANewFlightToolStripMenuItem
            // 
            this.addANewFlightToolStripMenuItem.Name = "addANewFlightToolStripMenuItem";
            this.addANewFlightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addANewFlightToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addANewFlightToolStripMenuItem.Tag = "add";
            this.addANewFlightToolStripMenuItem.Text = "Add a &new flight ...";
            this.addANewFlightToolStripMenuItem.Click += new System.EventHandler(this.addANewFlightToolStripMenuItem_Click);
            // 
            // editSToolStripMenuItem
            // 
            this.editSToolStripMenuItem.Name = "editSToolStripMenuItem";
            this.editSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editSToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.editSToolStripMenuItem.Tag = "edit";
            this.editSToolStripMenuItem.Text = "&Edit selected flight ...";
            this.editSToolStripMenuItem.Click += new System.EventHandler(this.editSToolStripMenuItem_Click);
            // 
            // cloneSelectedFlightToolStripMenuItem
            // 
            this.cloneSelectedFlightToolStripMenuItem.Name = "cloneSelectedFlightToolStripMenuItem";
            this.cloneSelectedFlightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.cloneSelectedFlightToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cloneSelectedFlightToolStripMenuItem.Tag = "duplicate";
            this.cloneSelectedFlightToolStripMenuItem.Text = "&Duplicate selected flight";
            this.cloneSelectedFlightToolStripMenuItem.Click += new System.EventHandler(this.cloneSelectedFlightToolStripMenuItem_Click);
            // 
            // deleteSelectedFileToolStripMenuItem
            // 
            this.deleteSelectedFileToolStripMenuItem.Name = "deleteSelectedFileToolStripMenuItem";
            this.deleteSelectedFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteSelectedFileToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.deleteSelectedFileToolStripMenuItem.Tag = "delete";
            this.deleteSelectedFileToolStripMenuItem.Text = "Delete selected flight ...";
            this.deleteSelectedFileToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem,
            this.changeFlightSheetFolderToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.extraLargeToolStripMenuItem,
            this.grandpaToolStripMenuItem});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.fontSizeToolStripMenuItem.Text = "Grid Font Size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.CheckOnClick = true;
            this.smallToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.smallToolStripMenuItem.Tag = "0";
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.fontSizeToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.CheckOnClick = true;
            this.mediumToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.mediumToolStripMenuItem.Tag = "1";
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.fontSizeToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.CheckOnClick = true;
            this.largeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.largeToolStripMenuItem.Tag = "2";
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.fontSizeToolStripMenuItem_Click);
            // 
            // extraLargeToolStripMenuItem
            // 
            this.extraLargeToolStripMenuItem.CheckOnClick = true;
            this.extraLargeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.extraLargeToolStripMenuItem.Name = "extraLargeToolStripMenuItem";
            this.extraLargeToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.extraLargeToolStripMenuItem.Tag = "3";
            this.extraLargeToolStripMenuItem.Text = "Extra Large";
            this.extraLargeToolStripMenuItem.Click += new System.EventHandler(this.fontSizeToolStripMenuItem_Click);
            // 
            // grandpaToolStripMenuItem
            // 
            this.grandpaToolStripMenuItem.CheckOnClick = true;
            this.grandpaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.grandpaToolStripMenuItem.Name = "grandpaToolStripMenuItem";
            this.grandpaToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.grandpaToolStripMenuItem.Tag = "4";
            this.grandpaToolStripMenuItem.Text = "Grandpa";
            this.grandpaToolStripMenuItem.Click += new System.EventHandler(this.fontSizeToolStripMenuItem_Click);
            // 
            // changeFlightSheetFolderToolStripMenuItem
            // 
            this.changeFlightSheetFolderToolStripMenuItem.Name = "changeFlightSheetFolderToolStripMenuItem";
            this.changeFlightSheetFolderToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.changeFlightSheetFolderToolStripMenuItem.Text = "System Settings ...";
            this.changeFlightSheetFolderToolStripMenuItem.Click += new System.EventHandler(this.changeFlightSheetFolderToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.aboutGGCFlightSheetsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // aboutGGCFlightSheetsToolStripMenuItem
            // 
            this.aboutGGCFlightSheetsToolStripMenuItem.Name = "aboutGGCFlightSheetsToolStripMenuItem";
            this.aboutGGCFlightSheetsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.aboutGGCFlightSheetsToolStripMenuItem.Text = "About GGC_FlightSheets ...";
            this.aboutGGCFlightSheetsToolStripMenuItem.Click += new System.EventHandler(this.aboutGGCFlightSheetsToolStripMenuItem_Click);
            // 
            // labelClerkAlert
            // 
            this.labelClerkAlert.AutoSize = true;
            this.labelClerkAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClerkAlert.ForeColor = System.Drawing.Color.Red;
            this.labelClerkAlert.Location = new System.Drawing.Point(631, 67);
            this.labelClerkAlert.Name = "labelClerkAlert";
            this.labelClerkAlert.Size = new System.Drawing.Size(274, 31);
            this.labelClerkAlert.TabIndex = 8;
            this.labelClerkAlert.Text = "←Your name please?";
            this.labelClerkAlert.Visible = false;
            // 
            // contextMenuStripFlights
            // 
            this.contextMenuStripFlights.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editThisEntryToolStripMenuItem,
            this.cloneIntoNewEntryToolStripMenuItem,
            this.deleteThisEntryToolStripMenuItem});
            this.contextMenuStripFlights.Name = "contextMenuStripFlights";
            this.contextMenuStripFlights.Size = new System.Drawing.Size(178, 70);
            this.contextMenuStripFlights.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStripFlights_Closing);
            // 
            // editThisEntryToolStripMenuItem
            // 
            this.editThisEntryToolStripMenuItem.Name = "editThisEntryToolStripMenuItem";
            this.editThisEntryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editThisEntryToolStripMenuItem.Text = "Edit this flight ...";
            this.editThisEntryToolStripMenuItem.Click += new System.EventHandler(this.editThisEntryToolStripMenuItem_Click);
            // 
            // cloneIntoNewEntryToolStripMenuItem
            // 
            this.cloneIntoNewEntryToolStripMenuItem.Name = "cloneIntoNewEntryToolStripMenuItem";
            this.cloneIntoNewEntryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cloneIntoNewEntryToolStripMenuItem.Text = "Duplicate this flight";
            this.cloneIntoNewEntryToolStripMenuItem.Click += new System.EventHandler(this.cloneIntoNewEntryToolStripMenuItem_Click);
            // 
            // deleteThisEntryToolStripMenuItem
            // 
            this.deleteThisEntryToolStripMenuItem.Name = "deleteThisEntryToolStripMenuItem";
            this.deleteThisEntryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteThisEntryToolStripMenuItem.Text = "Delete this flight ...";
            this.deleteThisEntryToolStripMenuItem.Click += new System.EventHandler(this.deleteThisEntryToolStripMenuItem_Click);
            // 
            // textBoxFlightSheetRef
            // 
            this.textBoxFlightSheetRef.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFlightSheetRef.Location = new System.Drawing.Point(189, 70);
            this.textBoxFlightSheetRef.Name = "textBoxFlightSheetRef";
            this.textBoxFlightSheetRef.Size = new System.Drawing.Size(60, 26);
            this.textBoxFlightSheetRef.TabIndex = 9;
            this.textBoxFlightSheetRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFlightSheetRef.TextChanged += new System.EventHandler(this.textBoxFlightSheetRef_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(147, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ref No: ";
            // 
            // buttonChangeAirfield
            // 
            this.buttonChangeAirfield.Location = new System.Drawing.Point(570, 39);
            this.buttonChangeAirfield.Name = "buttonChangeAirfield";
            this.buttonChangeAirfield.Size = new System.Drawing.Size(52, 22);
            this.buttonChangeAirfield.TabIndex = 11;
            this.buttonChangeAirfield.Text = "Change";
            this.buttonChangeAirfield.UseVisualStyleBackColor = true;
            this.buttonChangeAirfield.Click += new System.EventHandler(this.buttonChangeAirfield_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(147, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Flight Sheet";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDate.Location = new System.Drawing.Point(147, 53);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "Date:";
            // 
            // labelOverTow
            // 
            this.labelOverTow.AutoSize = true;
            this.labelOverTow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverTow.ForeColor = System.Drawing.Color.Red;
            this.labelOverTow.Location = new System.Drawing.Point(430, 8);
            this.labelOverTow.Name = "labelOverTow";
            this.labelOverTow.Size = new System.Drawing.Size(110, 16);
            this.labelOverTow.TabIndex = 15;
            this.labelOverTow.Text = "Over Tow Alert";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 434);
            this.Controls.Add(this.labelOverTow);
            this.Controls.Add(this.labelClerkAlert);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonChangeAirfield);
            this.Controls.Add(this.textBoxFlightSheetRef);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.comboBoxClerk);
            this.Controls.Add(this.labelClerk);
            this.Controls.Add(this.labelAirfield);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.FlightSheet);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Sheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripFlights.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FlightSheet;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelAirfield;
        private System.Windows.Forms.Label labelClerk;
        private System.Windows.Forms.ComboBox comboBoxClerk;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFlightSheetFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.Label labelClerkAlert;
        private System.Windows.Forms.ToolStripMenuItem extraLargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grandpaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFlights;
        private System.Windows.Forms.ToolStripMenuItem cloneIntoNewEntryToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxFlightSheetRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangeAirfield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelOverTow;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openArchivedFlightSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFlightSheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGGCFlightSheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneSelectedFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editThisEntryToolStripMenuItem;
    }
}

