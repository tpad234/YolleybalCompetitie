using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enum;
namespace ClassLibrary
{
    class Set
    {
        int ID { get; }
        Wedstrijd WedstrijdID { get; }
        int Scoreteamthuis { get; set; }
        int Scoreteamuit { get; set; }
        Winaar Winaar { get; set; }
    }
}
