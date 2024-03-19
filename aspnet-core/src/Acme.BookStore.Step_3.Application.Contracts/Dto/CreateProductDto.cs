using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Step_3.Dto
{
    public class CreateProductDto
    {
        public string? Name { get; set; }

        public float Price { get; set; }
    }
}
