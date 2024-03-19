using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Step_3.Dto
{
    public class CreateDoctorDto
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int YearsOfExperience { get; set; }
        public string Hospital { get; set; }
    }
}
