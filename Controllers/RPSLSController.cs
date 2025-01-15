using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RockPaperScissorsLizardSpockAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPSLSController : ControllerBase
    {
        
        [HttpGet]
        [Route("CPURandom")]
        public string CpuRpsls()
        {
            Random cpuSelector = new Random();
            string[] gameSelection = ["rock", "paper", "scissors", "lizard", "spock"];
            return gameSelection[cpuSelector.Next(0, 5)];
        }

    }
}