using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySharedLibrary; // Here ,Through this it  import the shared library

namespace MainApp
{
    public static class UserManagementModule
    {
        public static void AddUser(string username)
        {
            //It can add user to the system
            if (UtilityMethods.ValidateData(username))
            {
                Console.WriteLine($"User {username} added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid username.");
            }
        }

        public static void DeleteUser(string username)
        {
            // It can delete user from the system
            if (UtilityMethods.ValidateData(username))
            {
                Console.WriteLine($"User {username} deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid username.");
            }
        }
    }
}