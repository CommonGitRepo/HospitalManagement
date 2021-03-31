using Hospital.Management.System.Model;
using Hospital.Management.System.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> _logger;
        private readonly IPatientService _service;
        public PatientController(ILogger<PatientController> logger, IPatientService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet,Route("GetActivePatient")]
        public IActionResult GetActivePatient()
        {
            try
            {
                return Ok(_service.Get().Where(x=>!x.IsDischarged));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet,Route("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPost,Route("create")]
        public IActionResult Post([FromBody]Patient patient)
        {
            try
            {
                patient.Id = Guid.NewGuid().ToString();
                return Ok(_service.Create(patient));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPut,Route("{id}")]
        public IActionResult Put(string id,[FromBody] Patient patient)
        {
            try
            {
                _service.Update(id, patient);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
