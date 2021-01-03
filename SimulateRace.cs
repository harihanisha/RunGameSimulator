using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunGameTest.Models
{
    public class SimulateRace
    {
        public string gameId { get; set; }
        public string NumberOfBuckets { get; set; }
        public string NumberOfRaces { get; set; }

        //constructor 
        public SimulateRace()
        {

        }
        public SimulateRace(string gameId, string numberOfBuckets, string numberOfRaces)
        {
            this.gameId = gameId;
            this.NumberOfBuckets = numberOfBuckets;
            this.NumberOfRaces = numberOfRaces;
        }
        //instantiate
        SimulateRace mySimulateRace = new SimulateRace();
        
        //method
        public void SimuRace()
        {

        }
    }
}