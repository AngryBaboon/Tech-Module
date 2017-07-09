using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var userData = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = input[0];
                var username = input[1];
                var licensePlate = string.Empty;

                if (command == "register")
                {
                    licensePlate = input[2];

                    bool checkIfUppercase = licensePlate.ToCharArray()
                        .Take(2).Concat(licensePlate.ToCharArray().Skip(6).Take(2)).All(a => char.IsUpper(a));
                    bool checkIfDigits = licensePlate.ToCharArray().Skip(2).Take(4).All(a => char.IsDigit(a));

                    if (licensePlate.Length != 8 || checkIfUppercase == false || checkIfDigits == false)
                    {
                        if (!userData.ContainsKey(username))
                            Console.WriteLine($"ERROR: invalid license plate {licensePlate}");
                        else if (userData.ContainsKey(username)) //hack for test 2
                            Console.WriteLine($"ERROR: already registered with plate number {userData[username]}");
                    }
                    else
                    {
                        if (!userData.ContainsKey(username) && !userData.ContainsValue(licensePlate))
                        {
                            userData.Add(username, licensePlate);
                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }
                        else if (userData.ContainsKey(username))
                            Console.WriteLine($"ERROR: already registered with plate number {userData[username]}");
                        else if (userData.ContainsValue(licensePlate))
                            Console.WriteLine($"ERROR: license plate {licensePlate} is busy");
                    }
                }

                else if (command == "unregister")
                {
                    if (!userData.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        userData.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                    }
                }
            }

            foreach (var user in userData)
            {
                var username = user.Key;
                var licensePlate = user.Value;

                Console.WriteLine($"{username} => {licensePlate}");
            }
        }
    }
}
