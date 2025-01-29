using System;

namespace DriveSmartAPI.Models
{
    public class VehicleEfficiency
    {
        public int Id { get; set; }
        public double Efficiency { get; set; }
        public DateTime DateTime { get; set; }
        public string VehicleId { get; set; }
    }
}
