using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Service.Interface
{
    public interface IHospitalService
    {
        public List<Model.Service> Get();

        public Model.Service GetById(string id);

        public void Update(string id, Model.Service service);

        public Model.Service Create(Model.Service service);
    }
}
