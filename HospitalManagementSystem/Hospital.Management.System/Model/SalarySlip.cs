using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Model
{
    public class SalarySlip
    {
        public string Id { get; set; }

        public Doctor Doctor { get; set; }

        public int FixedAmount { get; set; }

        public int IncentievAmount { get; set; }

        public int RemainingAmount { get; set; }

        public int TotalAmount { get; set; }
    }
}
