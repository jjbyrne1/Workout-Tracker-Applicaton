using System.IO;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        public List<string> muscles { get; private set; }

        private AddWorkoutForm addWorkout;

        private List<Workout> workouts = new List<Workout>();
        public List<Workout> Workouts
        {
            get => workouts;
            set => workouts = value;
        }

        public Home()
        {
            InitializeComponent();

            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            if (!File.Exists(dir + @"\workouts.txt"))
            {
                File.Create(dir + @"\workouts.txt");
            }

            // muscles
            if (!File.Exists(dir + @"\muscles.txt"))
            {
                File.Create(dir + @"\muscles.txt");
            }
            else
            {
                StreamReader sr = new StreamReader(dir + @"\muscles.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    muscles.Add(line);
                }
                sr.Close();
            }


        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void addWorkoutButton_Click(object sender, EventArgs e)
        {
            // create a new form
            addWorkout = new AddWorkoutForm(muscles);
            if (addWorkout.ShowDialog() == DialogResult.OK)
            {
                if (addWorkout.musclesAdded == true) { }
                muscles = addWorkout.muscles;
                workouts.Add(addWorkout.newWorkout);
            }

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {


            // muscles
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            File.Delete(dir + @"\muscles.txt");

            StreamWriter sw = new StreamWriter(dir + @"\muscles.txt");
            foreach(string muscle in muscles)
            {
                sw.WriteLine(muscle);
            }
            sw.Close();
        }
    }
}