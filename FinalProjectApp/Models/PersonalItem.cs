using System;
using SQLite;

namespace  FinalProjectApp.Models
{
    public class PersonalItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

      

        public string TheDay { get; set; }
        public string MuscleGroup { get; set; }
        public string Exercise { get; set; }
        public string Sets { get; set; }
        public string Reps { get; set; }
        public string Image { get; set; }

        public string dayOff { get; set; }

        public string Header
        {

            get
            {
                return string.Format("Muscle Group: {0}", MuscleGroup); //format for details on imagecell
            }
        }
        public string Detail
        {

            get
            {
                return string.Format("Muscle Group: {0}\nExercise: {1}, Sets: {2}, Reps: {3}",MuscleGroup, Exercise, Sets, Reps); //format for details on imagecell
            }
        }
    }
}
