using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverseerAPI.Data.Interface;
using OverseerAPI.Data.Repository;
using OverseerAPI.Models.Team;

namespace OverseerAPI.Data.Service
{
    public class TeamService : ITeamService
    {
        private IRepository _repository;

        public TeamService()
            : this(new OverseerRepository())
        {
            // Empty!
        }
        public TeamService(IRepository repository)
        {
            this._repository = repository;
        }

        public int Add(Team team)
        {
            this._repository.Add(team);
            this._repository.Save();

            return team.TeamId;
        }

        public Team Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Team> Get()
        {
            return _repository.Query<Team>().ToList();
        }
    }
}
