using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunGameTest.Models
{
    public class GenarateRace
    {
        //properties
        public string gameId { get; set; }

        //constructor 
        public GenarateRace()
        {

        }
        public GenarateRace(string gameId)
        {
            this.gameId = gameId;

        }
        //instantiate 
        GenarateRace myGenarateRace = new GenarateRace();
       
        //method
        public void GenaRace()
        {

        }
    }
}