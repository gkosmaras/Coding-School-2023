using FuelStation.Web.Blazor.Shared.DTO;
using FuelStation.Web.Blazor.Shared.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
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
            return await httpClient.GetFromJsonAsync<List<ItemEditDto>>("https://localhost:7209/item");
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
            HttpClient httpClient = new HttpClient();
            var responseOriginal= await httpClient.GetAsync($"https://localhost:7209/item/{item.ID}");
            var data = await responseOriginal.Content.ReadAsAsync<ItemEditDto>();
            if (validator.ValidateCode(item.Code, data.Code))
            {
                var response = await httpClient.PutAsJsonAsync("https://localhost:7209/item", item);
            }
            else
            {
                MessageBox.Show("Item's code already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task DeleteItem(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync($"https://localhost:7209/item/{id}");
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Item can not be deleted as it is in transactions", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
