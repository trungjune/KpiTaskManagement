using System;
using System.Windows.Forms;
using KpiTaskManagement.BLL;
using KpiTaskManagement.Entity;
using KpiTaskManagement.Common;

namespace KpiTaskManagement
{
    public partial class DetailedTaskForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();

        private void InitComboBox()
        {           
            cbxAssignee.DataSource = employeeBLL.LoadEmployeeName();
            cbxAssignee.DisplayMember = "EmployeeName";
            cbxAssignee.ValueMember = "ID";

            cbxReporter.DataSource = employeeBLL.LoadEmployeeName();
            cbxReporter.DisplayMember = "EmployeeName";
            cbxReporter.ValueMember = "ID";

            cbxStatus.Items.Clear();
            cbxStatus.Items.Add(StatusValue.ToDo);
            cbxStatus.Items.Add(StatusValue.InProgress);
            cbxStatus.Items.Add(StatusValue.ReadyForQA);
            // ... add het tat cac gia tri cua status la duoc 
            cbxStatus.SelectedIndex = 0;
            // priority va task type lam tuong tu nhe

        }

        public DetailedTaskForm()
        {
            InitializeComponent();
            InitComboBox();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxAssignee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
