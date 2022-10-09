using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Team
    {
        string Naam { get; }

        private List<Speler> _spelers = new List<Speler>();

        public List<Speler> Spelers
        {
            get { return _spelers; }
            set { _spelers = value; }
        }
    }
}
