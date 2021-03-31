using Hospital.Management.System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Service.Interface
{
    public interface IDoctorService
    {
        public List<Doctor> Get();

        public Doctor GetById(string id);

        public void Update(string id, Doctor Doctor);

        public Doctor Create(Doctor doctor);
    }
}
