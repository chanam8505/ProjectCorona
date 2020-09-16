using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Corona.BE
{
    public class Demand
    {
        [Key]
        public int codeDem { get; set; }
        public Address address { get; set; }
        public typeDiv type { get; set; }

        public Demand(int code,string city, string street, string numberOfBuilding, typeDiv type)
        {
            this.codeDem = code;///////////Random/number
            this.address = new Address(city, street, numberOfBuilding);
            this.type = type;
        }
    }
}
