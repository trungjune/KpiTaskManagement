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
        TaskBLL()
        {
            taskDAL = new TaskDAL();
        }
        public void AddTask(TaskEntity task)
        {
            taskDAL.Add(task);
        }

        public void EditTask(TaskEntity task, int ID)
        {
            taskDAL.Edit(task, ID);
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
