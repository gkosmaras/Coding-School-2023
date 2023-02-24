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
    public class TransactionHandler
    {
        private Validator validator = new Validator();
        public async Task<IEnumerable<TransactionEditDto>> PopulateDataGridView()
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<List<TransactionEditDto>>("https://localhost:7209/Transaction");
        }

        public async Task<TransactionEditDto> GetTransaction(int id)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<TransactionEditDto>($"https://localhost:7209/Transaction/{id}");
        }

        public async Task AddTransaction(TransactionEditDto transaction)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync("https://localhost:7209/Transaction", transaction);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureAdd", "Error", MessageBoxButtons.OK);
            }
        }

        public async Task EditTransaction(TransactionEditDto transaction)
        {
            if (!validator.CheckPayment(transaction.ID) && transaction.PaymentMethod == Model.Enums.PaymentMethod.CreditCard)
            {
                MessageBox.Show("Transactions over 50€ can not be paid with card", "Warnign", MessageBoxButtons.OK);
            }
            else
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.PutAsJsonAsync("https://localhost:7209/Transaction", transaction);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("FailureEdit", "Error", MessageBoxButtons.OKCancel);
                }
            }
        }

        public async Task DeleteTransaction(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync($"https://localhost:7209/Transaction/{id}");
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureDelete", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
