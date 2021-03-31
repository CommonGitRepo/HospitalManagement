using Hospital.Management.System.Model;
using Hospital.Management.System.Repository.Interface;
using Hospital.Management.System.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Service.Implementation
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;
        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public Patient Create(Patient patient)
        {
            return _repository.Create(patient);
        }

        public List<Patient> Get()
        {
            return _repository.Get();
        }

        public Patient GetById(string id)
        {
            return _repository.GetById(id);
        }

        public void Update(string id, Patient patient)
        {
            _repository.Update(id, patient);
        }
    }
}
