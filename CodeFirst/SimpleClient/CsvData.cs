using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClient
{
    public class CsvData
    {
        public string Id { get; set; }
        public decimal Minutes { get; set; }

        public DateTime Date { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }
        public string Project { get; set; }
        public string Description { get; set; }

    }
}
