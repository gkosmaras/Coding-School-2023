﻿using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win.Handler
{
    public class ItemHandler
    {
        private Validator validator = new Validator();
        public async Task<IEnumerable<ItemEditDto>> PopulateDataGridView()
        {
            HttpClient httpClient = new HttpClient();
            using (httpClient)
            {
                var response = await httpClient.GetAsync("https://localhost:7209/item");
                var data = await response.Content.ReadAsAsync<IEnumerable<ItemEditDto>>();
                return data;
            }
        }

        public async Task AddItem(ItemEditDto item)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync("https://localhost:7209/item", item);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureAdd", "Error", MessageBoxButtons.OK);
            }
        }

        public async Task EditItem(ItemEditDto item)
        {
            string errorMessage = "Success";
            HttpClient httpClient = new HttpClient();
            var responseOriginal= await httpClient.GetAsync($"https://localhost:7209/item/{item.ID}");
            var data = await responseOriginal.Content.ReadAsAsync<ItemEditDto>();
            if (validator.ValidateCode(item.Code, data.Code))
            {
                var response = await httpClient.PutAsJsonAsync("https://localhost:7209/item", item);
            }
            //var response = await httpClient.PutAsJsonAsync("https://localhost:7209/item", item);
            else
            {
                MessageBox.Show("FailureEdit", "Error", MessageBoxButtons.OK);
            }
        }

        public async Task DeleteItem(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync($"https://localhost:7209/item/{id}");
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureDelete", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
