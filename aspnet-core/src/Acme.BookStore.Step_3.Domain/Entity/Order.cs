using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Step_3.Entity
{
    public class Order : Entity<Guid>
    {
        public string? ProductName { get; set; }
    }
}
