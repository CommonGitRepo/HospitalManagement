using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Entity
{
    public class Doctor
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("JoinedDate")]
        public DateTime JoinedDate { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }

        [BsonElement("PatientVisited")]
        public List<Patient> PatientVisited { get; set; }
    }
}
