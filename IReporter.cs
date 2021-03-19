using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagementSystem
{
    public interface IReporter
    {
        public void DisplayBreachLevels(List<KeyValuePair<string, string>> breachList);

    }
}
