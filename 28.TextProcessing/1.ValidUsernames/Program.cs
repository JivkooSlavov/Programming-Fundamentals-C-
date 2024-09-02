using System.Runtime.InteropServices;

namespace _1.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ");
            foreach (string user in users)
            {
                if (user.Length>= 3 && user.Length<=16)
                {
                    if (isValidUsername(user))
                    {
                        Console.WriteLine(user);
                    }
                }
            }

        }
        private static bool isValidUsername(string user)
        {

            return user.All(x => char.IsLetterOrDigit(x) || x == '-' || x== '_');
        }
    }
}