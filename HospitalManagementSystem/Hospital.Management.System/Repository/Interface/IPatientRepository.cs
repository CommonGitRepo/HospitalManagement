using Hospital.Management.System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Repository.Interface
{
    public interface IPatientRepository
    {
        public List<Patient> Get();

        public Patient GetById(string id);

        public void Update(string id, Patient Patient);

        public Patient Create(Patient patient);

    }
}
