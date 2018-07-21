using System.Collections.Generic;

namespace UserInfo
{


    public class UserMethods : Iusermethods
    {
        List<Userdata> users = new List<Userdata>();

        public void AddUser(Userdata userdata)
        {

            users.Add(userdata);

        }


        public List<Userdata> GetAllUsers()
        {

            return users;
        }

        public Userdata GetUser(string userdata)
        {

            foreach (var user in users)
            {

                if (user.Id == userdata)
                {
                    return user;

                }

            }
            return null;


        }


        public void UpdateUser(Userdata userdata)
        {
            foreach (var user in users)
            {
                if (user.Id == userdata.Id)
                {
                    user.FirstName = userdata.FirstName;
                    user.LastName = userdata.LastName;
                    user.Email = userdata.Email;
                    user.Password = userdata.Password;
                    user.CourseName = userdata.CourseName;
                    break;
                }
            }
        }



        public void DeleteUser(string userdata)
        {



            foreach (var user in users)
            {
                if (user.Id == userdata)
                {
                    int userindex = users.IndexOf(user);
                    users.RemoveAt(userindex);
                    break;
                }
            }

        }



        public bool CheckUser()
        {

            if (users.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CompareUser(string userid)
        {
            int flag = 0;
            foreach (var userdata in users)
            {
                if (userdata.Id == userid)
                {
                    flag = 1;
                    break;

                }
                else
                {
                    flag = 0;
                }

            }

            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

