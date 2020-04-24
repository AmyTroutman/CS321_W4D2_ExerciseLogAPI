using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _dbContext;
        public ActivityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Activity Add(Activity newActivity)
        {
            _dbContext.Add(newActivity);
            _dbContext.SaveChanges();
            return newActivity;
        }

        public Activity Get(int id)
        {
            return _dbContext.Activities
                .Include(a => a.ActivityType)
                .Include(a => a.User)
                .SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _dbContext.Activities
                .Include(a => a.ActivityType)
                .Include(a => a.User)
                .ToList();
        }

        public void Remove(Activity activity)
        {
            _dbContext.Activities.Remove(activity);
            _dbContext.SaveChanges();
        }

        public Activity Update(Activity updatedActivity)
        {
            var currentActivity = _dbContext.Activities.Find(updatedActivity.Id);

            if (currentActivity == null) return null;

            _dbContext.Entry(currentActivity)
                .CurrentValues
                .SetValues(updatedActivity);

            _dbContext.Activities.Update(currentActivity);
            _dbContext.SaveChanges();
            return currentActivity;
        }
    }
}
