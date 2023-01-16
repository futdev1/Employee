using Employee.Domain.Enums;

namespace Employee.Domain.Entities
{
#pragma warning disable
    public class EmployeeModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string CurrentCity { get; set; }

        public string Department { get; set; }

        public Gender GenderType { get; set; }
    }
}
