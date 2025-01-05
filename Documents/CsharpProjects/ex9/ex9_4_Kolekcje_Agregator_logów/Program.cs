using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    public static void Main() {
        LogsAgregator();
    }

    public static void LogsAgregator() {
        int numberOfLogs = int.Parse(Console.ReadLine());
        int counter = 0;
        Dictionary<string, HashSet<string>> logResult = new Dictionary<string, HashSet<string>>();
        Dictionary<string, int> userDurations = new Dictionary<string, int>();

        while (counter < numberOfLogs) {
            string log = Console.ReadLine();
            string[] logArray = log.Split(" ");
            string user = logArray[1];
            string ip = logArray[0];
            int duration = int.Parse(logArray[2]);

            if (!logResult.ContainsKey(user)) {
                logResult[user] = new HashSet<string>();
                userDurations[user] = 0;
            }

            logResult[user].Add(ip);
            userDurations[user] += duration;
            counter++;
        }

        foreach (var item in logResult.OrderBy(user => user.Key)) {
            var sortedIps = item.Value.OrderBy(ip => ip).ToList();
            Console.WriteLine($"{item.Key}: {userDurations[item.Key]} [{string.Join(", ", sortedIps)}]");
        }
    }
}