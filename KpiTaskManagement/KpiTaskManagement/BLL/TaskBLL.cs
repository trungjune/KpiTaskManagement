using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using KpiTaskManagement.Entity;
using KpiTaskManagement.DAL;

namespace KpiTaskManagement.BLL
{
    public class TaskBLL
    {
        TaskDAL taskDAL;
        public TaskBLL()
        {
            taskDAL = new TaskDAL();
        }
        public void AddTask(TaskEntity _task)
        {
            taskDAL.Add(_task);
        }

        public void EditTask(TaskEntity _task, int ID)
        {
            taskDAL.Edit(_task, ID);
        }

        public void DeleteTask(int ID)
        {
            taskDAL.Delete(ID);
        }

        public DataTable LoadAllTask()
        {
            return TaskDAL.LoadAll();
        }

    }
}
