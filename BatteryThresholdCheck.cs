using System;

namespace BatteryManagementSystem
{
    public class BatteryThresholdCheck
    {
        public static string checkValueLimits(string factor, float factorCurrentValue, float maxThreshold, float minThreshold)
        {
            string displayMessage = "";
            if (factorCurrentValue > maxThreshold)
            {
                displayMessage = Checker.isLanguageGerman ? displayBreachLevel(factor, maxThreshold, minThreshold, "Hoch") : displayBreachLevel(factor, maxThreshold, minThreshold, "High");
                    
            }
            else if (factorCurrentValue < minThreshold)
                displayMessage = Checker.isLanguageGerman ? displayBreachLevel(factor, maxThreshold, minThreshold, "Niedrig") : displayBreachLevel(factor, maxThreshold, minThreshold, "Low");
            else
                displayMessage = Checker.isLanguageGerman ? "Batterie hat keine Verletzung, alles ist normal" : "Battery has no breaches, everything is normal";

            return displayMessage;
        }
        public static string displayBreachLevel(string factor, float maxThreshold, float minThreshold, string breachPoint)
        {
            string outputMessage = "";

            if (!Checker.isLanguageGerman)
            {
                outputMessage = string.Format("{0} breached, level {1}. Range is {2} - {3}.", factor, breachPoint, minThreshold, maxThreshold);
            }
            else
            {
                outputMessage = string.Format("{0} verletzt, niveau {1}. Reichweite is {2} - {3}.", factor, breachPoint, minThreshold, maxThreshold);
            }
            return outputMessage;
        }
    }
}
