using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Add(User newUser)
        {
            _dbContext.Add(newUser);
            _dbContext.SaveChanges();
            return newUser;        
        }

        public User Get(int id)
        {
            return _dbContext.Users
                .Include(u => u.Activities)
                .SingleOrDefault(u => u.Id == id);
                               
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users
                .Include(u => u.Activities)
                .ToList();
        }

        public void Remove(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public User Update(User updateUser)
        {
            var currentUser = _dbContext.Users.Find(updateUser.Id);

            if (currentUser == null) return null;

            _dbContext.Entry(currentUser)
                .CurrentValues
                .SetValues(updateUser);

            _dbContext.Users.Update(currentUser);
            _dbContext.SaveChanges();
            return currentUser;
        }
    }
}
