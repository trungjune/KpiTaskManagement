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
            DetailedTask detailedTask = new DetailedTask();
            detailedTask.ShowDialog();
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
            }
            catch (Exception ex)
            {
              //  LogService.LogError("Error", ex);
            }
}
    }
}
