using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System.Collections.Generic;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    interface IUserService
    {
        User Add(User newUser);
        User Get(int id);
        IEnumerable<User> GetAll();
        void Remove(User user);
        User Update(User updatedUser);
    }
}