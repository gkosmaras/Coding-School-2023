using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.DTO
{
    public class CustomerEditDto
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name of customer is required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Surname of customer is required")]
        public string Surname { get; set; } = null!;

        public string CardNumber { get; set; } = "";
    }
}
