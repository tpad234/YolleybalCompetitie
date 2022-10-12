using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enum;
namespace ClassLibrary
{
    class Set
    {
        private int ID { get; }
        private Wedstrijd WedstrijdID { get; }
        private int Aantalset { get; }
        private int Scoreteamthuis { get; set; }
        private int Scoreteamuit { get; set; }
        private Winaar Winaar { get; set; }


        public Set(Wedstrijd WedstrijID, int aantalset, int Scoreteamthuis, int Scoreteamuit, Winaar Winaar)
        {

            this.WedstrijdID = WedstrijID;
            this.Aantalset = aantalset;
            this.Scoreteamthuis = Scoreteamthuis;
            this.Scoreteamuit = Scoreteamuit;
            this.Winaar = Winaar;


        }
    }


}
