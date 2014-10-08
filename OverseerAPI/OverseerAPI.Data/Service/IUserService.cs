using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverseerAPI.Data.Service
{
    public interface IUserService
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}

