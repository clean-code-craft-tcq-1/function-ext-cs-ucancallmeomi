using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagementSystem
{
    public class FakeController : IReporter
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
        }
    }
}
