using System.Collections.Generic;

namespace UserInfo
{


    public class UserMethods : Iusermethods
    {
        Userdata ud = new Userdata();
        //int keyforuser = 0;
        Dictionary<string, Userdata> users = new Dictionary<string, Userdata>();

        public void AddUser(Userdata userdata)
        {

            users.Add(userdata.Id, userdata);
            //keyforuser += 1;

        }


        public Dictionary<string, Userdata> GetAllUsers()
        {

            return users;
        }

        public Userdata GetUser(string userdata)
        {

            foreach (KeyValuePair<string, Userdata> user in users)
            {

                if (user.Value.Id == userdata)
                {
                    return user.Value;

                }

            }
            return null;


        }


        public void UpdateUser(Userdata userdata)
        {
            foreach (KeyValuePair<string, Userdata> user in users)
            {
                if (user.Value.Id == userdata.Id)
                {
                    user.Value.FirstName = userdata.FirstName;
                    user.Value.LastName = userdata.LastName;
                    user.Value.Email = userdata.Email;
                    user.Value.Password = userdata.Password;
                    user.Value.CourseName = userdata.CourseName;
                    break;
                }
            }
        }



        public void DeleteUser(string userdata)
        {

            foreach (KeyValuePair<string, Userdata> user in users)
            {
                if (user.Value.Id == userdata)
                {
                    /*int userindex =*/
                    //users.Remove(keyforuser);
                    //users.RemoveAt(userindex);
                    users.Remove(userdata);
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
            foreach (KeyValuePair<string, Userdata> userdata in users)
            {
                if (userdata.Value.Id == userid)
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

