using System.ComponentModel.DataAnnotations;

namespace dotnetmvc101.Models
{
    public class Student
    {
        private string student_id;
        private string name;
        private int score;

        [Key]
        public string StudentID
        {
            get { return student_id; }
            set { student_id = value; }
        }

        [Required]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Required]
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
