using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Entity
{
    public class Bills
    {
        public string Id { get; set; }
        
        public Patient Patient { get; set; }
        
        public int InsurancePaidAmmount { get; set; }

        public int PatientPaidAmount { get; set; }

        public int RemainingAmount { get; set; }

        public int TotalAmount { get; set; }
        
    }
}
