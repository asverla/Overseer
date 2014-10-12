using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverseerAPI.Models.Team;

namespace OverseerAPI.Data.Interface
{
    public interface ITeamService
    {
        int Add(Team user);
        Team Get(string id);
        List<Team> Get();
    }
}
