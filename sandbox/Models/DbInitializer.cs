using BikePath.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sandbox.Models
{
    public class DbInitializer
    {
        public static void Initialize(SandboxContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            User user = new User { Name = "Ivan", Email = "ivan.tarasov12345@gmail.com", Password = "12345" };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
