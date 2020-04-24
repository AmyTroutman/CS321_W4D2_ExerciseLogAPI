﻿using CS321_W4D2_ExerciseLogAPI.Core.Models;
using System.Collections.Generic;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    interface IActiviyTypeService
    {
        ActivityType Add(ActivityType newActivityType);
        ActivityType Get(int id);
        IEnumerable<ActivityType> GetAll();
        void Remove(ActivityType activityType);
        ActivityType Update(ActivityType updatedActivityType);
    }
}