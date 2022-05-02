using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PatientLogic;
using TypeBloodLogic;
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
        private PatientManager patientManager;
        private BloodTypeService bloodTypeService;
        public PatientController(PatientManager manager, BloodTypeService service)
        {
            patientManager = manager;
            bloodTypeService = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(patientManager.getPatients());
        }

        [HttpPost]
        public IActionResult CreatePatient([FromHeader]string Name, [FromHeader]string Lastname, [FromHeader]int CI)
        {
            return Ok(patientManager.createPatient(Name, Lastname,CI));
        }
        [HttpPut]
        public IActionResult updatePAatient([FromHeader]int CI, [FromHeader]string name, [FromHeader]string lastname)
        {
            return Ok(patientManager.updatePatient(name, lastname,CI));
        }
        [HttpDelete]
        public IActionResult deletePatient([FromHeader]int CI)
        {
            return Ok(patientManager.removePatient(CI));
        }
    }
}
