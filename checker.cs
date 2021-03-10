using System;
using System.Diagnostics;
using System.Linq;

namespace BatteryManagementSystem
{
    public class Checker
    {
        public static bool isLanguageGerman = false;

        public static float temparatureMaxLimit = 45;
        public static float temparatureMinLimit = 0;
        public static float socMaxLimit = 20;
        public static float socMinLimit = 80;
        public static float chargeRateMaxLimit = 0.8f;
        public static float chargeRateMinLimit = 0.3f;

        public static void isBatteryOk(string temparature, float soc, float chargeRate)
        {
            string temparatureValue = new string(temparature.Where(x => Char.IsDigit(x)).ToArray());
            float temparaturValue = float.Parse(temparatureValue);
            if (temparature.Contains("F"))
             temparaturValue = convertFahrenheitToCelsius(temparaturValue);

            checkTemparatureRange(temparaturValue);
            checkSOCRange(soc);
            checkChargeRate(chargeRate);
        }

        public static void checkTemparatureRange(float temparature)
        {
            BatteryThresholdCheck.checkValueLimits("Temparature", temparature, temparatureMaxLimit, temparatureMinLimit);
        }

        public static void checkSOCRange(float soc)
        {
            BatteryThresholdCheck.checkValueLimits("SOC", soc, socMaxLimit, socMinLimit);
        }

        public static void checkChargeRate(float ChargeRate)
        {
            BatteryThresholdCheck.checkValueLimits("ChargeRate", ChargeRate, chargeRateMaxLimit, chargeRateMinLimit);
        }


        public static float convertFahrenheitToCelsius(float temparatureinFahrenheit)
        {
            float temparatureinCelsius;

            return temparatureinCelsius = (temparatureinFahrenheit - 32) * 5 / 9;

        }

        static int Main()
        {
            isLanguageGerman = true;

            isBatteryOk("25C", 70, 0.7f);
            isBatteryOk("122F", 85, 0.0f);
            isBatteryOk("-50C", 65, 0.2f);
            isBatteryOk("104F", 50, 0.5f);
            Console.WriteLine("All ok");
            return 0;
        }
    }
}