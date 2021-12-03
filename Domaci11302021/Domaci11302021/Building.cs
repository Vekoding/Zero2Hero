using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Configuration;

namespace Domaci11302021
{
    public class Building
    {
        public Building(string investor, int numberOfFloors, int numberOfApartments, int elevator)
        {
            this.Investor = investor;
            this.NumberOfFloors = numberOfFloors;
            this.NumberOfApartments = numberOfApartments;
            this.Elevator = elevator;
        }

        public string Investor { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfApartments { get; set; }
        public int Elevator { get; set; }
    }
}
