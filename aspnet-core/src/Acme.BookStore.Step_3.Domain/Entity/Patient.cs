using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Step_3.Entity
{
    public class Patient : Entity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; } //Defined by the IMultiTenant interface

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Condition { get; set; }
    }
}
