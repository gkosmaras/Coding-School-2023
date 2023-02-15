﻿using PetShop.Models;
using PetShop.Blazor.Shared.DTO.Customer;
using PetShop.Blazor.Shared.DTO.Employee;
using PetShop.Blazor.Shared.DTO.Pet;
using PetShop.Blazor.Shared.DTO.PetFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Blazor.Shared.DTO.Transaction
{
    public class TransactionEditDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int PetId { get; set; }
        public int PetFoodId { get; set; }

        public List<CustomerEditDto> Customers { get; set; } = new();
        public List<EmployeeEditDto> Employees{ get; set; } = new();
        public List<PetEditDto> Pets { get; set; } = new();
        public List<PetFoodEditDto> PetFoods { get; set; } = new();
    }

}