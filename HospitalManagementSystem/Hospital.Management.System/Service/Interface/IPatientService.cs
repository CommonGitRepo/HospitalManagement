using Hospital.Management.System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Service.Interface
{
    public interface IPatientService
    {
        public List<Patient> Get();

        public Patient GetById(string id);

        public void Update(string id, Patient Patient);

        public Patient Create(Patient patient);
    }
}
