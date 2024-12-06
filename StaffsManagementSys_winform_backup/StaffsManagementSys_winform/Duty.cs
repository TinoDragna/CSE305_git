using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffsManagementSys_winform
{
    public partial class Duty : Form
    {
        public Duty()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text files (*.txt)|(*.txt)";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = new string[5];
                lines[0] = txtID.Text;
                lines[1] = txtName.Text;
                lines[2] = dutyDate.Text;
                lines[3] = txtTImeStart.Text;
                lines[4] = txtTimeEnd.Text;
                lines[5] = txtPlace.Text;

                File.WriteAllLines(saveFileDialog.FileName, lines);
                MessageBox.Show("Duty data saved!");
            }
        }
    }
}
