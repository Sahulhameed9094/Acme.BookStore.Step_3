using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Step_3.Entity
{
    public class Product : Entity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; } //Defined by the IMultiTenant interface

        public string? Name { get; set; }

        public float Price { get; set; }
    }
}
