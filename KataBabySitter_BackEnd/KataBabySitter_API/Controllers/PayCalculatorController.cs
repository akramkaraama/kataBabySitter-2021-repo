using KataBabySitter_BLL;
using KataBabySitter_BOL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KataBabySitter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayCalculatorController : ControllerBase
    {
        private readonly ILogger<PayCalculatorController> _logger;

        public PayCalculatorController(ILogger<PayCalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string message = "Welcome to Kata Baby-Sitter Daily Pay Calculator BackEnd!";
            return Ok(message);
        }

        [HttpPost]
        public double Post(WorkTime workTime)
        {
            PayCalculator payCalculator = new PayCalculator();
            double pay = payCalculator.GetEmployeePay(workTime);

            return pay;
        }
    }
}
