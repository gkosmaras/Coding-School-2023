using Azure;
using FuelStation.Web.Blazor.Shared.DTO;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win.Handler
{
    public class CustomerHandler
    {
        public async Task<IEnumerable<CustomerEditDto>> PopulateDataGridView()
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<List<CustomerEditDto>>("https://localhost:7209/customer");
        }

        public async Task AddCustomer(CustomerEditDto customer)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync("https://localhost:7209/customer", customer);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureAdd", "Error", MessageBoxButtons.OK);
            }
        }

        public async Task EditCustomer(CustomerEditDto customer)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PutAsJsonAsync($"https://localhost:7209/customer", customer);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureEdit", "Error", MessageBoxButtons.OK);
            }
        }

        public async Task  DeleteCustomer(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync($"https://localhost:7209/customer/{id}");
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer can not be deleted as it has transactions", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
