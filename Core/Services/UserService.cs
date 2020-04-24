using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User Add(User newUser)
        {
            _userRepo.Add(newUser);
            return newUser;
        }

        public User Get(int id)
        {
            return _userRepo.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepo.GetAll();
        }

        public User Update(User updatedUser)
        {
            var user = _userRepo.Update(updatedUser);
            return user;
        }

        public void Remove(User user)
        {
            _userRepo.Remove(user);
        }
    }
}
