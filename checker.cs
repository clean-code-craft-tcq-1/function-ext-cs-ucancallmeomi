using System;

namespace BatteryManagementSystem
{
    public class Checker
    {
        
        static int Main()
        {
            FactorLimits.isLanguageGerman = true;
            IReporter _reportConsoleLogger = new ConsoleBreachReporter();
            BatteryThresholdCheck batteryThresholdCheck = new BatteryThresholdCheck(_reportConsoleLogger);

            IReporter _reportFakeLogger = new FakeController();
            BatteryThresholdCheck batteryThresholdCheck1 = new BatteryThresholdCheck(_reportFakeLogger);


            batteryThresholdCheck.isBatteryOk("25C", 70, 0.7f);
            batteryThresholdCheck.isBatteryOk("122F", 85, 0.0f);
            batteryThresholdCheck.isBatteryOk("-50C", 65, 0.2f);
            batteryThresholdCheck.isBatteryOk("104F", 50, 0.5f);
            Console.WriteLine("All ok");
            return 0;
        }
    }
}