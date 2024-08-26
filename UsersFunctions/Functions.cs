using System;
using Microsoft.EntityFrameworkCore;
using SystemManager.Entities;

namespace SystemManager.UsersFunctions
{
    public class Functions
    {
        public void AddUsers(DbContext dbContext)
        {
            User user = new User();
            
            Console.Write("Type the first name of user: ");
            user.FirstName = Console.ReadLine();
            Console.Write("Type the last name of user: ");
            user.LastName = Console.ReadLine();
            Console.Write("Type the email address of user: ");
            user.Email = Console.ReadLine();
            Console.Write("The user have usb adapter? (Y/N)");
            user.HaveUsbAdapter = GetBooleanInput(Console.ReadLine());
            Console.Write("The user have Ethernet adapter? (Y/N)");
            user.HaveEthernetAdapter = GetBooleanInput(Console.ReadLine());
        }


        public void EditUsers(DbContext dbContext)
        {
        }
        
        public bool GetBooleanInput(string prompt)
        {
            Console.Write(prompt + " (Y/N): ");
            string input = Console.ReadLine().Trim().ToUpper();

            while (input != "Y" && input != "N")
            {
                Console.Write("Invalid input. Please enter 'Y' or 'N': ");
                input = Console.ReadLine().Trim().ToUpper();
            }

            return input == "Y";
        }
        
        
    }
}