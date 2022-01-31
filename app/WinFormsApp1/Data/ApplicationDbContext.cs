using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Data
{
    public static class ApplicationDbContext
    {
        public static List<User> Users { get; set; }

         static ApplicationDbContext()
        {
            Users = new List<User>()
            {
                new User("Babek","Agamuradov","hrageneva@gmail.com","babek123")
            };
        }
    }
}
