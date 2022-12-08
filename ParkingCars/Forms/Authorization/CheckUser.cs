using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCars.Forms.Authorization
{
    public class CheckUser
    {
        public string Login { get; set; }

        public bool isAdmin { get; }

        public string Status => isAdmin ? "Администратор" : "Охранник";


        public CheckUser(string login , bool IsAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
