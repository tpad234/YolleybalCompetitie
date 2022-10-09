using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Competitie
    {
        string Naam { get; }

        private List<Team> _teams = new List<Team>();

        public List<Team> Teams
        {
            get { return _teams; }
            set { _teams = value; }
        }

        private List<Wedstrijd> _wedstrijden = new List<Wedstrijd>();

        public List<Wedstrijd> Wedstrijden
        {
            get { return _wedstrijden; }
            set { _wedstrijden = value; }
        }
    }
}
