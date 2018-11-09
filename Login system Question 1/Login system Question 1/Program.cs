using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_system_Question_1
{//Helen Brennan 9981703

        class Staffuser //new class for staff members 
        {
            public string username;
            public string password;
            //class includes, the members username and password

            public string Username //public get and set for username making it accesible to anyone
            {
                get { return username; }
                set { username = value; }
            }

            public string Password

            {
                private get { return password; } //private get for password so only certain people can access
                set { password = value; }

            }

            public Staffuser(string username, string password)
            {
                Username = username;
                Password = password;
            }
            public string Userset()
            {
                return "Your Username and password has been accepted and set";//method to set employees username and password

            }


            class Program
            {
                static void Main(string[] args)
                {//Question One
                    Console.Write("-------Rotorua Thermal Holiday Park----------\n");
                    Console.Write("Welcome! All staff must create a Username and Password to login and continue\n");

                    Console.Write("Login System\n");

                    Console.WriteLine("Please enter a username containing at least 8 characters");

                    string username = Console.ReadLine();
                    int lenght = username.Length;// counting lenght of username string

                if (lenght <= 8)
                {

                    Console.WriteLine("Username accepted\n");
                }
                else
                {
                    Console.WriteLine("Username does not meet specified conditions please try again");
                }








                Console.Write("Please enter a password that contains 8 characters for your account\n");
                    string password = Console.ReadLine();
                    Console.Write("Please re-enter your password\n");
                    string password2 = Console.ReadLine();

                    if (password == password2)
                    {
                        Console.Write("Password has been accepted");
                    }
                    else
                    {
                        Console.Write("Passwords do not match please try again");



                    }

                    Staffuser staffuser1 = new Staffuser(username, password);

                    Console.WriteLine(staffuser1.Userset());// making new staff object 




                    Console.ReadLine();
                }
                
        
        }
    }
}
