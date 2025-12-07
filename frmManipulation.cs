using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phase1_G1
{
    public partial class frmManipulation : Form
    {
        public frmManipulation()
        {
            InitializeComponent();
        }
        private void frmManipulation_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.RowHeadersVisible = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                        row.Selected = true;
                }

                Clipboard.SetDataObject(dataGridView1.GetClipboardContent());
                File.WriteAllText(saveFileDialog1.FileName, Clipboard.GetText());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Tex files|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.RowHeadersVisible = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                        row.Selected = true;
                }

                Clipboard.SetDataObject(dataGridView1.GetClipboardContent());
                File.WriteAllText(saveFileDialog1.FileName, Clipboard.GetText());
                MessageBox.Show("file saved successfully");
            }
        }
    }
}

        
    
    

