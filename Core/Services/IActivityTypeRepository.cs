using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityTypeRepository
    {
        //Create
        ActivityType Add(ActivityType newActivityType);
        
        //Get
        ActivityType Get(int id);

        //Update
        ActivityType Update(ActivityType updateActivityType);

        //Delete
        void Remove(ActivityType activityType);

        //List
        IEnumerable<ActivityType> GetAll();
    }
}
