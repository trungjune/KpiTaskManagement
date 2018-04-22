using System;
using System.Windows.Forms;
using KpiTaskManagement.BLL;
using KpiTaskManagement.Entity;

namespace KpiTaskManagement
{
    public partial class DetailedTaskForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();

        private void InitComboBox()
        {
            //comboBox1.Items.Clear();
            //comboBox1.Items.Add(sexType.Male);
            //comboBox1.Items.Add(sexType.Female);
            //comboBox1.Items.Add(sexType.Other);

            //  cbxAssignee.Items.Clear();
            cbxAssignee.DataSource = employeeBLL.LoadEmployeeName();
            cbxAssignee.DisplayMember = "EmployeeName";
            cbxAssignee.ValueMember = "ID";
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
