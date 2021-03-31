using Hospital.Management.System.Repository.Interface;
using Hospital.Management.System.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Service.Implementation
{
    public class HospitalService: IHospitalService
    {
        private readonly IHospitalRepository _repository;
        public HospitalService(IHospitalRepository repository)
        {
            _repository = repository;
        }

        public Model.Service Create(Model.Service service)
        {
            return _repository.Create(service);
        }

        public List<Model.Service> Get()
        {
            return _repository.Get();
        }

        public Model.Service GetById(string id)
        {
            return _repository.GetById(id);
        }

        public void Update(string id, Model.Service service)
        {
            _repository.Update(id, service);
        }
    }
}
