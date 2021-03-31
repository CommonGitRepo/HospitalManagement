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
    public class BillingRepository: IBillingRepository
    {
        private readonly MongoDbContext _conetxt;
        private IMapper _mapper;
        public BillingRepository(IOptions<MongoSettings> options,IMapper mapper)
        {
            _conetxt = new MongoDbContext(options.Value);
            _mapper = mapper;

        }

        public List<Bills> Get()
        {
            var bills = _conetxt.Bills.Find(_ => true).ToList();
            return _mapper.Map<List<Bills>>(bills);
        }

        public Bills GetById(string id)
        {
            var patients = _conetxt.Bills.Find(_ => _.Id == id).FirstOrDefault();
            return _mapper.Map<Bills>(patients);
        }

        public void Update(string id, Bills bills)
        {
            var entity = _mapper.Map<Entity.Bills>(bills);
            _conetxt.Bills.ReplaceOne(_ => _.Id == id, entity);

        }

        public Bills Create(Bills patient)
        {
            var entity = _mapper.Map<Entity.Bills>(patient);
            _conetxt.Bills.InsertOne(entity);

            return _mapper.Map<Bills>(entity);

        }
    }
}
