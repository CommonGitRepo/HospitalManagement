using Hospital.Management.System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Repository.Interface
{
    public interface IBillingRepository
    {
        public List<Bills> Get();

        public Bills GetById(string id);

        public void Update(string id, Bills bills);

        public Bills Create(Bills bill);

    }
}
