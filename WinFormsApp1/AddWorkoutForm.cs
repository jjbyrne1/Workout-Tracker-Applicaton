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
    public partial class AddWorkoutForm : Form
    {
        public Workout newWorkout { get; private set; }

        public bool musclesAdded { get; private set; }

        public List<string> muscles { get; private set; }

        public AddWorkoutForm(List<string> muscles)
        {
            InitializeComponent();

            this.muscles = muscles;
            if (muscles.Count > 0)
            {
                foreach(string muscle in muscles)
                {
                    comboBox1.Items.Add(muscle);
                }
            }
            
        }

        private void createWorkoutButton_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem.ToString() == "Core" && this.workoutNameTextbox.Text == "d")
            {

                MessageBox.Show("error. workout already exists");
                //problemLabel.Text = "This workout already exists";
            }
            else
            {
                newWorkout = new Workout(this.workoutNameTextbox.Text, this.comboBox1.SelectedItem.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            createWorkoutButton.Enabled = true;
        }

        private void workoutNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if(workoutNameTextbox.Text.Length == 0)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
        }

        private void comboBox1_EnabledChanged(object sender, EventArgs e)
        {
            if (comboBox1.Enabled == false) createWorkoutButton.Enabled = false;
            else
            {
                if (comboBox1.SelectedItem != null)
                {
                    createWorkoutButton.Enabled = true;
                }
            }
            
        }

        private void addMuscleButton_Click(object sender, EventArgs e)
        {
            AddMuscle addMuscle = new AddMuscle(muscles);
            if (addMuscle.ShowDialog() == DialogResult.OK)
            {
                musclesAdded = true;
                muscles = addMuscle.muscles;
            }
        }
    }
}
