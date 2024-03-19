using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Step_3.Entity
{
    public class Doctor : Entity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; } //Defined by the IMultiTenant interface

        public string Name { get; set; }
        public string Specialization { get; set; }
        public int YearsOfExperience { get; set; }
        public string Hospital { get; set; }

        
    }
}
