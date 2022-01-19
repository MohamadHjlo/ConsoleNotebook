using System;

namespace ProjeDaneshjoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallTasks();
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
                    Tasks.AddUser();
                }

                if (option == 2)
                {
                    Tasks.DeleteUser();
                }

                if (option == 3)
                {
                    Tasks.UpdateUser();
                }

                if (option == 4)
                {
                    Tasks.SearchByName();
                }

                if (option == 5)
                {
                    Tasks.SearchByPhoneNumber();
                }
                if (option == 6)
                {
                    Tasks.GetAllRecords();
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
    }


}
