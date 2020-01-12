using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagment
{
    class Ticket
    {
        public string PessengerName { get; set; }
        DateTime PessengerDateofBirtD { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTimeOffset DepartureTime { get; set;}
        public DateTimeOffset ArrivalTime { get; set; }
        public int BonusPoint { get; set; }
    }
}
