using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ca.Bell.Bbm.RpaTektonProveConcept.Api.Controllers
{
    [Route("api/proveconcept")]
    [ApiController]
    public class ProveConceptStatusController : ControllerBase
    {
        
        [HttpGet("status")]
        public string GetStatus()
        {
            return "success";
        }


     
    }
}
