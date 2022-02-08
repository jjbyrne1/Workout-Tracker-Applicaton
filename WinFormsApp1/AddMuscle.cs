using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddMuscle : Form
    {
        private string muscle;

        public AddMuscle(List<string> muscles)
        {
            InitializeComponent();
        }

        private void addMuscleButton_Click(object sender, EventArgs e)
        {
            if (muscles.Contains(muscleNameTextbox.Text))
            {
                MessageBox.Show("This mucle already exists");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
