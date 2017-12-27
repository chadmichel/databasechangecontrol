using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class TimeLogItem
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Project { get; set; }
        public decimal Minutes { get; set; }
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public int Week { get; set; }

        public int Year { get; set; }
        public string ExternalId { get; set; }


    }
}
