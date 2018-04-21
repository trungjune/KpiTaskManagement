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
            this.grcolTaskName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcolStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // grcTask
            // 
            this.grcTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcTask.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grcTask.Location = new System.Drawing.Point(2, 0);
            this.grcTask.MainView = this.grvTask;
            this.grcTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grcTask.Name = "grcTask";
            this.grcTask.Size = new System.Drawing.Size(1198, 600);
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
            this.gridColumn1,
            this.gridColumn2});
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
            // grcolTaskName
            // 
            this.grcolTaskName.Caption = "Task Name";
            this.grcolTaskName.FieldName = "TaskName";
            this.grcolTaskName.Name = "grcolTaskName";
            this.grcolTaskName.Visible = true;
            this.grcolTaskName.VisibleIndex = 1;
            // 
            // grcolStatus
            // 
            this.grcolStatus.Caption = "Status";
            this.grcolStatus.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grcolStatus.FieldName = "Status";
            this.grcolStatus.Name = "grcolStatus";
            this.grcolStatus.Visible = true;
            this.grcolStatus.VisibleIndex = 2;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddTask.Location = new System.Drawing.Point(29, 615);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(261, 58);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "ADD";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(327, 615);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 58);
            this.button3.TabIndex = 1;
            this.button3.Text = "DETAILED/UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(638, 615);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(261, 58);
            this.button4.TabIndex = 1;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.Location = new System.Drawing.Point(921, 615);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 58);
            this.button5.TabIndex = 1;
            this.button5.Text = "EXIT";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "AssigneeName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "ReporterName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // TaskManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.grcTask);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraGrid.Columns.GridColumn grcolID;
        private DevExpress.XtraGrid.Columns.GridColumn grcolTaskCode;
        private DevExpress.XtraGrid.Columns.GridColumn grcolTaskName;
        private DevExpress.XtraGrid.Columns.GridColumn grcolStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}

