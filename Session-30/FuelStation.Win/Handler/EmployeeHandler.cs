using FuelStation.Web.Blazor.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win.Handler
{
    public class EmployeeHandler
    {
        public async Task<IEnumerable<EmployeeEditDto>> PopulateDataGridView()
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<List<EmployeeEditDto>>("https://localhost:7209/Employee");
        }
    }
}
