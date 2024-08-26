// using System.Collections.Generic;
// using System;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
//
//
// namespace SystemManager.Entities
// {
//     
//     public class Staff
//     {
//         List<User> users = new List<User>();
//
//         public void AddUser(User user)
//         {
//             users.Add(user);
//             Console.WriteLine("User added!");
//         }
//
//         public void RemoveUser(User user)
//         {
//             users.Remove(user);
//             Console.WriteLine("User Removed!");
//         }
//
//         public List<User> GetUsersByName(string name) 
//             => users.FindAll(x => x.FirstName == name);
//         
//         public List<User> GetUsersByEmail(string email)
//             => users.FindAll(x => x.Email == email);
//
//         public List<User> GetActiveUsers()
//             => users.FindAll(x => x.IsActive);
//         
//         public List<User> GetUsersByOnboardingDate(DateTime date)
//             => users.FindAll(x => x.OnboardDate == date);
//         
//
//         public List<User> GetUsersByOnboardingDate(int setter = 1)
//         {
//             if (setter == -1)
//                 return users.OrderByDescending(x => x.OnboardDate).ToList();
//             return users.OrderBy(x => x.OnboardDate).ToList();
//         }
//
//     }
// }