namespace _5._Teamwork_Projects
{
    class Team
    {

        public Team(string teamName, string creatorName)
        {
            Name = teamName;
            Creator = creatorName;
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
                    Console.WriteLine($"Team {team.Name}");
                }
            }
        }
    }
}