using System;
using KpiTaskManagement.Common;

namespace KpiTaskManagement.Entity
{
    public class TaskEntity:ICommonEntity
    {
        public String TaskCode { get; set; }
        public String TaskName { get; set; }
        public String Description { get; set; }
        public EmployeeEntity Assignee { get; set; }
        public EmployeeEntity Reporter { get; set; }
        public StatusValue Status { get; set; }
        public PriorityValue Priority { get; set; }
        public TaskTypeValue TaskType { get; set; }
    }
}
