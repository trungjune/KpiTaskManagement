using System;
using System.Data;
using KpiTaskManagement.Common;
using KpiTaskManagement.Entity;

namespace KpiTaskManagement.DAL
{
    public class EmployeeDAL : ICommonDAL
    {
        public bool Add(ICommonEntity commonEntity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Edit(ICommonEntity commonEntity, int ID)
        {
            throw new NotImplementedException();
        }

        public static DataTable LoadAll()
        {
            string str = @"";
            return DBManager.InstantDBManger.GetData(str);
        }

        public static DataTable LoadEmployeeName()
        {
            string str = @"SELECT ID, CONCAT_WS(' ',EmployeeFirstName, EmployeeLastName) as EmployeeName FROM tblemployee";
            return DBManager.InstantDBManger.GetData(str);
        }

    }
}
