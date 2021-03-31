using AutoMapper;
using Hospital.Management.System.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Bills, Model.Bills>().ReverseMap();
            CreateMap<Doctor, Model.Doctor>().ReverseMap();
            CreateMap<Patient, Model.Patient>().ReverseMap();
            CreateMap<SalarySlip, Model.SalarySlip>().ReverseMap();
            CreateMap<Entity.Service, Model.Service>().ReverseMap();
            CreateMap<User, Model.User>().ReverseMap();
        }
    }
}
