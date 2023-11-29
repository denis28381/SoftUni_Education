using System.Threading.Channels;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, User> users = new Dictionary<string, User>();

            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string userName = arguments[1];

                switch (command)
                {
                    case "register":
                        string licensePlate = arguments[2];
                        User newUser = new User(userName, licensePlate);

                        if (users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {newUser.LicensePlate}");
                        }
                        else
                        {
                            users.Add(newUser.UserName, newUser);
                            Console.WriteLine($"{newUser.UserName} registered {licensePlate} successfully");
                        }

                        break;
                    case "unregister":
                        if (users.ContainsKey(userName))
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                }
            }

            foreach (var userPair in users)
            {
                Console.WriteLine(userPair.Value);
            }
        }
    }

    internal class User
    {
        public User(string userName, string licensePlate)
        {
            LicensePlate = licensePlate;
            UserName = userName;
        }

        public string UserName { get; set; }
        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return $"{UserName} => {LicensePlate}";

        }
    }
}