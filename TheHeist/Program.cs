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

//BUILD TEAM
List<TeamMember> teamMembers = new List<TeamMember>();
var factory = new TeamMemberFactory();
var buildingTeam = true;
var bankDifficulty = 100;
var successfulInput = false;

Console.WriteLine(title);

while (!successfulInput)
{
    Console.WriteLine("Enter the difficulty of your bank heist:");
    var difficulty = Console.ReadLine();
    successfulInput = int.TryParse(difficulty, out bankDifficulty);
}
successfulInput = false;


while (buildingTeam)
{
    var newTeamMember = factory.BuildNewTeamMember();

    if (newTeamMember.Name != "")
    {
        teamMembers.Add(newTeamMember);
    }
    else
    {
        buildingTeam = false;
    }

}

Console.Clear();
var teamMemberCountText = $"There {(teamMembers.Count == 1 ? "is" : "are")} {teamMembers.Count} team {(teamMembers.Count == 1 ? "member" : "members")}.";

//Console.WriteLine(teamMemberCountText);

//foreach (TeamMember member in teamMembers)
//{
//    Console.WriteLine(member.ToString());
//}

//DETERMINE NUMBER OF HEISTS
var parsedNumberOfHeists = 0;
while (!successfulInput)
{
    Console.WriteLine("How many heist simulations do you want to run?");
    var numberOfHeists = Console.ReadLine();
    successfulInput = int.TryParse(numberOfHeists, out parsedNumberOfHeists);

}

//DISPLAY RESULTS FOR EACH HEIST
var successCount = 0;
var failureCount = 0;

for (int i = 0; i < parsedNumberOfHeists; i++)
{
    var luck = new Random().Next(-10, 10);
    var sum = 0;
    foreach (var member in teamMembers)
    {
        sum += member.SkillLevel;
    }

    var modifiedDifficulty = bankDifficulty + luck;
    var heistResult = sum >= modifiedDifficulty;
    //Console.WriteLine($"Your team  skill level is {sum} and the difficulty is {modifiedDifficulty}.");
    //Console.WriteLine($"The heist was a {(heistResult ? "successful" : "failure")}!");

    if (heistResult)
    {
        successCount += 1;
    }
    else
    {
        failureCount += 1;
    }
}

Console.WriteLine($"There were {successCount} successful heists and {failureCount} failures. ");