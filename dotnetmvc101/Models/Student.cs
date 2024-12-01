using System.ComponentModel.DataAnnotations;

namespace dotnetmvc101.Models
{
    public class Student
    {
        private string student_id;
        private int section;
        private string fullname;
        private string nickname;

        [Key]
        public string StudentID
        {
            get { return student_id; }
            set { student_id = value; }
        }

        [Required]
        public int Section
        {
            get { return section; }
            set { section = value; }
        }

        [Required]
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        [Required]
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
    }
}
