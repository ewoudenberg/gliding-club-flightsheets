namespace au.org.GGC {
    partial class ArchivedSheetSelector {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonOpenExisting = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxFileList = new System.Windows.Forms.ListBox();
            this.buttonOpenTodaySheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenExisting
            // 
            this.buttonOpenExisting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenExisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenExisting.Location = new System.Drawing.Point(306, 600);
            this.buttonOpenExisting.Name = "buttonOpenExisting";
            this.buttonOpenExisting.Size = new System.Drawing.Size(81, 34);
            this.buttonOpenExisting.TabIndex = 4;
            this.buttonOpenExisting.Text = "Open";
            this.buttonOpenExisting.UseVisualStyleBackColor = true;
            this.buttonOpenExisting.Click += new System.EventHandler(this.buttonOpenExisting_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select File Name";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(35, 600);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(81, 34);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // listBoxFileList
            // 
            this.listBoxFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFileList.FormattingEnabled = true;
            this.listBoxFileList.HorizontalScrollbar = true;
            this.listBoxFileList.ItemHeight = 18;
            this.listBoxFileList.Location = new System.Drawing.Point(35, 84);
            this.listBoxFileList.Name = "listBoxFileList";
            this.listBoxFileList.Size = new System.Drawing.Size(352, 490);
            this.listBoxFileList.TabIndex = 10;
            this.listBoxFileList.SelectedIndexChanged += new System.EventHandler(this.listBoxFileList_SelectedIndexChanged);
            this.listBoxFileList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFileList_MouseDoubleClick);
            // 
            // buttonOpenTodaySheet
            // 
            this.buttonOpenTodaySheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenTodaySheet.Location = new System.Drawing.Point(35, 8);
            this.buttonOpenTodaySheet.Name = "buttonOpenTodaySheet";
            this.buttonOpenTodaySheet.Size = new System.Drawing.Size(172, 34);
            this.buttonOpenTodaySheet.TabIndex = 11;
            this.buttonOpenTodaySheet.Text = "Open today\'s sheet";
            this.buttonOpenTodaySheet.UseVisualStyleBackColor = true;
            this.buttonOpenTodaySheet.Click += new System.EventHandler(this.buttonOpenTodaySheet_Click);
            // 
            // ArchivedSheetSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 659);
            this.Controls.Add(this.buttonOpenTodaySheet);
            this.Controls.Add(this.listBoxFileList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOpenExisting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(331, 246);
            this.Name = "ArchivedSheetSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Flight Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenExisting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxFileList;
        private System.Windows.Forms.Button buttonOpenTodaySheet;
    }
}