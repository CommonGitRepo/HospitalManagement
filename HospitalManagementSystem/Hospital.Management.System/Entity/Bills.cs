using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Model
{
    public class Bills
    {
        [BsonId]
        public string Id { get; set; }
        
        [BsonElement("Patient")]
        public Patient Patient { get; set; }
        
        [BsonElement("InsurancePaidAmmount")]
        public int InsurancePaidAmmount { get; set; }

        [BsonElement("PatientPaidAmount")]
        public int PatientPaidAmount { get; set; }

        [BsonElement("RemainingAmount")]
        public int RemainingAmount { get; set; }

        [BsonElement("TotalAmount")]
        public int TotalAmount { get; set; }
        
    }
}
