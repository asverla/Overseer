using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OverseerAPI.Data.Interface;
using OverseerAPI.Data.Repository;
using OverseerAPI.Models.User;

namespace OverseerAPI.Data.Service
{
    public class UserService : IUserService
    {
        private IRepository _repository;

        public UserService()
            : this(new OverseerRepository())
        {
            // Empty!
        }

        public UserService(IRepository repository)
        {
            this._repository = repository;
        }
        public string Add(User user)
        {
            this._repository.Add(user);
            this._repository.Save();

            return user.AspNetUserId;
        }

        public User Get(string username)
        {
            var user = this._repository.Query<User>().SingleOrDefault(o => o.Username == username);

            return user;
        }

        public List<User> Get()
        {
            return this._repository.Query<User>().ToList();
        }
    }
}
