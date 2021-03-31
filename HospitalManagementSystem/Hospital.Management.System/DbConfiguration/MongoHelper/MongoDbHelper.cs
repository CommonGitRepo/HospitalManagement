using Hospital.Management.System.Model.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.DbConfiguration.MongoHelper
{
    public class MongoDbHelper
    {
        private readonly IMongoDatabase _database;
        public MongoDbHelper(MongoSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName) {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
