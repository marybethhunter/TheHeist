// See https://aka.ms/new-console-template for more information
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


var teamMember = new TeamMember(name, parsedSkill, parsedCourage);
teamMember.Print();
