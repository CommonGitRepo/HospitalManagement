using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Entity
{
    public class Patient
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("AdmittedDate")]
        public string AdmittedDate { get; set; }

        [BsonElement("IsDischarged")]
        public bool isDischarged { get; set; }

        
        [BsonElement("BedNo")]
        public string BedNo { get; set; }

        [BsonElement("Services")]
        public List<string> Services { get; set; }
        
        [BsonElement("Image")]
        public string Image { get; set; }

    }
}
