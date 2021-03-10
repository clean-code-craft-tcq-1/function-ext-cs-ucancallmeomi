using System;
using System.Collections.Generic;

namespace BatteryManagementSystem
{
    public class BatteryThresholdCheck
    {

        public static void checkValueLimits(string factor, float factorCurrentValue, float maxThreshold, float minThreshold)
        {
            if (factorCurrentValue > maxThreshold)
                displayBreachLevel(factor, maxThreshold, minThreshold, "High");
            else if (factorCurrentValue < minThreshold)
                displayBreachLevel(factor, maxThreshold, minThreshold, "Low");
        }

        public static void displayBreachLevel(string factor, float maxThreshold, float minThreshold, string breachPoint)
        {
            Dictionary<string, string> breachValues = new Dictionary<string, string>();
            breachValues.Add("High", "Hoch");
            breachValues.Add("Low", "Niedrig");

            if (!Checker.isLanguageGerman)
                Console.WriteLine("{0} breached, level {1}. Range is {2} - {3}.", factor, breachPoint, minThreshold, maxThreshold);
            else
                Console.WriteLine("{0} verletzt, Niveau {1}. Reichweite is {2} - {3}.", factor, breachValues[breachPoint], minThreshold, maxThreshold);
        }

    }
}
