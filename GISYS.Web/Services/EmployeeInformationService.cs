using GISYS.Web.Interfaces;
using GISYS.Web.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace GISYS.Web.Services
{
    public class EmployeeInformationService : IEmployeeInformation
    {
        public async Task<EmployeesData> GetAllEmployees()
        {
            string url = "http://dummy.restapiexample.com/api/v1/employees";

            return await Task.Run(
                async () => JsonConvert.DeserializeObject<EmployeesData>(
                  await GetConnection(url)
                    ));
        }

        public async Task<SelectedEmployee> GetSelectedEmployee(int Id)
        {
            string url = $"http://dummy.restapiexample.com/api/v1/employee/ {Id}";

            return await Task.Run(
               async () => JsonConvert.DeserializeObject<SelectedEmployee>(
                   await GetConnection(url)
                ));

        }

        private static async Task<string> GetConnection(string url)
        {
            HttpClient client = new();
            HttpResponseMessage responseGet = await client.GetAsync(url);

            return await responseGet.Content.ReadAsStringAsync(); ;
        }
    }
}
