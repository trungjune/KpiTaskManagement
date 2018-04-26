namespace KpiTaskManagement
{
    partial class TaskManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grcTask = new DevExpress.XtraGrid.GridControl();
            this.grvTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcolID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolTaskCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolTaskName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolAssigneeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolReporterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolTaskType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDUTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grcTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // grcTask
            // 
            this.grcTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcTask.Location = new System.Drawing.Point(1, 0);
            this.grcTask.MainView = this.grvTask;
            this.grcTask.Name = "grcTask";
            this.grcTask.Size = new System.Drawing.Size(799, 390);
            this.grcTask.TabIndex = 0;
            this.grcTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTask});
            // 
            // grvTask
            // 
            this.grvTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcolID,
            this.grcolTaskCode,
            this.grcolStatus,
            this.grcolTaskName,
            this.grcolAssigneeName,
            this.grcolReporterName,
            this.grcolPriority,
            this.grcolTaskType,
            this.grcolDescription});
            this.grvTask.GridControl = this.grcTask;
            this.grvTask.Name = "grvTask";
            this.grvTask.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.grvTask_CustomColumnDisplayText);
            // 
            // grcolID
            // 
            this.grcolID.Caption = "ID";
            this.grcolID.FieldName = "ID";
            this.grcolID.Name = "grcolID";
            // 
            // grcolTaskCode
            // 
            this.grcolTaskCode.Caption = "Task Code";
            this.grcolTaskCode.FieldName = "TaskCode";
            this.grcolTaskCode.Name = "grcolTaskCode";
            this.grcolTaskCode.Visible = true;
            this.grcolTaskCode.VisibleIndex = 0;
            // 
            // grcolStatus
            // 
            this.grcolStatus.Caption = "Status";
            this.grcolStatus.FieldName = "Status";
            this.grcolStatus.Name = "grcolStatus";
            this.grcolStatus.Visible = true;
            this.grcolStatus.VisibleIndex = 2;
            // 
            // grcolTaskName
            // 
            this.grcolTaskName.Caption = "Task Name";
            this.grcolTaskName.FieldName = "TaskName";
            this.grcolTaskName.Name = "grcolTaskName";
            this.grcolTaskName.Visible = true;
            this.grcolTaskName.VisibleIndex = 1;
            // 
            // grcolAssigneeName
            // 
            this.grcolAssigneeName.Caption = "Assignee";
            this.grcolAssigneeName.FieldName = "AssigneeName";
            this.grcolAssigneeName.Name = "grcolAssigneeName";
            this.grcolAssigneeName.Visible = true;
            this.grcolAssigneeName.VisibleIndex = 3;
            // 
            // grcolReporterName
            // 
            this.grcolReporterName.Caption = "Reporter";
            this.grcolReporterName.FieldName = "ReporterName";
            this.grcolReporterName.Name = "grcolReporterName";
            this.grcolReporterName.Visible = true;
            this.grcolReporterName.VisibleIndex = 4;
            // 
            // grcolPriority
            // 
            this.grcolPriority.Caption = "Priority";
            this.grcolPriority.FieldName = "Priority";
            this.grcolPriority.Name = "grcolPriority";
            this.grcolPriority.Visible = true;
            this.grcolPriority.VisibleIndex = 5;
            // 
            // grcolTaskType
            // 
            this.grcolTaskType.Caption = "TaskType";
            this.grcolTaskType.FieldName = "TaskType";
            this.grcolTaskType.Name = "grcolTaskType";
            this.grcolTaskType.Visible = true;
            this.grcolTaskType.VisibleIndex = 6;
            // 
            // grcolDescription
            // 
            this.grcolDescription.Caption = "Description";
            this.grcolDescription.FieldName = "Description";
            this.grcolDescription.Name = "grcolDescription";
            this.grcolDescription.Visible = true;
            this.grcolDescription.VisibleIndex = 7;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddTask.Location = new System.Drawing.Point(19, 400);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(174, 38);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "ADD";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDUTask
            // 
            this.btnDUTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDUTask.Location = new System.Drawing.Point(218, 400);
            this.btnDUTask.Name = "btnDUTask";
            this.btnDUTask.Size = new System.Drawing.Size(174, 38);
            this.btnDUTask.TabIndex = 1;
            this.btnDUTask.Text = "DETAILED/UPDATE";
            this.btnDUTask.UseVisualStyleBackColor = true;
            this.btnDUTask.Click += new System.EventHandler(this.btnDUTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteTask.Location = new System.Drawing.Point(425, 400);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(174, 38);
            this.btnDeleteTask.TabIndex = 1;
            this.btnDeleteTask.Text = "DELETE";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(614, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TaskManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnDUTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.grcTask);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskManagementForm";
            this.Text = "Task Management Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TaskManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcTask;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDUTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraGrid.Columns.GridColumn grcolID;
        private DevExpress.XtraGrid.Columns.GridColumn grcolTaskCode;
        private DevExpress.XtraGrid.Columns.GridColumn grcolTaskName;
        private DevExpress.XtraGrid.Columns.GridColumn grcolStatus;
        private DevExpress.XtraGrid.Columns.GridColumn grcolAssigneeName;
        private DevExpress.XtraGrid.Columns.GridColumn grcolReporterName;
        private DevExpress.XtraGrid.Columns.GridColumn grcolPriority;
        private DevExpress.XtraGrid.Columns.GridColumn grcolTaskType;
        private DevExpress.XtraGrid.Columns.GridColumn grcolDescription;
    }
}

