using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{

    class ActiviyTypeService : IActiviyTypeService
    {
        private readonly IActivityTypeRepository _activityTypeRepo;

        public ActiviyTypeService(IActivityTypeRepository activityTypeRepo)
        {
            _activityTypeRepo = activityTypeRepo;
        }

        public ActivityType Add(ActivityType newActivityType)
        {
            _activityTypeRepo.Add(newActivityType);
            return newActivityType;
        }

        public ActivityType Get(int id)
        {
            return _activityTypeRepo.Get(id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _activityTypeRepo.GetAll();
        }

        public ActivityType Update(ActivityType updatedActivityType)
        {
            var type = _activityTypeRepo.Update(updatedActivityType);
            return type;
        }

        public void Remove(ActivityType activityType)
        {
            _activityTypeRepo.Remove(activityType);
        }
    }
}
