// using System.Collections.Generic;
// using System.Linq;
// using System;
//
//
// namespace SystemManager.Entities
// {
//     class Inventory
//     {
//         List<Machine> machines = new List<Machine>();
//
//
//         public void AddMachine(Machine machine)
//         {
//             machines.Add(machine);
//             Console.WriteLine("Machine Added");
//         }
//
//
//         public List<Machine> FilterByTAG()
//         {
//             return machines
//             .OrderBy(x => x.TAG)
//             .ToList();
//         }
//
//
//         public List<Machine> FilterByUserName()
//         {
//             return machines
//             .OrderBy(x => x.User.FirstName)
//             .ToList();
//         }
//
//
//         public List<Machine> FindAll(string name)
//         {
//             return machines
//             .Where(x => x.User.FirstName == name)
//             .ToList();
//         }
//
//
//
//     }
// }