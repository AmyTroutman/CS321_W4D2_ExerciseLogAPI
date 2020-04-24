using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IUserRepository
    {
        //Create
        User Add(User newUser);

        //Get
        User Get(int id);

        //Update
        User Update(User updateUser);

        //Delete
        void Remove(User user);

        //List
        IEnumerable<User> GetAll();
    }
}
