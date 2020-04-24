using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System.Collections.Generic;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityService
    {
        Activity Add(Activity newActivity);
        Activity Get(int id);
        IEnumerable<Activity> GetAll();
        Activity Update(Activity updateActivity);
    }
}