using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel;

namespace DVLD_Buisness
{
    public class clsCryptography
    {
       public static string Hashing(string data)
        {
            using(SHA256 sha256=SHA256.Create())
            {

                byte[]Bytes=sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(Bytes).Replace("-","").ToLower();
            }

        }




    }
}
