using System.Collections.Generic;
using OverseerAPI.Models.User;

namespace OverseerAPI.Data.Interface
{
    public interface IUserService
    {
        string Add(User user);
        User Get(string id);
        List<User> Get();
    }
}

