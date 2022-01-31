using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Helper
{
    public static class Session
    {
        public static LoginForm MainForm { get; set; } 
        public static User User { get; set; }
    }
}
