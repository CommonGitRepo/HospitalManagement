using Hospital.Management.System.Model;
using Hospital.Management.System.Repository.Interface;
using Hospital.Management.System.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Service.Implementation
{
    public class DoctorService: IDoctorService
    {
        private readonly IDoctorRepository _repository;
        public DoctorService(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public Doctor Create(Doctor doctor)
        {
            return _repository.Create(doctor);
        }

        public List<Doctor> Get()
        {
            return _repository.Get();
        }

        public Doctor GetById(string id)
        {
            return _repository.GetById(id);
        }

        public void Update(string id, Doctor doctor)
        {
            _repository.Update(id, doctor);
        }
    }
}
