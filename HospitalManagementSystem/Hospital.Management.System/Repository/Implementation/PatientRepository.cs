using AutoMapper;
using Hospital.Management.System.DbConfiguration;
using Hospital.Management.System.Model;
using Hospital.Management.System.Model.Settings;
using Hospital.Management.System.Repository.Interface;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Hospital.Management.System.Repository.Implementation
{
    public class PatientReposiitory : IPatientRepository
    {
        private readonly MongoDbContext _conetxt;
        private readonly IMapper _mapper;
        public PatientReposiitory(IOptions<MongoSettings> options,IMapper mapper)
        {
            _conetxt = new MongoDbContext(options.Value);
            _mapper = mapper;

        }

        public List<Patient> Get()
        {
            var patients = _conetxt.Patient.Find(_ => true).ToList();
            return _mapper.Map<List<Patient>>(patients);
        }

        public Patient GetById(string id)
        {
            var patients = _conetxt.Patient.Find(_ => _.Id == id).FirstOrDefault();
            return _mapper.Map<Patient>(patients);
        }

        public void Update(string id, Patient patient)
        {
            var entity = _mapper.Map<Entity.Patient>(patient);
            _conetxt.Patient.ReplaceOne(_ => _.Id == id, entity);
            
        }

        public Patient Create(Patient patient)
        {
            var entity = _mapper.Map<Entity.Patient>(patient);
            _conetxt.Patient.InsertOne(entity);

            return _mapper.Map<Model.Patient>(entity);

        }

    }
}
