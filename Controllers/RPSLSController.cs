using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsLizardSpockAPI.Services;

namespace RockPaperScissorsLizardSpockAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPSLSController : ControllerBase
    {
        private readonly IRPSLSService _logger;

        public RPSLSController(IRPSLSService logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        [Route("CPURandom")]
        public string CpuRpsls()
        {
            return _logger.CpuRpsls();
        }

    }
}