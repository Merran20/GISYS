using GISYS.Web.Models;
using System.Threading.Tasks;

namespace GISYS.Web.Interfaces
{
    public interface IEmployeeInformation
    {
        Task<EmployeesData> GetAllEmployees();
        Task<SelectedEmployee> GetSelectedEmployee(int Id); 
    }
}
