namespace _5._Teamwork_Projects
{
    class Team
    {

        public Team(string teamName, string creatorName)
        {
            Name = teamName;
            Creator = creatorName;
            Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"{Name}\n" +
                   $"- {Creator}\n" +
                   $"{GetMembersString()}";
        }

        public string GetMembersString()
        {
            Members = Members
                .OrderBy(name => name)
                .ToList();

            string result = string.Empty;

            for (int i = 0; i < Members.Count - 1; i++)
            {
                result += $"-- {Members[i]}\n";
            }

            result += $"-- {Members[Members.Count - 1]}";

            return result;
        }

            
        
    }

    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamCommands = Console.ReadLine().Split("-");

                Team team = new Team(teamCommands[1], teamCommands[0]);

                Team sameTeamFound = teams.Find(t => t.Name == team.Name);
                Team sameCreatorFound = teams.Find(t => t.Creator == team.Creator);
                
                if (sameTeamFound != null)
                {
                    Console.WriteLine($"Team {sameTeamFound.Name} was already created!");
                    continue;
                }

                if (sameCreatorFound != null)
                {
                    Console.WriteLine($"{sameCreatorFound.Creator} cannot create another team!");
                    continue;
                }

                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");
                string joinerName = arguments[0];
                string teamName = arguments[1];

                bool hasAnyTesmWithSameName = teams.Any(t => t.Name == teamName);

                if (hasAnyTesmWithSameName == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(team => team.Creator == joinerName) ||
                    teams.Any(team => team.Members.Contains(joinerName)))
                {
                    Console.WriteLine($"Member {joinerName} cannot join team {teamName}!");
                    continue;
                }

                /*
                Team t = teams.FirstOrDefault(t => t.Name == teamName);
                if (t != null)
                {
                    t.Members.Add(joinerName);
                }*/

                teams.First(t => t.Name == teamName).Members.Add(joinerName);
            }

            List<Team> leftTeams = teams.Where(t => t.Members.Count > 0).ToList();
           

            List<Team> orderedTeams = leftTeams
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            orderedTeams.ForEach(team => Console.WriteLine(team)); 
            
            List<Team> disbandTeams = teams.Where(t => t.Members.Count <= 0).ToList();
            Console.WriteLine("Teams to disband:");
            disbandTeams = disbandTeams.OrderBy(t => t.Name).ToList();

            disbandTeams.ForEach(team => Console.WriteLine(team));
        }
    }
}