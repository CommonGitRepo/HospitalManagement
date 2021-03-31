using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Model
{
    public class Service
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Charges { get; set; }

        public bool IsActive { get; set; }
    }
}
