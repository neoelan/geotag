using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeotaggingApp
{
    public partial class GeoImport : Form
    {
        private string holdmyFilePath;

        public string HoldmyFilePath
        {
            get { return holdmyFilePath; }
            set { holdmyFilePath = value; }
        }

        public GeoImport()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                tbFilePathImport.Text = openFileDialog1.FileName;
                holdmyFilePath = tbFilePathImport.Text;
                new geoForm().Show();
               // this.Close();
            }
        }
    }
}
