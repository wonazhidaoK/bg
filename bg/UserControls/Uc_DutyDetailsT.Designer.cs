
namespace bg.UserControls
{
    partial class Uc_DutyDetailsT
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDuty = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASDutyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASDutyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 59);
            this.panel1.TabIndex = 1;
            // 
            // btnupdate
            // 
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(0, 0);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(145, 57);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "Details";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDuty);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 475);
            this.panel2.TabIndex = 2;
            // 
            // dgvDuty
            // 
            this.dgvDuty.AllowUserToAddRows = false;
            this.dgvDuty.AllowUserToDeleteRows = false;
            this.dgvDuty.AutoGenerateColumns = false;
            this.dgvDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.staffNoDataGridViewTextBoxColumn,
            this.costCentreDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.dutyDataGridViewTextBoxColumn});
            this.dgvDuty.DataSource = this.tASDutyBindingSource;
            this.dgvDuty.Location = new System.Drawing.Point(3, 6);
            this.dgvDuty.Name = "dgvDuty";
            this.dgvDuty.ReadOnly = true;
            this.dgvDuty.RowTemplate.Height = 23;
            this.dgvDuty.Size = new System.Drawing.Size(690, 466);
            this.dgvDuty.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffNoDataGridViewTextBoxColumn
            // 
            this.staffNoDataGridViewTextBoxColumn.DataPropertyName = "StaffNo";
            this.staffNoDataGridViewTextBoxColumn.HeaderText = "StaffNo";
            this.staffNoDataGridViewTextBoxColumn.Name = "staffNoDataGridViewTextBoxColumn";
            this.staffNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costCentreDataGridViewTextBoxColumn
            // 
            this.costCentreDataGridViewTextBoxColumn.DataPropertyName = "CostCentre";
            this.costCentreDataGridViewTextBoxColumn.HeaderText = "CostCentre";
            this.costCentreDataGridViewTextBoxColumn.Name = "costCentreDataGridViewTextBoxColumn";
            this.costCentreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dutyDataGridViewTextBoxColumn
            // 
            this.dutyDataGridViewTextBoxColumn.DataPropertyName = "Duty";
            this.dutyDataGridViewTextBoxColumn.HeaderText = "Duty";
            this.dutyDataGridViewTextBoxColumn.Name = "dutyDataGridViewTextBoxColumn";
            this.dutyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tASDutyBindingSource
            // 
            this.tASDutyBindingSource.DataSource = typeof(CommonHelp.Models.TAS_Duty);
            // 
            // Uc_DutyDetailsT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_DutyDetailsT";
            this.Size = new System.Drawing.Size(696, 534);
            this.Load += new System.EventHandler(this.UcDutyDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASDutyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tASDutyBindingSource;
    }
}
