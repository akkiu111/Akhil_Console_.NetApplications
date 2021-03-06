﻿using System.Collections.Generic;

namespace UserInfo
{
    public interface Iusermethods
    {
        void AddUser(Userdata userdata);
        List<Userdata> GetAllUsers();
        Userdata GetUser(string userdata);
        void UpdateUser(Userdata userdata);
        void DeleteUser(string userdata);
        bool CheckUser();
        bool CompareUser(string userdata);

    }
}
