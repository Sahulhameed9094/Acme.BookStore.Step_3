using Acme.BookStore.Step_3.Dto;
using Acme.BookStore.Step_3.Entity;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Step_3.DoctorService
{
    //[AllowAnonymous]
    public class DoctorServices : ApplicationService

    {
        private readonly IRepository<Doctor, Guid> _doctorRepository;
        private readonly ICurrentTenant _currentTenant;

        public DoctorServices(IRepository<Doctor, Guid> repository, ICurrentTenant currentTenant)
        {
            this._doctorRepository = repository;
            this._currentTenant = currentTenant;
        }

        public string GetTenantName()
        {
            return this.CurrentTenant.Name;
        }

        public async Task DoItAsync()
        {
            Guid? tenantId = CurrentTenant.Id;
        }

        public async Task<List<Doctor>> GetListAsync()
        {
            return await _doctorRepository.GetListAsync();
        }

        
        public async Task<Doctor> CreateNewDoctor(CreateDoctorDto input)
        {
            var Doctor = new Doctor()
            {
                Name = input.Name,
                Specialization = input.Specialization,
                YearsOfExperience = input.YearsOfExperience,
                Hospital = input.Hospital,
            };

            return await _doctorRepository.InsertAsync(Doctor);
        }

        public async Task<long> GetProductCountAsync()
        {
            //using (_dataFilter.Disable<IMultiTenant>())
            //{
            return await _doctorRepository.GetCountAsync();
            //}
        }



    }
}
