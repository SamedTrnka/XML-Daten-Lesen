using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Übung_11_Fortgeschritten
{
    public partial class FrmAusgabe : Form
    {
        private String dateipfad = string.Empty;
        public FrmAusgabe()
        {
            InitializeComponent();
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "xml Dateien (*.xml)|*.xml|alle Dateien|*.*";
            open.FilterIndex = 2;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                dateipfad = open.FileName;
            }
        }

        private void BtnAusgabe_Click(object sender, EventArgs e)
        {
                DataSet ds = new DataSet();
                ds.ReadXml(dateipfad);
                dgvAusgabe.DataSource = ds;
                dgvAusgabe.DataMember = txbKnotenpunkt.Text;
            
        }
    }
}
