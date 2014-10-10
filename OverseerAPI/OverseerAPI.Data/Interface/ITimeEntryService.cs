using System.Collections.Generic;
using OverseerAPI.Models.TimeEntry;
using OverseerAPI.Models.User;

namespace OverseerAPI.Data.Interface
{
    public interface ITimeEntryService
    {
        void Add(TimeEntry timeEntry);
        TimeEntry Get(int id);
        List<TimeEntry> Get();
    }
}

