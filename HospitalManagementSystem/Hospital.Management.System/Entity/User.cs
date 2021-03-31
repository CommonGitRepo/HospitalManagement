using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Entity
{
    public class User
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("IsActive")]
        public bool IsActive { get; set; }
    }
}
