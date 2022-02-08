using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Workout
    {
        public string Name { get; private set; }
        public string Muscle { get; private set; }

        public Workout(string name, string muscle)
        {
            this.Name = name;
            this.Muscle = muscle;
        }
    }
}
