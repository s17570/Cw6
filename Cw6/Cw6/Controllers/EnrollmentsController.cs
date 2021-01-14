using Cw6.DTOs.Requests;
using Cw6.DTOs.Responses;
using Cw6.Models;
using Cw6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw6.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private IStudentsDbService _service;

        public EnrollmentsController(IStudentsDbService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult EnrollStudent(EnrollStudentRequest request)
        {
            try
            {
                var enr = _service.EnrollStudent(request);

                return Ok(enr);

            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
    }
}
