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
            using (httpClient)
            {
                var response = await httpClient.GetAsync("https://localhost:7209/customer");
                var data = await response.Content.ReadAsAsync<IEnumerable<CustomerEditDto>>();
                return data;
            }
        }

        public async Task AddCustomer(CustomerEditDto customer)
        {
            /*            string json = JsonConvert.SerializeObject(customer);
                        HttpClient httpClient = new HttpClient();
                        httpClient.BaseAddress = new Uri("https://localhost:7209");
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/customer");
                        request.Content = new StringContent(json, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await httpClient.SendAsync(request);*/

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync("https://localhost:7209/customer", customer);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureAdd", "Error", MessageBoxButtons.OK);
            }
        }

        public async Task EditCustomer(CustomerEditDto customer)
        {
            /*string json = JsonConvert.SerializeObject(customer);
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7209");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, $"/customer/{customer.ID}");
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.SendAsync(request);*/

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PutAsJsonAsync($"https://localhost:7209/customer", customer);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureEdit", "Error", MessageBoxButtons.OK);
            }
        }

        public async Task  DeleteCustomer(int id)
        {
            /*HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7209");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, $"/customer/{id}");
            HttpResponseMessage response = await httpClient.SendAsync(request);*/

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync($"https://localhost:7209/customer/{id}");
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureDelete", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
