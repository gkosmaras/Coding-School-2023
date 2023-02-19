using FuelStation.EF.Context;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.DTO
{
    public class ItemEditDto
    { 
        public int ID { get; set; }

        [Required(ErrorMessage = "Item code is required")]
        public int Code { get; set; }

        [Required(ErrorMessage = "Item description is required")]
        public string Description { get; set; } = null!;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Type of item is required")]
        public ItemType ItemType { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Price can not be negative")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Cost can not be negative")]
        public decimal Cost { get; set;}
    }
}
