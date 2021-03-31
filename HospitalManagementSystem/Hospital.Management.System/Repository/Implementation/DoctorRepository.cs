using AutoMapper;
using Hospital.Management.System.DbConfiguration;
using Hospital.Management.System.Model;
using Hospital.Management.System.Model.Settings;
using Hospital.Management.System.Repository.Interface;
using Hospital.Management.System.Service.Interface;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Repository.Implementation
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly MongoDbContext _conetxt;
        private readonly IMapper _mapper;
        public DoctorRepository(IOptions<MongoSettings> options, IMapper mapper)
        {
            _conetxt = new MongoDbContext(options.Value);
            _mapper = mapper;

        }

        public List<Doctor> Get()
        {
            var doctors = _conetxt.Doctors.Find(_ => true).ToList();
            return _mapper.Map<List<Doctor>>(doctors);
        }

        public Doctor GetById(string id)
        {
            var patients = _conetxt.Doctors.Find(_ => _.Id == id).FirstOrDefault();
            return _mapper.Map<Doctor>(patients);
        }

        public void Update(string id, Doctor doctor)
        {
            var entity = _mapper.Map<Entity.Doctor>(doctor);
            _conetxt.Doctors.ReplaceOne(_ => _.Id == id, entity);

        }

        public Doctor Create(Doctor patient)
        {
            var entity = _mapper.Map<Entity.Doctor>(patient);
            _conetxt.Doctors.InsertOne(entity);

            return _mapper.Map<Doctor>(entity);

        }

    }
}
