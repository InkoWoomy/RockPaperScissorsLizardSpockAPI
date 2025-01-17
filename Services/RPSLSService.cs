using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpockAPI.Services
{
    public class RPSLSService : IRPSLSService
    {
        public string CpuRpsls()
        {
            Random cpuSelector = new Random();
            string[] gameSelection = ["rock", "paper", "scissors", "lizard", "spock"];
            return gameSelection[cpuSelector.Next(0, 5)];
        }

    }
}