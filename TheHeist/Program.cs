// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using TheHeist;
using TheHeist.Models;

var title = $@"

██████╗░██╗░░░░░░█████╗░███╗░░██╗  ██╗░░░██╗░█████╗░██╗░░░██╗██████╗░  ██╗░░██╗███████╗██╗░██████╗████████╗
██╔══██╗██║░░░░░██╔══██╗████╗░██║  ╚██╗░██╔╝██╔══██╗██║░░░██║██╔══██╗  ██║░░██║██╔════╝██║██╔════╝╚══██╔══╝
██████╔╝██║░░░░░███████║██╔██╗██║  ░╚████╔╝░██║░░██║██║░░░██║██████╔╝  ███████║█████╗░░██║╚█████╗░░░░██║░░░
██╔═══╝░██║░░░░░██╔══██║██║╚████║  ░░╚██╔╝░░██║░░██║██║░░░██║██╔══██╗  ██╔══██║██╔══╝░░██║░╚═══██╗░░░██║░░░
██║░░░░░███████╗██║░░██║██║░╚███║  ░░░██║░░░╚█████╔╝╚██████╔╝██║░░██║  ██║░░██║███████╗██║██████╔╝░░░██║░░░
╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝  ░░░╚═╝░░░░╚════╝░░╚═════╝░╚═╝░░╚═╝  ╚═╝░░╚═╝╚══════╝╚═╝╚═════╝░░░░╚═╝░░░";

Console.WriteLine(title);
var heist = new HeistSimulator();
heist.DetemineHeistDifficulty();
heist.CreateTeam();
heist.DetermineNumberOfTests();
heist.ShowResults();

//BUILD TEAM
//List<TeamMember> teamMembers = new List<TeamMember>();
//var factory = new TeamMemberFactory();
//var buildingTeam = true;

//Console.Clear();
//var teamMemberCountText = $"There {(heist.TeamMembers.Count == 1 ? "is" : "are")} {heist.TeamMembers.Count} team {(heist.TeamMembers.Count == 1 ? "member" : "members")}.";

//Console.WriteLine(teamMemberCountText);

//foreach (TeamMember member in teamMembers)
//{
//    Console.WriteLine(member.ToString());
//}
