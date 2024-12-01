namespace dotnetmvc101.Models
{
    public class Student
    {
        private string id;
        private string name;
        private int score;

        public string Id
        {
            get { return id; }
            set { id = value; }
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
