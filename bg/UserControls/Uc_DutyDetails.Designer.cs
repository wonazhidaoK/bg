
namespace bg.UserControls
{
    partial class Uc_DutyDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsaveupdate = new System.Windows.Forms.Button();
            this.tbDuty = new System.Windows.Forms.TextBox();
            this.lbDuty = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbCostCentre = new System.Windows.Forms.Label();
            this.cbCostCentre = new System.Windows.Forms.ComboBox();
            this.costCentreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbStaffNo = new System.Windows.Forms.Label();
            this.cbStaffNo = new System.Windows.Forms.ComboBox();
            this.tASStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASDutyBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costCentreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASStaffBindingSource)).BeginInit();
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
            this.btnupdate.Text = "Update Details";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDuty);
            this.panel2.Controls.Add(this.groupBox1);
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
            this.dgvDuty.Location = new System.Drawing.Point(3, 208);
            this.dgvDuty.Name = "dgvDuty";
            this.dgvDuty.ReadOnly = true;
            this.dgvDuty.RowTemplate.Height = 23;
            this.dgvDuty.Size = new System.Drawing.Size(690, 264);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsaveupdate);
            this.groupBox1.Controls.Add(this.tbDuty);
            this.groupBox1.Controls.Add(this.lbDuty);
            this.groupBox1.Controls.Add(this.tbHours);
            this.groupBox1.Controls.Add(this.lbHours);
            this.groupBox1.Controls.Add(this.lbCostCentre);
            this.groupBox1.Controls.Add(this.cbCostCentre);
            this.groupBox1.Controls.Add(this.lbStaffNo);
            this.groupBox1.Controls.Add(this.cbStaffNo);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duty Details";
            // 
            // btnsaveupdate
            // 
            this.btnsaveupdate.Location = new System.Drawing.Point(510, 130);
            this.btnsaveupdate.Name = "btnsaveupdate";
            this.btnsaveupdate.Size = new System.Drawing.Size(133, 44);
            this.btnsaveupdate.TabIndex = 9;
            this.btnsaveupdate.Text = "Save";
            this.btnsaveupdate.UseVisualStyleBackColor = true;
            this.btnsaveupdate.Click += new System.EventHandler(this.btnsaveupdate_Click);
            // 
            // tbDuty
            // 
            this.tbDuty.Location = new System.Drawing.Point(77, 60);
            this.tbDuty.Multiline = true;
            this.tbDuty.Name = "tbDuty";
            this.tbDuty.Size = new System.Drawing.Size(566, 56);
            this.tbDuty.TabIndex = 8;
            // 
            // lbDuty
            // 
            this.lbDuty.AutoSize = true;
            this.lbDuty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbDuty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbDuty.Location = new System.Drawing.Point(25, 48);
            this.lbDuty.Name = "lbDuty";
            this.lbDuty.Size = new System.Drawing.Size(43, 19);
            this.lbDuty.TabIndex = 7;
            this.lbDuty.Text = "Duty";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(518, 25);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(125, 21);
            this.tbHours.TabIndex = 6;
            this.tbHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHours_KeyPress);
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbHours.Location = new System.Drawing.Point(452, 26);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(51, 19);
            this.lbHours.TabIndex = 5;
            this.lbHours.Text = "Hours";
            // 
            // lbCostCentre
            // 
            this.lbCostCentre.AutoSize = true;
            this.lbCostCentre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbCostCentre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbCostCentre.Location = new System.Drawing.Point(210, 26);
            this.lbCostCentre.Name = "lbCostCentre";
            this.lbCostCentre.Size = new System.Drawing.Size(92, 19);
            this.lbCostCentre.TabIndex = 3;
            this.lbCostCentre.Text = "CostCentre";
            // 
            // cbCostCentre
            // 
            this.cbCostCentre.DataSource = this.costCentreBindingSource;
            this.cbCostCentre.DisplayMember = "Name";
            this.cbCostCentre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostCentre.FormattingEnabled = true;
            this.cbCostCentre.Location = new System.Drawing.Point(317, 25);
            this.cbCostCentre.Name = "cbCostCentre";
            this.cbCostCentre.Size = new System.Drawing.Size(118, 20);
            this.cbCostCentre.TabIndex = 2;
            this.cbCostCentre.ValueMember = "Value";
            // 
            // costCentreBindingSource
            // 
            this.costCentreBindingSource.DataSource = typeof(CommonHelp.Models.Cost_Centre);
            // 
            // lbStaffNo
            // 
            this.lbStaffNo.AutoSize = true;
            this.lbStaffNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbStaffNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbStaffNo.Location = new System.Drawing.Point(6, 23);
            this.lbStaffNo.Name = "lbStaffNo";
            this.lbStaffNo.Size = new System.Drawing.Size(62, 19);
            this.lbStaffNo.TabIndex = 1;
            this.lbStaffNo.Text = "StaffNo";
            // 
            // cbStaffNo
            // 
            this.cbStaffNo.DataSource = this.tASStaffBindingSource;
            this.cbStaffNo.DisplayMember = "No";
            this.cbStaffNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffNo.FormattingEnabled = true;
            this.cbStaffNo.Location = new System.Drawing.Point(74, 25);
            this.cbStaffNo.Name = "cbStaffNo";
            this.cbStaffNo.Size = new System.Drawing.Size(130, 20);
            this.cbStaffNo.TabIndex = 0;
            this.cbStaffNo.ValueMember = "No";
            // 
            // tASStaffBindingSource
            // 
            this.tASStaffBindingSource.DataSource = typeof(CommonHelp.Models.TAS_Staff);
            // 
            // Uc_DutyDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_DutyDetails";
            this.Size = new System.Drawing.Size(696, 534);
            this.Load += new System.EventHandler(this.UcDutyDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASDutyBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costCentreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASStaffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDuty;
        private System.Windows.Forms.TextBox tbDuty;
        private System.Windows.Forms.Label lbDuty;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbCostCentre;
        private System.Windows.Forms.ComboBox cbCostCentre;
        private System.Windows.Forms.Label lbStaffNo;
        private System.Windows.Forms.ComboBox cbStaffNo;
        private System.Windows.Forms.Button btnsaveupdate;
        private System.Windows.Forms.BindingSource costCentreBindingSource;
        private System.Windows.Forms.BindingSource tASStaffBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tASDutyBindingSource;
    }
}
