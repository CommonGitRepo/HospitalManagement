using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Entity
{
    public class Service
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Charges")]
        public string Charges { get; set; }

        [BsonElement("IsActive")]
        public bool IsActive { get; set; }
    }
}
