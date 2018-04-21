using System;
using System.Windows.Forms;
using KpiTaskManagement.BLL;
using KpiTaskManagement.Entity;

namespace KpiTaskManagement
{
    public partial class DetailedTask : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        public DetailedTask()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var task = new TaskEntity
            {
                TaskCode = "KMF-1",
                TaskName = "Design software architecture",
                Description = "Design software architecture"
            };
            var reporter = new EmployeeEntity
            {
                ID = 1
            };
            task.Reporter = reporter;
            var assignee = new EmployeeEntity
            {
                ID = 2
            };
            task.Assignee = assignee;

            taskBLL.AddTask(task);
            this.Close();
        }
    }
}
