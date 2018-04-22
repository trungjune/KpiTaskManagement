using System;
using System.Windows.Forms;
using KpiTaskManagement.BLL;
using KpiTaskManagement.Common;

namespace KpiTaskManagement
{
    public partial class TaskManagementForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        public TaskManagementForm()
        {
            InitializeComponent();
        }

        private void load()
        {
            grcTask.DataSource = taskBLL.LoadAllTask();

        }
        private void TaskManagementForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            DetailedTaskForm detailedTaskForm = new DetailedTaskForm();
            detailedTaskForm.ShowDialog();
            load();
        }

        private void grvTask_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Status")
                    if (e.Value != null)
                    {                     
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = StatusValue.ToDo.ToString();
                                break;
                            case 1:
                                e.DisplayText = StatusValue.InProgress.ToString();
                                break;
                            case 2:
                                e.DisplayText = StatusValue.ReadyForQA.ToString();
                                break;
                            case 3:
                                e.DisplayText = StatusValue.InQA.ToString();
                                break;
                            case 4:
                                e.DisplayText = StatusValue.Done.ToString();
                                break;
                            case 5:
                                e.DisplayText = StatusValue.Rejected.ToString();
                                break;
                            case 6:
                                e.DisplayText = StatusValue.Blocked.ToString();
                                break;
                        }
                    }

                if (e.Column.FieldName == "Priority")
                    if (e.Value != null)
                    {
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = PriorityValue.High.ToString();
                                break;
                            case 1:
                                e.DisplayText = PriorityValue.Medium.ToString();
                                break;
                            case 2:
                                e.DisplayText = PriorityValue.Low.ToString();
                                break;
                        }
                    }
                if (e.Column.FieldName == "TaskType")
                    if (e.Value != null)
                    {
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = TaskTypeValue.UserStory.ToString();
                                break;
                            case 1:
                                e.DisplayText = TaskTypeValue.Bug.ToString();
                                break;                       
                        }
                    }
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                //  LogService.LogError("Error", ex);
            }
}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
