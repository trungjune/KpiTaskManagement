using System.Data;
using KpiTaskManagement.Entity;
using KpiTaskManagement.DAL;

namespace KpiTaskManagement.BLL
{
    public class EmployeeBLL
    {
        EmployeeDAL EmployeeDAL;
        public EmployeeBLL()
        {
            EmployeeDAL = new EmployeeDAL();
        }
        public void AddEmployee(EmployeeEntity _employee)
        {
            EmployeeDAL.Add(_employee);
        }

        public void EditEmployee(EmployeeEntity _employee, int ID)
        {
            EmployeeDAL.Edit(_employee, ID);
        }

        public void DeleteEmployee(int ID)
        {
            EmployeeDAL.Delete(ID);
        }

        public DataTable LoadAllEmployee()
        {
            return EmployeeDAL.LoadAll();
        }

        public DataTable LoadEmployeeName()
        {
            return EmployeeDAL.LoadEmployeeName();
        }
    }
}
