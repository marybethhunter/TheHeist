using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist.Models
{
    internal class TeamMember
    {
        public TeamMember(string name, int skill, decimal courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
        }

        public TeamMember(string member, string name, int skill, decimal courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
        }

        public TeamMember()
        {

        }

        //A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public void Print()
        {
            Console.WriteLine($@"
Name: {Name}
Skill Level: {SkillLevel}
Courage: {CourageFactor}
");
        }
    }
}
