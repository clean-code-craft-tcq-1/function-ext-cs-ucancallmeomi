using System;
using System.Linq;

namespace BatteryManagementSystem
{
    class TemparatureCalculator
    {
        public static float convertFahrenheitToCelsius(float temparatureinFahrenheit)
        {
            float temparatureinCelsius;

            return temparatureinCelsius = (temparatureinFahrenheit - 32) * 5 / 9;

        }

        public static float TemparatureValue(string temparature)
        {
            float ActualTemparatureValue;

            string temparatureValue = new string(temparature.Where(x => Char.IsDigit(x)).ToArray());
            ActualTemparatureValue = float.Parse(temparatureValue);
            if (temparature.Contains("F"))
                ActualTemparatureValue = TemparatureCalculator.convertFahrenheitToCelsius(ActualTemparatureValue);

            return ActualTemparatureValue;
        }
    }
}
