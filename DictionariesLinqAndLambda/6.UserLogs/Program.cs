using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userLogs = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                //[{IP=192.23.30.40} {message='Hello&derps.}' {user=destroyer}]
                string[] inputMessages = Console.ReadLine().Split();
                if (inputMessages[0] == "end")
                {
                    break;
                }
                string ipAdress = inputMessages[0].Substring(3);
                string user = inputMessages[2].Substring(5);



                if (userLogs.ContainsKey(user) == false)
                {
                    userLogs[user] = new Dictionary<string, int>();

                    if (userLogs[user].ContainsKey(ipAdress) == false)
                    {
                        userLogs[user][ipAdress] = 1;
                    }
                    else
                    {
                        userLogs[user][ipAdress] += 1;
                    }

                }
                else
                {
                    if (userLogs[user].ContainsKey(ipAdress) == false)
                    {
                        userLogs[user][ipAdress] = 1;
                    }
                    else
                    {
                        userLogs[user][ipAdress] += 1;
                    }
                }
            }
            //userLog["destroyer": ["ipAdress" : 3]]
            foreach (var userLog in userLogs.OrderBy( x => x.Key))
            {
                Console.WriteLine($"{userLog.Key}: ");
                StringBuilder str = new StringBuilder();
                //item = ["ipAdress" : 3]
                foreach (var iPAdress in userLog.Value)
                {
                    str.Append(iPAdress.Key).Append(" => ").Append(iPAdress.Value).Append(", ");
                }
                str.Remove(str.Length - 2, 2).Append(".");
                Console.WriteLine(str.ToString());
            }
        }
    }
}
