using CarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarApp.Controllers
{
    public static class UserRepository
    {
        public static IEnumerable<User> GetUsers()
        {
            var assets = new List<User>()
                {
                    new User{BadgeNumber = 1, FirstName = "John", LastName = "Doe", Email = "jd@test.com", IsActive = true, IsAdmin = true, CanSendReminder = true},
                    new User{BadgeNumber = 2, FirstName = "Dave", LastName = "Brown", Email = "db@test.com", IsActive = true, IsAdmin = false, CanSendReminder = true},
                    new User{BadgeNumber = 3, FirstName = "Richard", LastName = "Joe", Email = "rj@test.com", IsActive = true, IsAdmin = false, CanSendReminder = false},
                    new User{BadgeNumber = 4, FirstName = "John", LastName = "Smith", Email = "js@test.com" , IsActive = true, IsAdmin = true, CanSendReminder = false}
                };

            return assets;
        }
        public static void MapUser(User original, User changed)
        {
            original.FirstName = changed.FirstName;
            original.LastName = changed.LastName;
            original.Email = changed.Email;
            original.IsAdmin = changed.IsAdmin;
            original.CanSendReminder = changed.CanSendReminder;
            original.IsActive = changed.IsActive;
            changed.LastUpdatedTime = DateTime.Now;
        }
    }
}