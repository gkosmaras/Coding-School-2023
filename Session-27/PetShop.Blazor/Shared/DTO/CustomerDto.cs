﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Blazor.Shared.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Tin { get; set; }
    }
}
