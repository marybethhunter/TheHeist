// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using TheHeist.Models;

var title = $@"

██████╗░██╗░░░░░░█████╗░███╗░░██╗  ██╗░░░██╗░█████╗░██╗░░░██╗██████╗░  ██╗░░██╗███████╗██╗░██████╗████████╗
██╔══██╗██║░░░░░██╔══██╗████╗░██║  ╚██╗░██╔╝██╔══██╗██║░░░██║██╔══██╗  ██║░░██║██╔════╝██║██╔════╝╚══██╔══╝
██████╔╝██║░░░░░███████║██╔██╗██║  ░╚████╔╝░██║░░██║██║░░░██║██████╔╝  ███████║█████╗░░██║╚█████╗░░░░██║░░░
██╔═══╝░██║░░░░░██╔══██║██║╚████║  ░░╚██╔╝░░██║░░██║██║░░░██║██╔══██╗  ██╔══██║██╔══╝░░██║░╚═══██╗░░░██║░░░
██║░░░░░███████╗██║░░██║██║░╚███║  ░░░██║░░░╚█████╔╝╚██████╔╝██║░░██║  ██║░░██║███████╗██║██████╔╝░░░██║░░░
╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝  ░░░╚═╝░░░░╚════╝░░╚═════╝░╚═╝░░╚═╝  ╚═╝░░╚═╝╚══════╝╚═╝╚═════╝░░░░╚═╝░░░";
Console.WriteLine(title);

var question1 = "Enter team member name:";

Console.WriteLine(question1);
var name = Console.ReadLine();

bool successful = false;
int parsedSkill = 0;
decimal parsedCourage = 0;
Team team = new Team();

while (name != "")
{
    while (!successful)
    {
        Console.WriteLine($"Enter {name}'s skill level:");
        var skill = Console.ReadLine(); //"1" but need 1
        successful = int.TryParse(skill, out parsedSkill);
    }

    successful = false;
    while (!successful)
    {
        Console.WriteLine($"Enter {name}'s courage factor:");
        var courage = Console.ReadLine();
        successful = decimal.TryParse(courage, out parsedCourage);
    }
    successful = false;

    var teamMember = new TeamMember(name, parsedSkill, parsedCourage);
    team.AddMember(teamMember.Name, teamMember.SkillLevel, teamMember.CourageFactor);

    Console.WriteLine(question1);
    name = Console.ReadLine();
}

team.TeamMembers.ForEach(teamMember => teamMember.Print());

