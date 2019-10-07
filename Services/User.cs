using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Services
{
    public class User : IUser
    {
        public string firstName { get ; set ; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string password { get; set; }
        public User()
        {

        }


    }
}
