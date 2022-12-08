using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ParkingCars.Forms.Authorization
{
    public class MD5
    {

            public string GetHash(string s)
            {
            var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
            

                return Convert.ToBase64String(hash);
            }
        
       
    }
}
