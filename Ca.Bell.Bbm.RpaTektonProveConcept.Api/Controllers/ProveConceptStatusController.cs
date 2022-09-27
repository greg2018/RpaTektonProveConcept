using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        private readonly ILogger<ProveConceptStatusController> _logger;

        public ProveConceptStatusController(ILogger<ProveConceptStatusController> logger )
        {
            _logger = logger;
        }

            [HttpGet("status")]
        public string GetStatus()
        {
            _logger.LogInformation("++++++ProveConceptStatusController is here!");
            return "success";
        }


     
    }
}
