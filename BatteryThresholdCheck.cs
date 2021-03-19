using System;
using System.Collections.Generic;

namespace BatteryManagementSystem
{
    public class BatteryThresholdCheck
    {
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

        public void Display()
        {
            _reportBreaches.DisplayBreachLevels(breachList);
        }

        public void isBatteryOk(string temparature, float soc, float chargeRate)
        {
            float temparaturValue = TemparatureCalculator.TemparatureValue(temparature);
            checkTemparatureRange(temparaturValue);
            checkSOCRange(soc);
            checkChargeRate(chargeRate);
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
