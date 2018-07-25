using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEngineer
{
    public class Loan
    {
        public string MSISDN { get; set; }
        public string Network { get; set; }
        public DateTime Date { get; set; }
        public string Product { get; set; }
        public int Amount { get; set; }        
    }
}
