using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Services
{
    public interface IUser
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string email { get; set; }
        int phone { get; set; }
        string password { get; set; }
    }
}
