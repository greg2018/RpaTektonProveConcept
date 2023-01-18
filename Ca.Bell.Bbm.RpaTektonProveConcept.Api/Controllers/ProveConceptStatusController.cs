using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;



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

            DateTime dateNow = DateTime.Now;

            _logger.LogInformation("++++++ dateNow=" + dateNow);

            TimeZone localZone = TimeZone.CurrentTimeZone;
            //localZone.StandardName
             _logger.LogInformation("++++++001 localZone.StandardName=" + localZone.StandardName);

          

            TimeZoneInfo easternStandardTime;
            TimeZoneInfo est = TimeZoneInfo.Local;
            _logger.LogInformation("++++++ 002.StandardName=" + est.StandardName);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                easternStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                easternStandardTime = TimeZoneInfo.FindSystemTimeZoneById("America/New_York");
                est = TimeZoneInfo.FindSystemTimeZoneById("America/New_York");
            }
            else
            {
                easternStandardTime = TimeZoneInfo.FindSystemTimeZoneById("America/New_York");
                est = TimeZoneInfo.FindSystemTimeZoneById("America/New_York");
            }

            _logger.LogInformation("++++++ 003->est.StandardName=" + est.StandardName);
            // Console.WriteLine("The date and time are {0} UTC.",TimeZoneInfo.ConvertTimeToUtc(dateNow));

            DateTime convertedDateTime = TimeZoneInfo.ConvertTime(dateNow, est);
         
            _logger.LogInformation("++++++004 convertedDateTime =" + convertedDateTime);

            _logger.LogInformation("++++++ProveConceptStatusController is here!");
            return "success";
        }


     
    }
}
