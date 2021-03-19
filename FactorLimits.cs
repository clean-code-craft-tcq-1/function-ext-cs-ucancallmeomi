using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagementSystem
{
    public class FactorLimits
    {
        public static bool isLanguageGerman = false;

        public static float temparatureMaxLimit = 45;
        public static float temparatureMinLimit = 0;
        public static float socMaxLimit = 20;
        public static float socMinLimit = 80;
        public static float chargeRateMaxLimit = 0.8f;
        public static float chargeRateMinLimit = 0.3f;


    }
}
