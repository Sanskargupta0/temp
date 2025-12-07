using Namespace;
using Phase1_G1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
namespace Phase1_G1
{
    public partial class Form1 : Form
    {

        private List<Restaurant> restaurants = new List<Restaurant>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dhaferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dhafer_Form f = new Dhafer_Form();
            f.ShowDialog();
        }

        private void aliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ali_Form f = new Ali_Form();
            f.ShowDialog();
        }

        private void tamimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tamim_form f = new Tamim_form();
            f.ShowDialog();
        }

        private void alwaleedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alwaleed_form f = new Alwaleed_form();
            f.ShowDialog();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructionsForm f = new InstructionsForm();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                frmManipulation f = new frmManipulation();

                LoadFileToGrid(openFileDialog1.FileName, f);

                f.Show();
            }
        }
        private void LoadFileToGrid(string filePath, frmManipulation f)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split('\t');

                f.dataGridView1.Rows.Add
                    (
                    data[0],
                    data[1],
                    data[2],
                    data[3],
                    data[4]
                );
            }
        }

        private void neToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManipulation frm = new frmManipulation();
            frm.ShowDialog();
        }

      
            private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string content = File.ReadAllText(openFileDialog1.FileName);

            frmFileManupulation frm = new frmFileManupulation();

            string[] lines = File.ReadAllLines(openFileDialog1.FileName);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split('\t');
                frm.dataGridView1.Rows.Add(values);
            }

            frm.ShowDialog();
        }
    }
    }


