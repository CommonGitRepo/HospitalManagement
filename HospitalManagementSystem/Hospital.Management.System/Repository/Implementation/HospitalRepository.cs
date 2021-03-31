using AutoMapper;
using Hospital.Management.System.DbConfiguration;
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
    public class HospitalRepository : IHospitalRepository
    {
        private readonly MongoDbContext _conetxt;
        private readonly IMapper _mapper;
        public HospitalRepository(IOptions<MongoSettings> options,IMapper mapper)
        {
            _conetxt = new MongoDbContext(options.Value);
            _mapper = mapper;
        }

        public List<Model.Service> Get()
        {
            var patients = _conetxt.Service.Find(_ => true).ToList();
            return _mapper.Map<List<Model.Service>>(patients);
        }

        public Model.Service GetById(string id)
        {
            var patients = _conetxt.Service.Find(_ => _.Id == id).FirstOrDefault();
            return _mapper.Map<Model.Service>(patients);
        }

        public void Update(string id, Model.Service service)
        {
            var entity = _mapper.Map<Entity.Service>(service);
            _conetxt.Service.ReplaceOne(_ => _.Id == id, entity);

        }

        public Model.Service Create(Model.Service service)
        {
            var entity = _mapper.Map<Entity.Service>(service);
            _conetxt.Service.InsertOne(entity);

            return _mapper.Map<Model.Service>(entity);

        }
    }
}
