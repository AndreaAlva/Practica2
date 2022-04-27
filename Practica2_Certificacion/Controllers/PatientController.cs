using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2_Certificacion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> _logger;

        public PatientController(ILogger<PatientController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreatePatient([FromHeader]string Name, [FromHeader]string Lastname, [FromHeader]int CI)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult updatePAatient([FromHeader]int CI)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult deletePatient([FromHeader]int CI)
        {
            return Ok();
        }
    }
}
