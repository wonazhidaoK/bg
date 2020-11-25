namespace bg.UserControls
{
    partial class Uc_TASUserDetails
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
            this.dgvU = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsaveupdate = new System.Windows.Forms.Button();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbSNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.UId = new System.Windows.Forms.Label();
            this.gbuser = new System.Windows.Forms.GroupBox();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbType = new System.Windows.Forms.ComboBox();
            this.teachertypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCCentre = new System.Windows.Forms.ComboBox();
            this.costCentreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQS = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASUserBindingSource)).BeginInit();
            this.gbuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachertypeBindingSource)).BeginInit();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentreBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dgvU
            // 
            this.dgvU.AllowUserToAddRows = false;
            this.dgvU.AllowUserToDeleteRows = false;
            this.dgvU.AutoGenerateColumns = false;
            this.dgvU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.uIdDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.staffNoDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgvU.DataSource = this.tASUserBindingSource;
            this.dgvU.Location = new System.Drawing.Point(0, 342);
            this.dgvU.Name = "dgvU";
            this.dgvU.ReadOnly = true;
            this.dgvU.RowTemplate.Height = 23;
            this.dgvU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvU.Size = new System.Drawing.Size(696, 189);
            this.dgvU.TabIndex = 1;
            this.dgvU.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvU_CellMouseUp);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uIdDataGridViewTextBoxColumn
            // 
            this.uIdDataGridViewTextBoxColumn.DataPropertyName = "UId";
            this.uIdDataGridViewTextBoxColumn.HeaderText = "UId";
            this.uIdDataGridViewTextBoxColumn.Name = "uIdDataGridViewTextBoxColumn";
            this.uIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffNoDataGridViewTextBoxColumn
            // 
            this.staffNoDataGridViewTextBoxColumn.DataPropertyName = "StaffNo";
            this.staffNoDataGridViewTextBoxColumn.HeaderText = "StaffNo";
            this.staffNoDataGridViewTextBoxColumn.Name = "staffNoDataGridViewTextBoxColumn";
            this.staffNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tASUserBindingSource
            // 
            this.tASUserBindingSource.DataSource = typeof(CommonHelp.Models.TAS_User);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(61, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(34, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(292, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Dept";
            // 
            // btnsaveupdate
            // 
            this.btnsaveupdate.Location = new System.Drawing.Point(560, 292);
            this.btnsaveupdate.Name = "btnsaveupdate";
            this.btnsaveupdate.Size = new System.Drawing.Size(133, 44);
            this.btnsaveupdate.TabIndex = 30;
            this.btnsaveupdate.Text = "Save";
            this.btnsaveupdate.UseVisualStyleBackColor = true;
            this.btnsaveupdate.Click += new System.EventHandler(this.btnsaveupdate_Click);
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(337, 18);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(133, 21);
            this.tbFname.TabIndex = 28;
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(572, 16);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(111, 21);
            this.tbLname.TabIndex = 27;
            // 
            // tbSNo
            // 
            this.tbSNo.Location = new System.Drawing.Point(109, 18);
            this.tbSNo.Name = "tbSNo";
            this.tbSNo.Size = new System.Drawing.Size(126, 21);
            this.tbSNo.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(241, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Cost Centre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(285, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(476, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(242, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(34, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Staff No.";
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(109, 21);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(126, 21);
            this.tbSName.TabIndex = 36;
            // 
            // UId
            // 
            this.UId.AutoSize = true;
            this.UId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.UId.Location = new System.Drawing.Point(4, 21);
            this.UId.Name = "UId";
            this.UId.Size = new System.Drawing.Size(99, 19);
            this.UId.TabIndex = 35;
            this.UId.Text = "Short Name";
            // 
            // gbuser
            // 
            this.gbuser.Controls.Add(this.cbTitle);
            this.gbuser.Controls.Add(this.cbType);
            this.gbuser.Controls.Add(this.UId);
            this.gbuser.Controls.Add(this.tbSName);
            this.gbuser.Controls.Add(this.label5);
            this.gbuser.Controls.Add(this.label3);
            this.gbuser.Controls.Add(this.label6);
            this.gbuser.Controls.Add(this.label7);
            this.gbuser.Controls.Add(this.tbLname);
            this.gbuser.Controls.Add(this.tbFname);
            this.gbuser.Location = new System.Drawing.Point(4, 118);
            this.gbuser.Name = "gbuser";
            this.gbuser.Size = new System.Drawing.Size(689, 86);
            this.gbuser.TabIndex = 37;
            this.gbuser.TabStop = false;
            this.gbuser.Text = "user details";
            // 
            // cbTitle
            // 
            this.cbTitle.DataSource = this.titleBindingSource;
            this.cbTitle.DisplayMember = "Name";
            this.cbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(109, 49);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(126, 20);
            this.cbTitle.TabIndex = 38;
            this.cbTitle.ValueMember = "Value";
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataSource = typeof(CommonHelp.Models.Title);
            // 
            // cbType
            // 
            this.cbType.DataSource = this.teachertypeBindingSource;
            this.cbType.DisplayMember = "Name";
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(337, 48);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(133, 20);
            this.cbType.TabIndex = 37;
            this.cbType.ValueMember = "Value";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // teachertypeBindingSource
            // 
            this.teachertypeBindingSource.DataSource = typeof(CommonHelp.Models.Teacher_type);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.cbDept);
            this.gb1.Controls.Add(this.cbRole);
            this.gb1.Controls.Add(this.cbCCentre);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.tbSNo);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label9);
            this.gb1.Controls.Add(this.label8);
            this.gb1.Location = new System.Drawing.Point(3, 210);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(689, 76);
            this.gb1.TabIndex = 38;
            this.gb1.TabStop = false;
            this.gb1.Text = "staff details";
            this.gb1.Visible = false;
            // 
            // cbDept
            // 
            this.cbDept.DataSource = this.deptBindingSource;
            this.cbDept.DisplayMember = "Name";
            this.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(337, 43);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(133, 20);
            this.cbDept.TabIndex = 35;
            this.cbDept.ValueMember = "Value";
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataSource = typeof(CommonHelp.Models.Dept);
            // 
            // cbRole
            // 
            this.cbRole.DataSource = this.roleBindingSource;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(109, 44);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(125, 20);
            this.cbRole.TabIndex = 34;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(CommonHelp.Models.Role);
            // 
            // cbCCentre
            // 
            this.cbCCentre.DataSource = this.costCentreBindingSource;
            this.cbCCentre.DisplayMember = "Name";
            this.cbCCentre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCCentre.FormattingEnabled = true;
            this.cbCCentre.Location = new System.Drawing.Point(337, 18);
            this.cbCCentre.Name = "cbCCentre";
            this.cbCCentre.Size = new System.Drawing.Size(133, 20);
            this.cbCCentre.TabIndex = 33;
            this.cbCCentre.ValueMember = "Value";
            // 
            // costCentreBindingSource
            // 
            this.costCentreBindingSource.DataSource = typeof(CommonHelp.Models.Cost_Centre);
            // 
            // txtQS
            // 
            this.txtQS.Location = new System.Drawing.Point(112, 81);
            this.txtQS.Name = "txtQS";
            this.txtQS.Size = new System.Drawing.Size(126, 21);
            this.txtQS.TabIndex = 39;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(248, 68);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(133, 44);
            this.btnQuery.TabIndex = 40;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Full Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "删除";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Uc_TASUserDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtQS);
            this.Controls.Add(this.btnsaveupdate);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.gbuser);
            this.Controls.Add(this.dgvU);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_TASUserDetails";
            this.Size = new System.Drawing.Size(696, 534);
            this.Load += new System.EventHandler(this.Uc_UpdateDetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASUserBindingSource)).EndInit();
            this.gbuser.ResumeLayout(false);
            this.gbuser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachertypeBindingSource)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCentreBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dgvU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsaveupdate;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbSNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label UId;
        private System.Windows.Forms.GroupBox gbuser;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.BindingSource titleBindingSource;
        private System.Windows.Forms.ComboBox cbCCentre;
        private System.Windows.Forms.BindingSource costCentreBindingSource;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource teachertypeBindingSource;
        private System.Windows.Forms.BindingSource tASUserBindingSource;
        private System.Windows.Forms.TextBox txtQS;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
