namespace GeotaggingApp
{
    partial class geoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(geoForm));
            this.winFormsBrowserView1 = new DotNetBrowser.WinForms.WinFormsBrowserView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbRawCSV = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.tbURI = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnParseDisplay = new System.Windows.Forms.Button();
            this.tbLat = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbLong = new System.Windows.Forms.TextBox();
            this.tbCoords = new System.Windows.Forms.TextBox();
            this.dgvCSVtable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.winFormsBrowserView2 = new DotNetBrowser.WinForms.WinFormsBrowserView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCoordinatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTRLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTRLIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTRLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVtable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // winFormsBrowserView1
            // 
            this.winFormsBrowserView1.AcceptLanguage = null;
            this.winFormsBrowserView1.AudioMuted = null;
            this.winFormsBrowserView1.BrowserType = DotNetBrowser.BrowserType.HEAVYWEIGHT;
            this.winFormsBrowserView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winFormsBrowserView1.InitialFocusOwner = false;
            this.winFormsBrowserView1.Location = new System.Drawing.Point(3, 3);
            this.winFormsBrowserView1.Name = "winFormsBrowserView1";
            this.winFormsBrowserView1.Preferences = null;
            this.winFormsBrowserView1.Size = new System.Drawing.Size(990, 649);
            this.winFormsBrowserView1.TabIndex = 0;
            this.winFormsBrowserView1.URL = "https://www.instantstreetview.com/";
            this.winFormsBrowserView1.ZoomLevel = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 681);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.tbRawCSV);
            this.splitContainer2.Panel1.Controls.Add(this.btnExport);
            this.splitContainer2.Panel1.Controls.Add(this.tbURI);
            this.splitContainer2.Panel1.Controls.Add(this.tbFilePath);
            this.splitContainer2.Panel1.Controls.Add(this.btnGo);
            this.splitContainer2.Panel1.Controls.Add(this.btnParseDisplay);
            this.splitContainer2.Panel1.Controls.Add(this.tbLat);
            this.splitContainer2.Panel1.Controls.Add(this.btnInsert);
            this.splitContainer2.Panel1.Controls.Add(this.tbLong);
            this.splitContainer2.Panel1.Controls.Add(this.tbCoords);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvCSVtable);
            this.splitContainer2.Size = new System.Drawing.Size(342, 657);
            this.splitContainer2.SplitterDistance = 126;
            this.splitContainer2.TabIndex = 9;
            // 
            // tbRawCSV
            // 
            this.tbRawCSV.Location = new System.Drawing.Point(12, 159);
            this.tbRawCSV.Multiline = true;
            this.tbRawCSV.Name = "tbRawCSV";
            this.tbRawCSV.Size = new System.Drawing.Size(207, 23);
            this.tbRawCSV.TabIndex = 10;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(173, 93);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tbURI
            // 
            this.tbURI.Location = new System.Drawing.Point(12, 188);
            this.tbURI.Name = "tbURI";
            this.tbURI.Size = new System.Drawing.Size(288, 20);
            this.tbURI.TabIndex = 0;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(64, 12);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(264, 20);
            this.tbFilePath.TabIndex = 8;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(173, 64);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(155, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Get New Coordinates";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnParseDisplay
            // 
            this.btnParseDisplay.Location = new System.Drawing.Point(12, 93);
            this.btnParseDisplay.Name = "btnParseDisplay";
            this.btnParseDisplay.Size = new System.Drawing.Size(155, 23);
            this.btnParseDisplay.TabIndex = 7;
            this.btnParseDisplay.Text = "Import CSV";
            this.btnParseDisplay.UseVisualStyleBackColor = true;
            this.btnParseDisplay.Click += new System.EventHandler(this.btnParseDisplay_Click);
            // 
            // tbLat
            // 
            this.tbLat.Location = new System.Drawing.Point(64, 38);
            this.tbLat.Name = "tbLat";
            this.tbLat.Size = new System.Drawing.Size(100, 20);
            this.tbLat.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 64);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(155, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Refresh Coordinates";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbLong
            // 
            this.tbLong.Location = new System.Drawing.Point(228, 38);
            this.tbLong.Name = "tbLong";
            this.tbLong.Size = new System.Drawing.Size(100, 20);
            this.tbLong.TabIndex = 3;
            // 
            // tbCoords
            // 
            this.tbCoords.Location = new System.Drawing.Point(121, 151);
            this.tbCoords.Name = "tbCoords";
            this.tbCoords.Size = new System.Drawing.Size(207, 20);
            this.tbCoords.TabIndex = 4;
            this.tbCoords.TextChanged += new System.EventHandler(this.tbCoords_TextChanged);
            // 
            // dgvCSVtable
            // 
            this.dgvCSVtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCSVtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSVtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCSVtable.Location = new System.Drawing.Point(0, 0);
            this.dgvCSVtable.MultiSelect = false;
            this.dgvCSVtable.Name = "dgvCSVtable";
            this.dgvCSVtable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCSVtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCSVtable.Size = new System.Drawing.Size(342, 527);
            this.dgvCSVtable.TabIndex = 6;
            this.dgvCSVtable.SelectionChanged += new System.EventHandler(this.dgvCSVtable_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 681);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.winFormsBrowserView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Instant Streetview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.winFormsBrowserView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Google Maps";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // winFormsBrowserView2
            // 
            this.winFormsBrowserView2.AcceptLanguage = null;
            this.winFormsBrowserView2.AudioMuted = null;
            this.winFormsBrowserView2.BrowserType = DotNetBrowser.BrowserType.HEAVYWEIGHT;
            this.winFormsBrowserView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winFormsBrowserView2.InitialFocusOwner = false;
            this.winFormsBrowserView2.Location = new System.Drawing.Point(3, 3);
            this.winFormsBrowserView2.Name = "winFormsBrowserView2";
            this.winFormsBrowserView2.Preferences = null;
            this.winFormsBrowserView2.Size = new System.Drawing.Size(990, 649);
            this.winFormsBrowserView2.TabIndex = 1;
            this.winFormsBrowserView2.URL = "https://www.google.com/maps";
            this.winFormsBrowserView2.ZoomLevel = null;
            this.winFormsBrowserView2.DocumentLoadedInMainFrameEvent += new DotNetBrowser.Events.DocumentLoadedInMainFrameHandler(this.winFormsBrowserView2_DocumentLoadedInMainFrameEvent);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getCoordinatesToolStripMenuItem,
            this.importCSVToolStripMenuItem,
            this.exportCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // getCoordinatesToolStripMenuItem
            // 
            this.getCoordinatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTRLCToolStripMenuItem});
            this.getCoordinatesToolStripMenuItem.Name = "getCoordinatesToolStripMenuItem";
            this.getCoordinatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.getCoordinatesToolStripMenuItem.Text = "Get Coordinates";
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTRLIToolStripMenuItem});
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importCSVToolStripMenuItem.Text = "Import CSV";
            // 
            // exportCSVToolStripMenuItem
            // 
            this.exportCSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTRLEToolStripMenuItem});
            this.exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            this.exportCSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportCSVToolStripMenuItem.Text = "Export CSV";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLTF4ToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // cTRLCToolStripMenuItem
            // 
            this.cTRLCToolStripMenuItem.Name = "cTRLCToolStripMenuItem";
            this.cTRLCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cTRLCToolStripMenuItem.Text = "CTRL + C";
            this.cTRLCToolStripMenuItem.Click += new System.EventHandler(this.cTRLCToolStripMenuItem_Click);
            // 
            // cTRLIToolStripMenuItem
            // 
            this.cTRLIToolStripMenuItem.Name = "cTRLIToolStripMenuItem";
            this.cTRLIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cTRLIToolStripMenuItem.Text = "CTRL + I";
            this.cTRLIToolStripMenuItem.Click += new System.EventHandler(this.cTRLIToolStripMenuItem_Click);
            // 
            // cTRLEToolStripMenuItem
            // 
            this.cTRLEToolStripMenuItem.Name = "cTRLEToolStripMenuItem";
            this.cTRLEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cTRLEToolStripMenuItem.Text = "CTRL + E";
            this.cTRLEToolStripMenuItem.Click += new System.EventHandler(this.cTRLEToolStripMenuItem_Click);
            // 
            // aLTF4ToolStripMenuItem
            // 
            this.aLTF4ToolStripMenuItem.Name = "aLTF4ToolStripMenuItem";
            this.aLTF4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aLTF4ToolStripMenuItem.Text = "ALT + F4";
            this.aLTF4ToolStripMenuItem.Click += new System.EventHandler(this.aLTF4ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Latitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Longitude:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "File Path:";
            // 
            // geoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "geoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEACH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.geoForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.geoForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVtable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DotNetBrowser.WinForms.WinFormsBrowserView winFormsBrowserView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.TextBox tbLong;
        private System.Windows.Forms.TextBox tbLat;
        private System.Windows.Forms.TextBox tbCoords;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvCSVtable;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnParseDisplay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DotNetBrowser.WinForms.WinFormsBrowserView winFormsBrowserView2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox tbRawCSV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCoordinatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTRLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTRLIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTRLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLTF4ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

