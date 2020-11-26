namespace bg.UserControls
{
    partial class Uc_DeptFeeder
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbDept = new System.Windows.Forms.Label();
            this.lbSchooltime = new System.Windows.Forms.Label();
            this.dtSchooltime = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 59);
            this.panel1.TabIndex = 2;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(3, 113);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.Size = new System.Drawing.Size(690, 370);
            this.DataGridView1.TabIndex = 4;
            this.DataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridView1_CurrentCellDirtyStateChanged);
            this.DataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            this.DataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowValidated);
            // 
            // cbDept
            // 
            this.cbDept.DataSource = this.deptBindingSource;
            this.cbDept.DisplayMember = "Name";
            this.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(71, 78);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(121, 20);
            this.cbDept.TabIndex = 5;
            this.cbDept.ValueMember = "Value";
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataSource = typeof(CommonHelp.Models.Dept);
            // 
            // lbDept
            // 
            this.lbDept.AutoSize = true;
            this.lbDept.Location = new System.Drawing.Point(22, 81);
            this.lbDept.Name = "lbDept";
            this.lbDept.Size = new System.Drawing.Size(29, 12);
            this.lbDept.TabIndex = 6;
            this.lbDept.Text = "Dept";
            // 
            // lbSchooltime
            // 
            this.lbSchooltime.AutoSize = true;
            this.lbSchooltime.Location = new System.Drawing.Point(242, 81);
            this.lbSchooltime.Name = "lbSchooltime";
            this.lbSchooltime.Size = new System.Drawing.Size(65, 12);
            this.lbSchooltime.TabIndex = 7;
            this.lbSchooltime.Text = "Schooltime";
            // 
            // dtSchooltime
            // 
            this.dtSchooltime.Location = new System.Drawing.Point(314, 78);
            this.dtSchooltime.Name = "dtSchooltime";
            this.dtSchooltime.Size = new System.Drawing.Size(200, 21);
            this.dtSchooltime.TabIndex = 8;
            this.dtSchooltime.ValueChanged += new System.EventHandler(this.dtSchooltime_ValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(564, 73);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 29);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export All";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Uc_DeptFeeder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtSchooltime);
            this.Controls.Add(this.lbSchooltime);
            this.Controls.Add(this.lbDept);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_DeptFeeder";
            this.Size = new System.Drawing.Size(696, 534);
            this.Load += new System.EventHandler(this.Uc_DeptFeeder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Label lbDept;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private System.Windows.Forms.Label lbSchooltime;
        private System.Windows.Forms.DateTimePicker dtSchooltime;
        private System.Windows.Forms.Button btnExport;
    }
}
