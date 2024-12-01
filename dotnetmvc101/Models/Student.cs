namespace dotnetmvc101.Models
{
    public class Student
    {
        private string student_id;
        private string name;
        private int score;

        public string StudentID
        {
            get { return student_id; }
            set { student_id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
