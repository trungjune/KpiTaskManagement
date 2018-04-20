using System;
using System.Data;
using KpiTaskManagement.Common;


namespace KpiTaskManagement.DAL
{
    public class TaskDAL : ICommonDAL
    {
        public long Add(ICommonEntity task)
        {
            throw new NotImplementedException();
        }

     
        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        
        public bool Edit(ICommonEntity task, int ID)
        {
            throw new NotImplementedException();
        }

        public static DataTable LoadAll()
        {
            DataTable data= new DataTable();
            return data; 
        }
    }
}
