﻿using FuelStation.Web.Blazor.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win.Handler
{
    public class TransactionLineHandler
    {
        public async Task<IEnumerable<TransactionLineEditDto>> PopulateDataGridView()
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<List<TransactionLineEditDto>>("https://localhost:7209/TransactionLine");
        }

        public async Task AddTransactionLine(TransactionLineEditDto transLine)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync("https://localhost:7209/TransactionLine", transLine);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureAdd", "Error", MessageBoxButtons.OK);
            }
        }

        public async Task EditTransactionLine(TransactionLineEditDto transLine)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PutAsJsonAsync("https://localhost:7209/transactionLine", transLine);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureEdit", "Error", MessageBoxButtons.OK);
            }
        }

        public async Task DeleteTransactionLine(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync($"https://localhost:7209/transactionLine/{id}");
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("FailureDelete", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
