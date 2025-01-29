using System;

namespace DriveSmartAPI.Services
{
    public class EfficiencyCalculator
    {
        public double CalculateEfficiency(double distance, double fuelUsed)
        {
            if (fuelUsed == 0) return 0;
            return distance / fuelUsed; 
        }

        public double AdjustForTimeZone(double efficiency, TimeZoneInfo timeZone)
        {
            return efficiency; 
        }
    }
}
