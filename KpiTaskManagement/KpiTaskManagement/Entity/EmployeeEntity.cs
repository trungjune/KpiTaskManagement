using System;
using KpiTaskManagement.Common;

namespace KpiTaskManagement.Entity
{
    public class EmployeeEntity:ICommonEntity
    {
        public int ID;
        public String EmployeeName { get; set; }
        public String EmployeeFirstName { get; set; }
        public String EmployeeLastName { get; set; }
    }
}
