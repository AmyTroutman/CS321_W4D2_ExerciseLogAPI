using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class ActivityTypeRepository : IActivityTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActivityType Add(ActivityType newActivityType)
        {
            _dbContext.Add(newActivityType);
            _dbContext.SaveChanges();
            return newActivityType;
        }

        public ActivityType Get(int id)
        {
            return _dbContext.ActivityTypes.SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _dbContext.ActivityTypes.ToList();
        }

        public ActivityType Update(ActivityType updateActivityType)
        {
            var currentActivityType = _dbContext.ActivityTypes.Find(updateActivityType.Id);

            if (currentActivityType == null) return null;

            _dbContext.Entry(currentActivityType)
                .CurrentValues
                .SetValues(updateActivityType);

            _dbContext.ActivityTypes.Update(currentActivityType);
            _dbContext.SaveChanges();
            return currentActivityType;
        }

        public void Remove(ActivityType activityType)
        {
            _dbContext.ActivityTypes.Remove(activityType);
            _dbContext.SaveChanges();
        }
    }
}
