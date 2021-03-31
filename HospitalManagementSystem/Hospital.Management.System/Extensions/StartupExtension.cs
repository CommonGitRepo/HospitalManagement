using Hospital.Management.System.Repository.Implementation;
using Hospital.Management.System.Repository.Interface;
using Hospital.Management.System.Service.Implementation;
using Hospital.Management.System.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Management.System.Extensions
{
    public static class StartupExtension
    {

        public static void AddDependency(this IServiceCollection services)
        {
            services.AddTransient<IBillingService, BillingService>();
            services.AddTransient<IDoctorService, DoctorService>();
            services.AddTransient<IHospitalService, HospitalService>();
            services.AddTransient<IPatientService, PatientService>();

            services.AddTransient<IPatientRepository, PatientReposiitory>();
            services.AddTransient<IHospitalRepository, HospitalRepository>();
            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<IBillingRepository, BillingRepository>();
        }

    }
}
