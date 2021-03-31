using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Model
{
    public class Doctor
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Type { get; set; }

        public DateTime JoinedDate { get; set; }

        public string Address { get; set; }

        public List<Patient> PatientVisited { get; set; }
    }
}
