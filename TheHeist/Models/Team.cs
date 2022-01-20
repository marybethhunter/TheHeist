using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist.Models
{
    internal class Team
    {
        public List<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();
        public void AddMember(string name, int skill, decimal courage)
        {
            if (TeamMembers == null)
            {
                TeamMembers = new List<TeamMember>();
            }

            var memberToAdd = new TeamMember(name, skill, courage);
            TeamMembers.Add(memberToAdd);
        }
    }
}
