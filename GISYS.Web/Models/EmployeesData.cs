using System.Collections.Generic;

namespace GISYS.Web.Models
{
    public class EmployeesData
    {
        public string Status { get; set; }
        public List<EmployeeDetails> Data { get; set; }
        public string Message { get; set; }
    }
}
