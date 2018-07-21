using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UserInfo;
namespace UserConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch, userid, userfirstname, userlastname, userpassword, usercoursename, useremail;
            int userchoice, choice;

            UserMethods usermethods = new UserMethods();


            try
            {
                do
                {

                    Console.WriteLine("\nEnter your Choice:\n\n 1 for Add a New User" +
                                      "\n 2 for View All Users\n 3 for View selected User  \n 4 for Update a User  " +
                                      "\n 5 for Delete a User \n 6 for Exit \n");
                    Console.Write("Your choice: ");

                    ch = Console.ReadLine();

                    while (!Int32.TryParse(ch, out userchoice))
                    {
                        Console.WriteLine("\nInvalid Choice!!!!");


                        Console.WriteLine("\nEnter your Choice:\n\n 1 for Add a New User" +
                                        "\n 2 for View All Users \n 3 for View selected User \n 4 for Update a User  " +
                                        "\n 5 for Delete a User \n 6 for Exit \n");
                        Console.Write("Your choice: ");


                        ch = Console.ReadLine();
                    }

                    choice = Int32.Parse(ch);

                    switch (choice)
                    {

                        case 1:
                            int uid;
                            Console.Write("\nEnter User's Id: ");
                            userid = Console.ReadLine();
                            while (!Int32.TryParse(userid, out uid))
                            {
                                Console.WriteLine("Please enter Valid Integer: ");
                                Console.Write("\nEnter User's Id Again: ");
                                userid = Console.ReadLine();
                            }
                            Console.Write("\nEnter User's FirstName: ");
                            userfirstname = Console.ReadLine();
                            while (!(Regex.IsMatch(userfirstname, @"^[a-zA-Z]{3,50}$")))
                            {
                                Console.WriteLine("FirstName should contain minimum 3 and maximum 50 alphabets ");
                                Console.Write("\nEnter User's FirstName Again: ");
                                userfirstname = Console.ReadLine();
                            }
                            Console.Write("\nEnter User's LastName: ");
                            userlastname = Console.ReadLine();
                            while (!(Regex.IsMatch(userlastname, @"^[a-zA-Z]{3,50}$")))
                            {
                                Console.WriteLine("LastName should contain minimum 3 and maximum 50 alphabets ");
                                userlastname = Console.ReadLine();
                            }
                            Console.Write("\nEnter User's Email: ");
                            useremail = Console.ReadLine();
                            while (!(Regex.IsMatch(useremail, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")))
                            {
                                Console.WriteLine("Please enter correct email format. For example: 'akhil@imcs.com' or ' akhil12@imcs.co' or 'akhil.k@imcs.edu' ");
                                Console.Write("\nEnter User's Email Again: ");
                                useremail = Console.ReadLine();
                            }
                            Console.Write("\nEnter User's Password: ");
                            userpassword = Console.ReadLine();
                            while (!(Regex.IsMatch(userpassword, @"^(?=.*\d).{6,15}$")))

                            {
                                Console.WriteLine("Password should be between 6-15 character in length with at least one number, one letter ");
                                Console.Write("\nEnter User's Password Again: ");
                                userpassword = Console.ReadLine();
                            }
                            Console.Write("\nEnter User's CourseName: ");
                            usercoursename = Console.ReadLine();
                            while (!(Regex.IsMatch(usercoursename, @"^[a-zA-Z\+\.]{1,50}$")))
                            {
                                Console.WriteLine("CourseName should contain minimum 1 and maximum 50  ");
                                Console.Write("\nEnter User's CourseName Again: ");
                                usercoursename = Console.ReadLine();
                            }
                            Userdata usera = new Userdata();

                            usera.Id = userid;
                            usera.FirstName = userfirstname;
                            usera.LastName = userlastname;
                            usera.Email = useremail;
                            usera.Password = userpassword;
                            usera.CourseName = usercoursename;

                            usermethods.AddUser(usera);

                            Console.WriteLine("-------------------------------------------------------------------------------------");
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nUser Added Successfully\n");
                            Console.ResetColor();
                            Console.WriteLine("-------------------------------------------------------------------------------------");

                            break;



                        case 2:
                            bool existuserall = usermethods.CheckUser();
                            if (existuserall)
                            {
                                List<Userdata> uservs = usermethods.GetAllUsers();

                                Console.WriteLine("-------------------------------------------------------------------------------------");
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\nUser Details:");


                                foreach (Userdata userdatagetall in uservs)
                                {
                                    Console.WriteLine("---------------");
                                    Console.WriteLine("Id        : " + userdatagetall.Id);
                                    Console.WriteLine("FirstName : " + userdatagetall.FirstName);
                                    Console.WriteLine("LastName  : " + userdatagetall.LastName);
                                    Console.WriteLine("Email     : " + userdatagetall.Email);
                                    Console.WriteLine("Password  : " + userdatagetall.Password);
                                    Console.WriteLine("CourseName: " + userdatagetall.CourseName + "\n");
                                    Console.WriteLine("---------------");

                                }


                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------------------------------------------");
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nNo records found. Please Add users\n");
                                Console.ResetColor();
                                Console.WriteLine("-------------------------------------------------------------------------------------");
                            }
                            Console.ResetColor();
                            Console.WriteLine("-------------------------------------------------------------------------------------");
                            break;

                        case 3:
                            bool existuser = usermethods.CheckUser();
                            if (existuser)
                            {
                                Console.Write("\nEnter Id to select the user: ");
                                userid = Console.ReadLine();
                                int udid;
                                while (!Int32.TryParse(userid, out udid))
                                {
                                    Console.WriteLine("\nPlease enter Valid Integer");
                                    Console.Write("\nEnter Id to sleect the user Again: ");
                                    userid = Console.ReadLine();
                                }
                                bool compareuser = usermethods.CompareUser(userid);

                                if (compareuser)
                                {
                                    Userdata userdataget = usermethods.GetUser(userid);
                                    if (userdataget != null)
                                    {

                                        Console.WriteLine("-------------------------------------------------------------------------------------");
                                        Console.BackgroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("\nUser Details:");
                                        Console.WriteLine("---------------");
                                        Console.WriteLine("Id        : " + userdataget.Id);
                                        Console.WriteLine("FirstName : " + userdataget.FirstName);
                                        Console.WriteLine("LastName  : " + userdataget.LastName);
                                        Console.WriteLine("Email     : " + userdataget.Email);
                                        Console.WriteLine("Password  : " + userdataget.Password);
                                        Console.WriteLine("CourseName: " + userdataget.CourseName + "\n");
                                        Console.WriteLine("-------------------------------------------------------------------------------------");
                                        Console.ResetColor();
                                        Console.WriteLine("-------------------------------------------------------------------------------------");


                                    }

                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\nThe user with id " + userid + " doesnot exist\n");
                                    Console.ResetColor();
                                }
                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------------------------------------------");
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nNo records found. Please Add users\n");
                                Console.ResetColor();
                            }
                            Console.WriteLine("-------------------------------------------------------------------------------------");

                            break;


                        case 4:
                            bool existuseru = usermethods.CheckUser();
                            if (existuseru)
                            {
                                Console.WriteLine("\nEnter Id to update the userdata: ");
                                userid = Console.ReadLine();
                                int usersid;
                                while (!Int32.TryParse(userid, out usersid))
                                {
                                    Console.WriteLine("Please enter Valid Integer");
                                    Console.WriteLine("\nEnter Id to update the userdata Again: ");
                                    userid = Console.ReadLine();
                                }

                                Userdata useru = new Userdata();
                                bool compareuser = usermethods.CompareUser(userid);
                                if (compareuser)
                                {
                                    Console.Write("\nEnter User's New FirstName: ");
                                    userfirstname = Console.ReadLine();
                                    while (!(Regex.IsMatch(userfirstname, @"^[a-zA-Z]{3,50}$")))
                                    {
                                        Console.WriteLine("FirstName should contain minimum 3 and maximum 50 alphabets ");
                                        Console.Write("\nEnter User's New FirstName Again: ");
                                        userfirstname = Console.ReadLine();
                                    }
                                    Console.Write("\nEnter User's New LastName: ");
                                    userlastname = Console.ReadLine();
                                    while (!(Regex.IsMatch(userlastname, @"^[a-zA-Z]{3,50}$")))
                                    {
                                        Console.WriteLine("LastName should contain minimum 3 and maximum 50 alphabets ");
                                        Console.Write("\nEnter User's New LastName Again: ");
                                        userlastname = Console.ReadLine();
                                    }
                                    Console.Write("\nEnter User's New Email: ");
                                    useremail = Console.ReadLine();
                                    while (!(Regex.IsMatch(useremail, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")))
                                    {
                                        Console.WriteLine("Please enter correct email format. For example: 'akhil@imcs.com' or ' akhil12@imcs.co' or 'akhil.k@imcs.edu' ");
                                        Console.Write("\nEnter User's New Email Again: ");
                                        useremail = Console.ReadLine();
                                    }
                                    Console.Write("\nEnter User's New Password: ");
                                    userpassword = Console.ReadLine();
                                    while (!(Regex.IsMatch(userpassword, @"^(?=.*\d).{6,15}$")))
                                    {
                                        Console.WriteLine("Password should be between 6-15 character in length with at least one number, one letter ");
                                        Console.Write("\nEnter User's New Password Again: ");
                                        userpassword = Console.ReadLine();
                                    }
                                    Console.Write("\nEnter User's New CourseName: ");
                                    usercoursename = Console.ReadLine();
                                    while (!(Regex.IsMatch(usercoursename, @"^[a-zA-Z\+\.]{1,50}$")))
                                    {
                                        Console.WriteLine("CourseName should contain minimum 1 and maximum 50  ");
                                        Console.Write("\nEnter User's New CourseName Again: ");
                                        usercoursename = Console.ReadLine();
                                    }

                                    useru.Id = userid;
                                    useru.FirstName = userfirstname;
                                    useru.LastName = userlastname;
                                    useru.Email = useremail;
                                    useru.Password = userpassword;
                                    useru.CourseName = usercoursename;
                                    usermethods.UpdateUser(useru);
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("\nUser data is Updated Successfully\n");
                                    Console.ResetColor();
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\nThe user with id " + userid + " doesnot exist\n");
                                    Console.ResetColor();
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    break;
                                }
                            }


                            else
                            {
                                Console.WriteLine("-------------------------------------------------------------------------------------");
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nNo records found. Please Add users\n");
                                Console.ResetColor();

                                Console.WriteLine("-------------------------------------------------------------------------------------");

                            }

                            break;

                        case 5:
                            bool existuserd = usermethods.CheckUser();

                            if (existuserd)
                            {

                                Console.Write("\nEnter Id to delete the userdata: ");
                                userid = Console.ReadLine();
                                int udid;
                                while (!Int32.TryParse(userid, out udid))
                                {
                                    Console.WriteLine("\nPlease enter Valid Integer");
                                    Console.Write("\nEnter Id to delete the userdata Again: ");
                                    userid = Console.ReadLine();
                                }
                                Userdata userd = new Userdata();
                                bool compareuser = usermethods.CompareUser(userid);
                                Console.WriteLine("-------------------------------------------------------------------------------------");

                                if (compareuser)
                                {
                                    usermethods.DeleteUser(userid);
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nUser Deleted Successfully\n");
                                    Console.ResetColor();
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    break;
                                }

                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\nThe user with id " + userid + " doesnot exist\n");
                                    Console.ResetColor();
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    break;
                                }
                            }

                            else
                            {
                                Console.WriteLine("-------------------------------------------------------------------------------------");
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nNo records found. Please Add users\n");
                                Console.ResetColor();
                                Console.WriteLine("-------------------------------------------------------------------------------------");
                            }
                            break;




                        case 6:
                            Environment.Exit(-1);
                            break;


                        default:
                            Console.WriteLine("-------------------------------------------------------------------------------------");
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid Number \n");
                            Console.ResetColor();
                            Console.WriteLine("-------------------------------------------------------------------------------------");

                            break;
                    }

                } while (choice != 6);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exception message: " + e);
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------");



            }
        }
    }
}




