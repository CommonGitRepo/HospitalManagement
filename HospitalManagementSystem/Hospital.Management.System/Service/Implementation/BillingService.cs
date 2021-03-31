using Hospital.Management.System.Model;
using Hospital.Management.System.Repository.Interface;
using Hospital.Management.System.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Service.Implementation
{
    public class BillingService: IBillingService
    {
        private readonly IBillingRepository _repository;
        public BillingService(IBillingRepository repository)
        {
            _repository = repository;
        }

        public Bills Create(Bills bill)
        {
            return _repository.Create(bill);
        }

        public List<Bills> Get()
        {
            return _repository.Get();
        }

        public Bills GetById(string id)
        {
            return _repository.GetById(id);
        }

        public void Update(string id, Bills bills)
        {
            _repository.Update(id, bills);
        }
    }
}
