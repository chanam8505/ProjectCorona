using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Corona.BE
{
    public class Division
    {
        [Key]
        public int codeDiv { get; set; }
        public int empId { get; set; }
        public DateTime dateDiv { get; set; }

        public List<Demand> listOfDemand { get; set; }
        public bool divide { get; set; }
        public Division(int id)
        {
            this.codeDiv = id;

        }
        public Division(int id, int empId, DateTime dateDiv, List<Demand> listOfDemand)
        {
            this.codeDiv = id;
            this.empId = empId;
            this.dateDiv = dateDiv;
            this.listOfDemand = new List<Demand>(listOfDemand);/////////shallow copy
            this.divide = false;
        }

        
    }
}
