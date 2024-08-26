
using System;
using System.Linq;
using SystemManager.Data;
using SystemManager.Entities;

namespace SystemManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Staff staff = new Staff();
            // Inventory inventory = new Inventory();

            SystemDbContext context = new SystemDbContext();

            context.Users.Add(new User(
                true,
                "David",
                "Grilo",
                "d.grilo@pipastudios.com",
                true,
                true
                ));
            
            context.SaveChanges();

            context.Machines.Add( new Machine
                (
                    101,
                    new Guid("a3f6a49d-85c1-4569-aa93-3bb45c6e9351"),
                    "Macbook Pro M3",
                    16,
                    16,
                    256,
                    true
                    ));
            context.SaveChanges();


            // var users = context.Users.ToList();
            //
            // foreach (var user in users)
            // {
            //     Console.WriteLine(user.ToString());
            // }


            // List<User> users = context.Users.ToList();
            //
            // foreach (var user in users)
            //     Console.WriteLine(user.ToString());
            //
            // Console.WriteLine(Guid.NewGuid());

            //context.SaveChanges();

        }
    }
}