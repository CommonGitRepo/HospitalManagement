using Hospital.Management.System.DbConfiguration.MongoHelper;
using Hospital.Management.System.Entity;
using Hospital.Management.System.Model.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.DbConfiguration
{
    public class MongoDbContext
    {
        private readonly MongoDbHelper _mongoDbHelper;
        public MongoDbContext(MongoSettings settings)
        {
            _mongoDbHelper = new MongoDbHelper(settings);
        }

        public IMongoCollection<Bills> Bills => _mongoDbHelper.GetCollection<Bills>("Bills");

        public IMongoCollection<Doctor> Doctors => _mongoDbHelper.GetCollection<Doctor>("Doctor");

        public IMongoCollection<Patient> Patient => _mongoDbHelper.GetCollection<Patient>("Patient");

        public IMongoCollection<SalarySlip> SalarySlip => _mongoDbHelper.GetCollection<SalarySlip>("SalarySlip");

        public IMongoCollection<Entity.Service> Service => _mongoDbHelper.GetCollection<Entity.Service>("Service");

        public IMongoCollection<User> User => _mongoDbHelper.GetCollection<User>("User");

    }
}
