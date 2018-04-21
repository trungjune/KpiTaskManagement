using System;
using System.Data;
using KpiTaskManagement.Common;
using KpiTaskManagement.Entity;


namespace KpiTaskManagement.DAL
{
    public class TaskDAL : ICommonDAL
    {
        public bool Add(ICommonEntity _task)
        {
            var task = (_task as TaskEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"insert into tblTask (TaskCode,TaskName,Description,Assignee,Reporter,Status,Priority,TaskType) values ('{0}','{1}','{2}',{3},{4},{5},{6},{7}) ",
                task.TaskCode,
                task.TaskName,
                task.Description,               
                task.Assignee.ID,
                task.Reporter.ID,
                (int)task.Status,
                (int)task.Priority,
                (int)task.TaskType
                );
                DBManager.InstantDBManger.QueryExecutionWithTransaction(str);
                return true;
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                return false;
            }
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
            string str = string.Format("select * from tblTask");
            return DBManager.InstantDBManger.GetData(str);        
        }
    }
}
