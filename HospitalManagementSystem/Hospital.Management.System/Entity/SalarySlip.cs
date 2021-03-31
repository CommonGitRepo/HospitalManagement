using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Entity
{
    public class SalarySlip
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("Doctor")]
        public Doctor Doctor { get; set; }

        [BsonElement("FixedAmount")]
        public int FixedAmount { get; set; }

        [BsonElement("IncentievAmount")]
        public int IncentievAmount { get; set; }

        [BsonElement("RemainingAmount")]
        public int RemainingAmount { get; set; }

        [BsonElement("TotalAmount")]
        public int TotalAmount { get; set; }
    }
}
