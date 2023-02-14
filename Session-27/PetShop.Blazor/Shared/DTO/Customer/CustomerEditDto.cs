using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Blazor.Shared.DTO.Customer
{
    public class CustomerEditDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int Phone { get; set; }
        public string Tin { get; set; } = null!;
    }
}
