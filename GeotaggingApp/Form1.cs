using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetBrowser;
using DotNetBrowser.WinForms;
using System.Text.RegularExpressions;
using DotNetBrowser.DOM;
using DotNetBrowser.Events;
using DotNetBrowser.DOM.Events;
using System.Threading;
using System.IO;

namespace GeotaggingApp
{
    public partial class geoForm : Form
    {
        //private WinFormsBrowserView browserView;
        //private Browser browser;

        DataTable dt = new DataTable();
        //string holdMyCSV;
        string holdmyFilePath;
       
        public geoForm()
        {
            InitializeComponent();
        }
        
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                tbURI.Text = "" + winFormsBrowserView1.Browser.URL;
                string myString = tbURI.Text;
                string holdmyString;
                holdmyString = myString.Split(',')[0];
                tbLat.Text = holdmyString.Split('@')[1];
                tbLong.Text = myString.Split(',')[1];
                //tbCoords.Text = (tbLat.Text + "," + tbLong.Text);
                var cellUpdate = dgvCSVtable.CurrentRow;
                var rowColor = dgvCSVtable.CurrentRow;
                rowColor.DefaultCellStyle.BackColor = Color.Yellow;
                cellUpdate.Cells[2].Value = tbLat.Text;
                cellUpdate.Cells[3].Value = tbLong.Text;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                winFormsBrowserView1.Browser.LoadURL("https://www.instantstreetview.com/@" +tbCoords.Text+ ",307.62h,-1.79p,1z");
                LoadCoords();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        void LoadCoords()
        {
            try
            {
                ManualResetEvent waitEvent = new ManualResetEvent(false);
                winFormsBrowserView1.FinishLoadingFrameEvent += delegate (object sender, FinishLoadingEventArgs e)
                {
                    // Wait until main document of the web page is loaded completely.
                    if (e.IsMainFrame)
                    {
                        if (this.tbCoords.Text != null)
                        {
                            waitEvent.Set();
                            DOMDocument document = winFormsBrowserView1.Browser.GetDocument();
                            DOMInputElement searchcoords = (DOMInputElement)document.GetElementById("search");
                            searchcoords.Value = tbCoords.Text;
                            //DOMElement form = document.GetElementById("form");
                            //form.Click();
                            //searchcoords.Click();
                        }
                    }
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadCoordsGmap()
        {
            try
            {
                ManualResetEvent waitEvent = new ManualResetEvent(false);
                winFormsBrowserView2.FinishLoadingFrameEvent += delegate (object sender, FinishLoadingEventArgs e)
                {
                    // Wait until main document of the web page is loaded completely.
                    if (e.IsMainFrame)
                    {
                        if(this.tbCoords.Text != null)
                        {
                            waitEvent.Set();
                            DOMDocument document = winFormsBrowserView2.Browser.GetDocument();
                            DOMInputElement searchgmap = (DOMInputElement)document.GetElementById("searchboxinput");
                            searchgmap.Value = tbCoords.Text;
                            searchgmap.Click();
                            DOMElement searchbutton = document.GetElementById("searchbox-searchbutton");
                            searchbutton.Click();
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

        private void btnParseDisplay_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog1 = new OpenFileDialog();
            if (openfileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                string filename = DialogResult.ToString();
                string filepath = openfileDialog1.FileName;
                tbFilePath.Text = filepath.ToString();
              
            }
            
            string[] raw_csv = System.IO.File.ReadAllLines(tbFilePath.Text);
            string[] data_col = null;
            int x = 0;
            foreach (string row_line in raw_csv)
            {
                data_col = row_line.Split(',');

                if (x == 0)
                {
                    for(int i = 0; i <= data_col.Count()-1; i++)
                    {
                        dt.Columns.Add(data_col[i]);
                    }
                    x++;
                }
                else
                {
                    dt.Rows.Add(data_col);
                }
            }
            dgvCSVtable.DataSource = dt;
            
        }

        private void dgvCSVtable_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvCSVtable.CurrentRow;
            tbLat.Text = row.Cells[2].Value.ToString();
            tbLong.Text = row.Cells[3].Value.ToString();
            tbCoords.Text = (tbLat.Text + "," + tbLong.Text);
            

        }

        private void tbCoords_TextChanged(object sender, EventArgs e)
        {
            try
            {
                winFormsBrowserView1.Browser.LoadURL("https://www.instantstreetview.com/@" + tbCoords.Text + ",307.62h,-1.79p,1z");
                LoadCoords();
                winFormsBrowserView2.Browser.LoadURL("https://www.google.com/maps");
                LoadCoordsGmap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void geoForm_Load(object sender, EventArgs e)
        {
            this.tbURI.Visible = false;
            this.tbCoords.Visible = false;
            this.tbRawCSV.Visible = false;
        }
        
        private void btnExport_Click(object sender, EventArgs e)
        {
            int count_row = dgvCSVtable.RowCount;
            int count_cell = dgvCSVtable.Rows[0].Cells.Count;

            for (int row_index = 0; row_index <= count_row - 2; row_index++)
            {
                for (int cell_index = 0; cell_index <= count_cell - 1; cell_index++)
                {
                    tbRawCSV.Text = tbRawCSV.Text + dgvCSVtable.Rows[row_index].Cells[cell_index].Value.ToString() + ",";
                }
                tbRawCSV.Text = tbRawCSV.Text + "\r\n";

            }
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileOk += CheckIfFileHasCorrectExtension;
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.DefaultExt = "csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                
                StreamWriter writer = new StreamWriter(path);
                writer.Write(tbRawCSV.Text);
                writer.Close();
            }

             MessageBox.Show("Converted successfully to *.csv format");
        }

        void CheckIfFileHasCorrectExtension(object sender, CancelEventArgs e)
        {
            SaveFileDialog sv = (sender as SaveFileDialog);
            if (Path.GetExtension(sv.FileName).ToLower() != ".csv")
            {
                e.Cancel = true;
                MessageBox.Show("Please omit the extension or use 'CSV'");
                return;
            }
        }

        private void geoForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                Application.Exit();
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                this.btnGo.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.I)
            {
                Import_CSV();
                //this.btnParseDisplay.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                this.btnExport.PerformClick();
            }
        }

        private void cTRLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnGo.PerformClick();
        }

        private void cTRLIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnParseDisplay.PerformClick();
        }

        private void cTRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnExport.PerformClick();
        }

        private void aLTF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Import_CSV()
        {
            string directoryPath = Path.GetDirectoryName(tbFilePath.Text);

            string[] raw_csv = System.IO.File.ReadAllLines(tbFilePath.Text);
            string[] data_col = null;
            int x = 0;
                foreach (string row_line in raw_csv)
                {
                    data_col = row_line.Split(',');

                    if (x == 0)
                    {
                    for(int i = 0; i <= data_col.Count()-1; i++)
                    {
                        dt.Columns.Add(data_col[i]);
                    }
                        x++;
                    }
                else
                {
                    dt.Rows.Add(data_col);
                }
            }
            dgvCSVtable.DataSource = dt;
        }

        private void winFormsBrowserView2_DocumentLoadedInMainFrameEvent(object sender, LoadEventArgs e)
        {
            LoadCoordsGmap();
        }
    }
}