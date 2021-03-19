using System;
using System.Collections.Generic;

namespace BatteryManagementSystem
{
    public class ConsoleBreachReporter : IReporter
    {
        public void DisplayBreachLevels(List<KeyValuePair<string, string>> breachList)
        {
            Dictionary<string, string> breachValues = new Dictionary<string, string>();
            breachValues.Add("High", "Hoch");
            breachValues.Add("Low", "Niedrig");

            foreach (var level in breachList)
            {
                if (!FactorLimits.isLanguageGerman)
                    Console.WriteLine("{0} is {1}", level.Key, level.Value);
                else
                    Console.WriteLine("{0} is {1}", level.Key, breachValues[level.Value]);
            }
            CheckBatteryBreach(BatteryThresholdCheck.isBatteryBreached);
        }

        public static void CheckBatteryBreach(bool isBatteryBreached)
        {
            if(isBatteryBreached)
                Console.WriteLine("Battery has breached limits and is faulty");
            else
                Console.WriteLine("Battery is normal");
        }
    }
}
