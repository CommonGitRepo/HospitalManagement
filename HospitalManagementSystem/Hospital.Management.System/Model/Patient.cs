using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Model
{
    public class Patient
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Type { get; set; }

        public string AdmittedDate { get; set; }

        public bool IsDischarged { get; set; }

        public string BedNo { get; set; }

        public List<string> Services { get; set; }
        public string Image { get; set; }

        public Patient()
        {
            Services = new List<string>();
        }

    }
}
