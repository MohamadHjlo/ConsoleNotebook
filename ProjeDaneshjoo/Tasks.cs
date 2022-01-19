using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDaneshjoo
{
    internal class Tasks
    {
        public static int Arraynumber;

        public static User[] Users;

        public static void AddUser()
        {
            bool IsvalidInputs = true;
            bool IsUserIsUnique = false;
            Console.WriteLine("\r\n" + "please enter user name" + "\r\n");
            string name = Console.ReadLine();
            Console.WriteLine("\r\n" + "please enter phone number" + "\r\n");
            string phone = Console.ReadLine();
            Console.WriteLine("\r\n" + "please enter EmailAddress" + "\r\n");
            string email = Console.ReadLine();
            Console.WriteLine("\r\n" + "please enter Country" + "\r\n");
            string country = Console.ReadLine();
            if (phone != null && (phone.Trim().Length != 11))
            {
                Console.WriteLine($"Phone number Length is not Valid" + "\r\n", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                IsvalidInputs = false;
            }
            if (phone != null && !phone.Trim().StartsWith("0"))
            {
                Console.WriteLine($"Phone number Must start with 0" + "\r\n", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                IsvalidInputs = false;
            }
            if (email != null && !email.Trim().Contains("@"))
            {
                Console.WriteLine($"Email is not Valid .... Email must contains ' @ ' character" + "\r\n", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                IsvalidInputs = false;
            }
            if (email != null && !email.Trim().Contains(".com"))
            {
                Console.WriteLine($"Email is not Valid .... Email must contains ' .com ' " + "\r\n", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                IsvalidInputs = false;
            }
            if (IsvalidInputs == false)
            {
                return;
            }

            if (Users?.Length > 0)
            {

                User[] users = new User[Users.Length + 1];
                Arraynumber++;
                for (int i = 0; i < Users.Length; i++)
                {
                    if (Users[i] != null)//امکان داره یوزر پاک شده باشه پس چک میشه
                    {
                        if (name != null && Users[i].Name.Trim().ToLower() == name.Trim().ToLower())
                        {
                            Console.WriteLine($"there are an user which his name is {name}" + "\r\n", Console.ForegroundColor = ConsoleColor.Red);
                            Console.ResetColor();
                            Arraynumber--;
                            return;
                        }
                        if (phone != null&&Users[i].PhoneNumber.Trim().ToLower() == phone.Trim().ToLower())
                        {
                            Console.WriteLine($"there are an user which his phone number is {phone}" + "\r\n", Console.ForegroundColor = ConsoleColor.Red);
                            Console.ResetColor();
                            Arraynumber--;
                            return;
                        }

                        users[i] = new User
                        {
                            Name = Users[i].Name,
                            PhoneNumber = Users[i].PhoneNumber,
                            Email = Users[i].Email,
                            Country = Users[i].Country
                        };
                    }

                    users[Arraynumber - 1] = new User()     
                    {
                        Name = name,
                        PhoneNumber = phone,
                        Email = email,
                        Country = country
                    };
                }
                Users = users;
            }
            else
            {
                Arraynumber++;
                Users = new User[Arraynumber];
                Users[Arraynumber - 1] = new User();
                Users[Arraynumber - 1].Name = name;
                Users[Arraynumber - 1].PhoneNumber = phone;
                Users[Arraynumber - 1].Email = email;
                Users[Arraynumber - 1].Country = country;
            }

            Console.WriteLine(name + " With Number " + phone + "  SuccessFully Added" + "\r\n", Console.ForegroundColor = ConsoleColor.Magenta);
            Console.ResetColor();
            Console.WriteLine("Tedad kol Ta alann " + Arraynumber);
        }

        public static void UpdateUser()
        {
            Console.WriteLine("\r\n" + "please enter Name To be Updated" + "\r\n");

            string input = Console.ReadLine();

            if (Users == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is Empty");
                Console.ResetColor();
                return;
            }
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i] != null)
                {
                    if (Users[i].Name == input)
                    {
                        Console.WriteLine("  User Where Found :  " + "\r\n", Console.ForegroundColor = ConsoleColor.Yellow);
                        Console.ResetColor();
                        Console.WriteLine("  Name :  " + Users[i].Name);
                        Console.WriteLine("  Phone Number :  " + Users[i].PhoneNumber);
                        Console.WriteLine("  Email : " + Users[i].Email);
                        Console.WriteLine("  Country : " + Users[i].Country + "\r\n");
                        Console.WriteLine("Press Any Key to Resume Editing");
                        Console.ReadKey();
                        Console.WriteLine("\r\n" + "please enter new Name" + "\r\n");
                        string name = Console.ReadLine();
                        Console.WriteLine("\r\n" + "please enter new PhoneNumber" + "\r\n");
                        string phone = Console.ReadLine();
                        Console.WriteLine("\r\n" + "please enter new Email" + "\r\n");
                        string email = Console.ReadLine();
                        Console.WriteLine("\r\n" + "please enter user Country" + "\r\n");
                        string country = Console.ReadLine();
                        Users[i].Name = name;
                        Users[i].PhoneNumber = phone;
                        Users[i].Email = email;
                        Users[i].Country = country;
                        Console.WriteLine("User Has Been Edited SuccessFuly" + "\r\n", Console.ForegroundColor = ConsoleColor.Cyan);
                        Console.ResetColor();
                    }
                }
            }
        }

        public static void DeleteUser()
        {
            Console.WriteLine("\r\n" + "please enter Name To be Deleted" + "\r\n");

            string input = Console.ReadLine();

            if (Users == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is Empty");
                Console.ResetColor();
                return;
            }
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i] != null)
                {
                    if (Users[i].Name == input)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"User  {Users[i].Name} Has Been Deleterd SuccessFully");
                        Console.ResetColor();
                        Users[i] = null;
                    }
                }
            }
        }

        public static void SearchByName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\n" + "please enter Name To be Search" + "\r\n");
            Console.ResetColor();


            string input = Console.ReadLine();

            if (Users == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is Empty" + "\r\n");
                Console.ResetColor();
                return;
            }
            Console.WriteLine($"Names Where Contains ' {input} ' :", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
            int resultCounter = 0;
            foreach (var user in Users)
            {
                if (user != null)
                {
                    if (input != null && user.Name.Trim().Contains(input))
                    {
                        resultCounter++;
                        Console.WriteLine("  Name :  " + user.Name);
                        Console.WriteLine("  Phone Number :  " + user.PhoneNumber);
                        Console.WriteLine("  Email : " + user.Email);
                        Console.WriteLine("  Country : " + user.Country + "\r\n");
                        Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦" + "\r\n", Console.ForegroundColor = ConsoleColor.Cyan);
                        Console.ResetColor();
                    }
                }
            }
            if (resultCounter == 0)
            {
                Console.WriteLine("\r\n" + $"Not Found Such Result For '{input}'" + "\r\n", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
            }
        }

        public static void SearchByPhoneNumber()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\n" + "please enter PhoneNumber To be Search" + "\r\n");
            Console.ResetColor();

            string input = Console.ReadLine();

            if (Users == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is Empty" + "\r\n");
                Console.ResetColor();
                return;
            }
            Console.WriteLine($"PhoneNumbers Where Contains ' {input} ' :", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
            int phoneresultCounter = 0;
            foreach (var user in Users)
            {
                if (user != null)
                {
                    if (input != null && user.PhoneNumber.Trim().Contains(input))
                    {
                        phoneresultCounter++;
                        Console.WriteLine("  Name :  " + user.Name);
                        Console.WriteLine("  Phone Number :  " + user.PhoneNumber);
                        Console.WriteLine("  Email : " + user.Email);
                        Console.WriteLine("  Country : " + user.Country + "\r\n");
                        Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦" + "\r\n", Console.ForegroundColor = ConsoleColor.Cyan);
                        Console.ResetColor();
                    }
                }
            }
            if (phoneresultCounter == 0)
            {
                Console.WriteLine("\r\n" + $"Not Found Such Result For '{input}'" + "\r\n", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
            }
        }

        public static void GetAllRecords()
        {

            if (Users != null)
            {
                Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦" + "\r\n", Console.ForegroundColor = ConsoleColor.Cyan);
                Console.ResetColor();
                for (int i = 0; i < Users.Length; i++)
                {
                    if (Users[i] != null)
                    {
                        int counter = i + 1;
                        Console.WriteLine("  " + counter, Console.ForegroundColor = ConsoleColor.Cyan);
                        Console.ResetColor();
                        Console.WriteLine("  Name :  " + Users[i].Name);
                        Console.WriteLine("  Phone Number :  " + Users[i].PhoneNumber);
                        Console.WriteLine("  Email : " + Users[i].Email);
                        Console.WriteLine("  Country : " + Users[i].Country + "\r\n");
                        Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦" + "\r\n", Console.ForegroundColor = ConsoleColor.Cyan);
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
