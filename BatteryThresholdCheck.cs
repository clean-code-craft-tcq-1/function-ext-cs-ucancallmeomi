using System;

namespace BatteryManagementSystem
{
    public class BatteryThresholdCheck
    {
        public static void checkValueLimits(string factor, float factorCurrentValue, float maxThreshold, float minThreshold)
        {
            if (factorCurrentValue > maxThreshold)
            { 
                if(!Checker.isLanguageGerman)
                    displayBreachLevel(factor, maxThreshold, minThreshold, "High");
                else
                    displayBreachLevel(factor, maxThreshold, minThreshold, "Hoch");
            } 
            else if (factorCurrentValue < minThreshold)
                if(!Checker.isLanguageGerman)
                    displayBreachLevel(factor, maxThreshold, minThreshold, "Low");
                else
                displayBreachLevel(factor, maxThreshold, minThreshold, "Niedrig");
            else
                if (!Checker.isLanguageGerman)
                    Console.WriteLine("{0} : {1} is within the threshold limits - MaxThreshold: {2}, MinThreshold: {3}. No breach", factor, factorCurrentValue, maxThreshold, minThreshold);
                else
                    Console.WriteLine("{0} : {1} liegt innerhalb der Schwellenwerte - MaxSchwellenwert: {2}, MinSchwellenwert: {3}. Keine Verletzung", factor, factorCurrentValue, maxThreshold, minThreshold);
        }

        public static void displayBreachLevel(string factor, float maxThreshold, float minThreshold, string breachPoint)
        {
            if(!Checker.isLanguageGerman)
                Console.WriteLine("{0} breached, level {1}. Range is {2} - {3}.", factor, breachPoint, minThreshold, maxThreshold);
            else
                Console.WriteLine("{0} verletzt, niveau {1}. Reichweite is {2} - {3}.", factor, breachPoint, minThreshold, maxThreshold);
        }

    }
}
