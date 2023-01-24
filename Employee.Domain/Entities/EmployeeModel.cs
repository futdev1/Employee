using Employee.Domain.Enums;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Employee.Domain.Entities
{
#pragma warning disable
    public class EmployeeModel
    {
        public EmployeeModel()
        {

        }
        public long id { get; set; }

        public string name { get; set; }

        public string current_city { get; set; }

        public string department { get; set; }
        public Gender gender_type { get; set; }
    }
}
