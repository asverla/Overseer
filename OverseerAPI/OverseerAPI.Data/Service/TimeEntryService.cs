using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverseerAPI.Data.Interface;
using OverseerAPI.Data.Repository;
using OverseerAPI.Models.TimeEntry;
using OverseerAPI.Models.User;

namespace OverseerAPI.Data.Service
{
    public class TimeEntryService : ITimeEntryService
    {
        private IRepository _repository;

        public TimeEntryService()
            : this(new OverseerRepository())
        {
            // Empty!
        }

        public TimeEntryService(IRepository repository)
        {
            this._repository = repository;
        }
        public void Add(TimeEntry timeEntry)
        {
            this._repository.Add(timeEntry);
            this._repository.Save();
        }

        public TimeEntry Get(int id)
        {
            return this._repository.Query<TimeEntry>().SingleOrDefault(o => o.TimeEntryId == id);
        }

        public List<TimeEntry> Get()
        {
            return this._repository.Query<TimeEntry>().ToList();
        }
    }
}
