using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.DTO
{
    public class Rent
    {
        [Range(0, int.MaxValue, ErrorMessage = "Rent can not be negative")]
        public int monthlyRent { get; set; }
    }
}
