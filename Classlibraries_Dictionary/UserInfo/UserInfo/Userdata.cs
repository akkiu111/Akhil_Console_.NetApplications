namespace UserInfo
{
    public class Userdata
    {

        private string id;
        private string firstname;
        private string lastname;
        private string email;
        private string password;
        private string coursename;


        public string Id
        {
            get { return id; }
            set { id = value; }
        }



        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string CourseName
        {
            get { return coursename; }
            set { coursename = value; }
        }



        public Userdata()
        {
        }


    }
}

