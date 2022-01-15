using System;

namespace ProjeDaneshjoo
{
    internal class Program
    {
        public static int _arraynumber;

        public static User[] _users;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int x = 0;
            for (int i = 1; x <= 20; i++)
            {
                if (x % i != 0)
                {
                    x += 1;
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        public static void CallTasks()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please Enter a Number of Obtions");
                Console.ResetColor();
                Console.WriteLine("1 :   Add");
                Console.WriteLine("2 :   Delete");
                Console.WriteLine("3 :   Edit");
                Console.WriteLine("4 :   Search By Name");
                Console.WriteLine("5 :   Search By PhoneNumber");
                Console.WriteLine("6 :   GetAllRecords");
                int option = int.Parse(Console.ReadLine()?.Trim() ?? string.Empty);
                if (option == 1)
                {
                    AddUser();
                }

                if (option == 2)
                {
                    DeleteUser();
                }

                if (option == 3)
                {
                    UpdateUser();
                }

                if (option == 4)
                {
                    SearchByName();
                }

                if (option == 5)
                {
                    SearchByPhoneNumber();
                }
                if (option == 6)
                {
                    GetAllRecords();
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter A Valid Option" + "\r\n");
                Console.ResetColor();
            }
            finally
            {
                CallTasks();
            }
        }
        public static void AddUser()
        {
            Console.WriteLine("\r\n" + "please enter user name" + "\r\n");
            string name = Console.ReadLine();
            Console.WriteLine("\r\n" + "please enter phone number" + "\r\n");
            string phone = Console.ReadLine();
            Console.WriteLine("\r\n" + "please enter EmailAddress" + "\r\n");
            string email = Console.ReadLine();
            Console.WriteLine("\r\n" + "please enter Country" + "\r\n");
            string country = Console.ReadLine();
            _arraynumber++;
            if (_users?.Length > 0)
            {
                User[] users = new User[_users.Length + 1];
                for (int i = 0; i < _users.Length; i++)
                {
                    if (_users[i] != null)
                    {
                        users[i] = new User
                        {
                            Name = _users[i].Name,
                            PhoneNumber = _users[i].PhoneNumber,
                            Email = _users[i].Email,
                            Country = _users[i].Country
                        };
                    }
                    _users[_arraynumber - 1] = new User();
                    _users[_arraynumber - 1].Name = name;
                    _users[_arraynumber - 1].PhoneNumber = phone;
                    _users[_arraynumber - 1].Email = email;
                    _users[_arraynumber - 1].Country = country;

                }
                _users = users;
            }
            else
            {
                _users = new User[_arraynumber + 1];
                _users[_arraynumber - 1] = new User();
                _users[_arraynumber - 1].Name = name;
                _users[_arraynumber - 1].PhoneNumber = phone;
                _users[_arraynumber - 1].Email = email;
                _users[_arraynumber - 1].Country = country;
            }

            Console.WriteLine(name + " With Number " + phone + "  SuccessFully Added" + "\r\n", Console.ForegroundColor = ConsoleColor.Magenta);
            Console.ResetColor();
            Console.WriteLine("Tedad kol Ta alann " + _arraynumber);
        }

        public static void UpdateUser()
        {
            Console.WriteLine("\r\n" + "please enter Name To be Updated" + "\r\n");

            string input = Console.ReadLine();

            if (_users == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is Empty");
                Console.ResetColor();
                return;
            }
            for (int i = 0; i < _users.Length; i++)
            {
                if (_users[i] != null)
                {
                    if (_users[i].Name == input)
                    {
                        Console.WriteLine("  User Where Found :  " + "\r\n", Console.ForegroundColor = ConsoleColor.Yellow);
                        Console.ResetColor();
                        Console.WriteLine("  Name :  " + _users[i].Name);
                        Console.WriteLine("  Phone Number :  " + _users[i].PhoneNumber);
                        Console.WriteLine("  Email : " + _users[i].Email);
                        Console.WriteLine("  Country : " + _users[i].Country + "\r\n");
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
                        _users[i].Name = name;
                        _users[i].PhoneNumber = phone;
                        _users[i].Email = email;
                        _users[i].Country = country;
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

            if (_users == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is Empty");
                Console.ResetColor();
                return;
            }
            for (int i = 0; i < _users.Length; i++)
            {
                if (_users[i] != null)
                {
                    if (_users[i].Name == input)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"User  {_users[i].Name} Has Been Deleterd SuccessFully");
                        Console.ResetColor();
                        _users[i] = null;
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

            if (_users == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is Empty" + "\r\n");
                Console.ResetColor();
                return;
            }
            Console.WriteLine($"Names Where Contains ' {input} ' :", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
            int resultCounter = 0;
            foreach (var user in _users)
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

            if (_users == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is Empty" + "\r\n");
                Console.ResetColor();
                return;
            }
            Console.WriteLine($"PhoneNumbers Where Contains ' {input} ' :", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
            int phoneresultCounter = 0;
            foreach (var user in _users)
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

            if (_users != null)
            {
                Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦" + "\r\n", Console.ForegroundColor = ConsoleColor.Cyan);
                Console.ResetColor();
                for (int i = 0; i < _users.Length - 1; i++)
                {
                    if (_users[i] != null)
                    {
                        int counter = i + 1;
                        Console.WriteLine("  " + counter, Console.ForegroundColor = ConsoleColor.Cyan);
                        Console.ResetColor();
                        Console.WriteLine("  Name :  " + _users[i].Name);
                        Console.WriteLine("  Phone Number :  " + _users[i].PhoneNumber);
                        Console.WriteLine("  Email : " + _users[i].Email);
                        Console.WriteLine("  Country : " + _users[i].Country + "\r\n");
                        Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦" + "\r\n", Console.ForegroundColor = ConsoleColor.Cyan);
                        Console.ResetColor();
                    }
                }
            }
        }
    }


}
