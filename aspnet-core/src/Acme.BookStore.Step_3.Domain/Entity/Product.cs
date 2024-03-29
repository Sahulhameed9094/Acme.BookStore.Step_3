﻿using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Step_3.Entity
{
    public class Product : Entity<Guid>, IMultiTenant
    {
        //https://docs.abp.io/en/abp/latest/Multi-Tenancy#abpmultitenancyoptions-enable-disable-multi-tenancy
        public Guid? TenantId { get; set; } //Defined by the IMultiTenant interface

        public string? Name { get; set; }

        public float Price { get; set; }
    }
}
