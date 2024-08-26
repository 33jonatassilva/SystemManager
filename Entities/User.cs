using System;
using System.ComponentModel.DataAnnotations;

namespace SystemManager.Entities
{

    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool HaveUsbAdapter { get; set; }
        public bool HaveEthernetAdapter { get; set; }
        public DateTime OnboardDate { get; set; } = DateTime.Now;

        public User()
        {
        }

        public User(bool isActive, string firstName, string lastName, string email, bool haveUsbAdapter, bool haveEthernetAdapter)
        {
            IsActive = isActive;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            HaveUsbAdapter = haveUsbAdapter;
            HaveEthernetAdapter = haveEthernetAdapter;
        }
        
        
        public override string ToString()
        {
            return $"User Details:\n" +
                   $"- Id: {Id}\n" +
                   $"- Active: {IsActive}\n" +
                   $"- Name: {FirstName} {LastName}\n" +
                   $"- Email: {Email}\n" +
                   $"- USB Adapter: {(HaveUsbAdapter ? "Yes" : "No")}\n" +
                   $"- Ethernet Adapter: {(HaveEthernetAdapter ? "Yes" : "No")}\n" +
                   $"- Onboard Date: {OnboardDate.ToString("yyyy-MM-dd HH:mm:ss")}";
        }
    }

    
}