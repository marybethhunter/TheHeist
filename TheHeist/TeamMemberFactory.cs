using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheHeist.Models;

namespace TheHeist
{
    internal class TeamMemberFactory
    {
        public TeamMember BuildNewTeamMember()
        {
            var question1 = "Enter team member name (leave blank to end):";
            Console.WriteLine(question1);
            var name = Console.ReadLine();

            if (name == "")
            {
                return new TeamMember("", 0, 0);
            }

            bool successful = false;
            int parsedSkill = 0;
            decimal parsedCourage = 0;

            while (!successful)
            {
                Console.WriteLine($"Enter {name}'s skill level:");
                var skill = Console.ReadLine(); //"1"  1
                successful = int.TryParse(skill, out parsedSkill);

            }

            successful = false;
            while (!successful)
            {
                Console.WriteLine($"Enter {name}'s courage factor:");
                var courage = Console.ReadLine();
                successful = decimal.TryParse(courage, out parsedCourage);

            }

            var teamMember = new TeamMember(name, parsedSkill, parsedCourage);

            var retVal = new TeamMember(name, parsedSkill, parsedCourage);
            return retVal;
        }
    }
}
