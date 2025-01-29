using DriveSmartAPI.Models;
using DriveSmartAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DriveSmartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleEfficiencyController : ControllerBase
    {
        private readonly EfficiencyCalculator _efficiencyCalculator;

        public VehicleEfficiencyController(EfficiencyCalculator efficiencyCalculator)
        {
            _efficiencyCalculator = efficiencyCalculator;
        }

        [HttpPost]
        public IActionResult PostEfficiency([FromBody] VehicleEfficiency vehicleEfficiency)
        {
            var efficiency = _efficiencyCalculator.CalculateEfficiency(vehicleEfficiency.Distance, vehicleEfficiency.FuelUsed);
            return Ok(new { Efficiency = efficiency });
        }
    }
}
