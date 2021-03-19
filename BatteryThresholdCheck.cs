<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> 97a441f828c60a25831f258feb614ec4c5bd76ca
using System.Collections.Generic;

namespace BatteryManagementSystem
{
    public class BatteryThresholdCheck
    {
<<<<<<< HEAD
        public static List<KeyValuePair<string, string>> breachList = new List<KeyValuePair<string, string>>();
        public static bool isBatteryBreached = false;

        IReporter _reportBreaches;

        public BatteryThresholdCheck(IReporter _report)
        {
            if (_report == null)
            {
                throw new InvalidProgramException("Invalid Program Execption");
            }
            _reportBreaches = _report;
        }

        public static List<KeyValuePair<string, string>> checkValueLimits(string factor, float factorCurrentValue, float maxThreshold, float minThreshold)
        {
            if (factorCurrentValue > maxThreshold)
            {
                breachList.Add(new KeyValuePair<string, string>(factor, "High"));
                isBatteryBreached = true;
            }
            else if (factorCurrentValue < minThreshold)
            {
                breachList.Add(new KeyValuePair<string, string>(factor, "Low"));
                isBatteryBreached = true;
            }

            return breachList;
        }

        public void Display(List<KeyValuePair<string, string>> breachList)
        {
            _reportBreaches.DisplayBreachLevels(breachList);
=======

        public static void checkValueLimits(string factor, float factorCurrentValue, float maxThreshold, float minThreshold)
        {
            if (factorCurrentValue > maxThreshold)
                displayBreachLevel(factor, maxThreshold, minThreshold, "High");
            else if (factorCurrentValue < minThreshold)
                displayBreachLevel(factor, maxThreshold, minThreshold, "Low");
>>>>>>> 97a441f828c60a25831f258feb614ec4c5bd76ca
        }

        public void isBatteryOk(string temparature, float soc, float chargeRate)
        {
<<<<<<< HEAD
            float temparaturValue = TemparatureCalculator.TemparatureValue(temparature);
            checkTemparatureRange(temparaturValue);
            checkSOCRange(soc);
            checkChargeRate(chargeRate);
=======
            Dictionary<string, string> breachValues = new Dictionary<string, string>();
            breachValues.Add("High", "Hoch");
            breachValues.Add("Low", "Niedrig");

            if (!Checker.isLanguageGerman)
                Console.WriteLine("{0} breached, level {1}. Range is {2} - {3}.", factor, breachPoint, minThreshold, maxThreshold);
            else
                Console.WriteLine("{0} verletzt, Niveau {1}. Reichweite is {2} - {3}.", factor, breachValues[breachPoint], minThreshold, maxThreshold);
>>>>>>> 97a441f828c60a25831f258feb614ec4c5bd76ca
        }

        public static void checkTemparatureRange(float temparature)
        {
            BatteryThresholdCheck.checkValueLimits("Temparature", temparature, FactorLimits.temparatureMaxLimit, FactorLimits.temparatureMinLimit);
        }

        public static void checkSOCRange(float soc)
        {
            BatteryThresholdCheck.checkValueLimits("SOC", soc, FactorLimits.socMaxLimit, FactorLimits.socMinLimit);
        }

        public static void checkChargeRate(float ChargeRate)
        {
            BatteryThresholdCheck.checkValueLimits("ChargeRate", ChargeRate, FactorLimits.chargeRateMaxLimit, FactorLimits.chargeRateMinLimit);
        }
    }
}
