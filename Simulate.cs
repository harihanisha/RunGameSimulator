using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunGameTest.Models
{
    public class Simulate
    {
        //properties
        public string gameId { get; set; }
        public string spins { get; set; }
        public string procs { get; set; }

        //constructor
        public Simulate()
        {

        }
        public Simulate(string gameId, string Spins, string Procs)
        {
            this.gameId = gameId;
            this.spins = Spins;
            this.procs = Procs;
        }
        //instantiate 
        Simulate mySimulate = new Simulate();

        //method
        public void Simu1()
        {

        }
    }
}