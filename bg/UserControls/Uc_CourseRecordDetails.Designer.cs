namespace bg.UserControls
{
    partial class Uc_CourseRecordDetails
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
            this.dgCR = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schooltimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTGYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSAFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASCourseRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnsaveupdate = new System.Windows.Forms.Button();
            this.tbCTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCCode = new System.Windows.Forms.TextBox();
            this.UId = new System.Windows.Forms.Label();
            this.gbuser = new System.Windows.Forms.GroupBox();
            this.tbUNITC = new System.Windows.Forms.TextBox();
            this.tbITGY = new System.Windows.Forms.TextBox();
            this.tbMSAF = new System.Windows.Forms.TextBox();
            this.tbHQ = new System.Windows.Forms.TextBox();
            this.tbUNITA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSMG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUid = new System.Windows.Forms.ComboBox();
            this.tASUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUNITB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASCourseRecordBindingSource)).BeginInit();
            this.gbuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tASUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypeBindingSource)).BeginInit();
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
            // 
            // dgCR
            // 
            this.dgCR.AllowUserToAddRows = false;
            this.dgCR.AllowUserToDeleteRows = false;
            this.dgCR.AutoGenerateColumns = false;
            this.dgCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.courseCodeDataGridViewTextBoxColumn,
            this.courseTitleDataGridViewTextBoxColumn,
            this.deptDataGridViewTextBoxColumn,
            this.schooltimeDataGridViewTextBoxColumn,
            this.hQDataGridViewTextBoxColumn,
            this.uNITADataGridViewTextBoxColumn,
            this.uNITBDataGridViewTextBoxColumn,
            this.uNITCDataGridViewTextBoxColumn,
            this.iTGYDataGridViewTextBoxColumn,
            this.mSAFDataGridViewTextBoxColumn,
            this.sMGDataGridViewTextBoxColumn});
            this.dgCR.DataSource = this.tASCourseRecordBindingSource;
            this.dgCR.Location = new System.Drawing.Point(0, 285);
            this.dgCR.Name = "dgCR";
            this.dgCR.ReadOnly = true;
            this.dgCR.RowTemplate.Height = 23;
            this.dgCR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCR.Size = new System.Drawing.Size(696, 246);
            this.dgCR.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            this.courseCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseTitleDataGridViewTextBoxColumn
            // 
            this.courseTitleDataGridViewTextBoxColumn.DataPropertyName = "CourseTitle";
            this.courseTitleDataGridViewTextBoxColumn.HeaderText = "CourseTitle";
            this.courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
            this.courseTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "Dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "Dept";
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            this.deptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schooltimeDataGridViewTextBoxColumn
            // 
            this.schooltimeDataGridViewTextBoxColumn.DataPropertyName = "Schooltime";
            this.schooltimeDataGridViewTextBoxColumn.HeaderText = "Schooltime";
            this.schooltimeDataGridViewTextBoxColumn.Name = "schooltimeDataGridViewTextBoxColumn";
            this.schooltimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hQDataGridViewTextBoxColumn
            // 
            this.hQDataGridViewTextBoxColumn.DataPropertyName = "HQ";
            this.hQDataGridViewTextBoxColumn.HeaderText = "HQ";
            this.hQDataGridViewTextBoxColumn.Name = "hQDataGridViewTextBoxColumn";
            this.hQDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNITADataGridViewTextBoxColumn
            // 
            this.uNITADataGridViewTextBoxColumn.DataPropertyName = "UNITA";
            this.uNITADataGridViewTextBoxColumn.HeaderText = "UNITA";
            this.uNITADataGridViewTextBoxColumn.Name = "uNITADataGridViewTextBoxColumn";
            this.uNITADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNITBDataGridViewTextBoxColumn
            // 
            this.uNITBDataGridViewTextBoxColumn.DataPropertyName = "UNITB";
            this.uNITBDataGridViewTextBoxColumn.HeaderText = "UNITB";
            this.uNITBDataGridViewTextBoxColumn.Name = "uNITBDataGridViewTextBoxColumn";
            this.uNITBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNITCDataGridViewTextBoxColumn
            // 
            this.uNITCDataGridViewTextBoxColumn.DataPropertyName = "UNITC";
            this.uNITCDataGridViewTextBoxColumn.HeaderText = "UNITC";
            this.uNITCDataGridViewTextBoxColumn.Name = "uNITCDataGridViewTextBoxColumn";
            this.uNITCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTGYDataGridViewTextBoxColumn
            // 
            this.iTGYDataGridViewTextBoxColumn.DataPropertyName = "ITGY";
            this.iTGYDataGridViewTextBoxColumn.HeaderText = "ITGY";
            this.iTGYDataGridViewTextBoxColumn.Name = "iTGYDataGridViewTextBoxColumn";
            this.iTGYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mSAFDataGridViewTextBoxColumn
            // 
            this.mSAFDataGridViewTextBoxColumn.DataPropertyName = "MSAF";
            this.mSAFDataGridViewTextBoxColumn.HeaderText = "MSAF";
            this.mSAFDataGridViewTextBoxColumn.Name = "mSAFDataGridViewTextBoxColumn";
            this.mSAFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sMGDataGridViewTextBoxColumn
            // 
            this.sMGDataGridViewTextBoxColumn.DataPropertyName = "SMG";
            this.sMGDataGridViewTextBoxColumn.HeaderText = "SMG";
            this.sMGDataGridViewTextBoxColumn.Name = "sMGDataGridViewTextBoxColumn";
            this.sMGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tASCourseRecordBindingSource
            // 
            this.tASCourseRecordBindingSource.DataSource = typeof(CommonHelp.Models.TAS_CourseRecord);
            // 
            // btnsaveupdate
            // 
            this.btnsaveupdate.Location = new System.Drawing.Point(554, 235);
            this.btnsaveupdate.Name = "btnsaveupdate";
            this.btnsaveupdate.Size = new System.Drawing.Size(133, 44);
            this.btnsaveupdate.TabIndex = 30;
            this.btnsaveupdate.Text = "Save";
            this.btnsaveupdate.UseVisualStyleBackColor = true;
            this.btnsaveupdate.Click += new System.EventHandler(this.btnsaveupdate_Click);
            // 
            // tbCTitle
            // 
            this.tbCTitle.Location = new System.Drawing.Point(353, 20);
            this.tbCTitle.Name = "tbCTitle";
            this.tbCTitle.Size = new System.Drawing.Size(133, 21);
            this.tbCTitle.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(497, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Dept";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(256, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "CourseTitle";
            // 
            // tbCCode
            // 
            this.tbCCode.Location = new System.Drawing.Point(109, 21);
            this.tbCCode.Name = "tbCCode";
            this.tbCCode.Size = new System.Drawing.Size(126, 21);
            this.tbCCode.TabIndex = 36;
            // 
            // UId
            // 
            this.UId.AutoSize = true;
            this.UId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.UId.Location = new System.Drawing.Point(4, 21);
            this.UId.Name = "UId";
            this.UId.Size = new System.Drawing.Size(105, 19);
            this.UId.TabIndex = 35;
            this.UId.Text = "CourseCode";
            // 
            // gbuser
            // 
            this.gbuser.Controls.Add(this.tbUNITC);
            this.gbuser.Controls.Add(this.tbITGY);
            this.gbuser.Controls.Add(this.tbMSAF);
            this.gbuser.Controls.Add(this.tbHQ);
            this.gbuser.Controls.Add(this.tbUNITA);
            this.gbuser.Controls.Add(this.label13);
            this.gbuser.Controls.Add(this.tbSMG);
            this.gbuser.Controls.Add(this.label8);
            this.gbuser.Controls.Add(this.cbUid);
            this.gbuser.Controls.Add(this.label2);
            this.gbuser.Controls.Add(this.label9);
            this.gbuser.Controls.Add(this.label12);
            this.gbuser.Controls.Add(this.label11);
            this.gbuser.Controls.Add(this.tbUNITB);
            this.gbuser.Controls.Add(this.label10);
            this.gbuser.Controls.Add(this.label4);
            this.gbuser.Controls.Add(this.dtp1);
            this.gbuser.Controls.Add(this.label1);
            this.gbuser.Controls.Add(this.cbDept);
            this.gbuser.Controls.Add(this.UId);
            this.gbuser.Controls.Add(this.tbCCode);
            this.gbuser.Controls.Add(this.label3);
            this.gbuser.Controls.Add(this.label7);
            this.gbuser.Controls.Add(this.tbCTitle);
            this.gbuser.Location = new System.Drawing.Point(4, 66);
            this.gbuser.Name = "gbuser";
            this.gbuser.Size = new System.Drawing.Size(689, 163);
            this.gbuser.TabIndex = 37;
            this.gbuser.TabStop = false;
            this.gbuser.Text = "user details";
            // 
            // tbUNITC
            // 
            this.tbUNITC.Location = new System.Drawing.Point(109, 86);
            this.tbUNITC.Name = "tbUNITC";
            this.tbUNITC.Size = new System.Drawing.Size(126, 21);
            this.tbUNITC.TabIndex = 66;
            this.tbUNITC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUNITC_KeyPress);
            // 
            // tbITGY
            // 
            this.tbITGY.Location = new System.Drawing.Point(109, 120);
            this.tbITGY.Name = "tbITGY";
            this.tbITGY.Size = new System.Drawing.Size(126, 21);
            this.tbITGY.TabIndex = 65;
            this.tbITGY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbITGY_KeyPress);
            // 
            // tbMSAF
            // 
            this.tbMSAF.Location = new System.Drawing.Point(353, 117);
            this.tbMSAF.Name = "tbMSAF";
            this.tbMSAF.Size = new System.Drawing.Size(133, 21);
            this.tbMSAF.TabIndex = 64;
            this.tbMSAF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMSAF_KeyPress);
            // 
            // tbHQ
            // 
            this.tbHQ.Location = new System.Drawing.Point(353, 85);
            this.tbHQ.Name = "tbHQ";
            this.tbHQ.Size = new System.Drawing.Size(133, 21);
            this.tbHQ.TabIndex = 63;
            this.tbHQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHQ_KeyPress);
            // 
            // tbUNITA
            // 
            this.tbUNITA.Location = new System.Drawing.Point(550, 86);
            this.tbUNITA.Name = "tbUNITA";
            this.tbUNITA.Size = new System.Drawing.Size(133, 21);
            this.tbUNITA.TabIndex = 62;
            this.tbUNITA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUNITA_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label13.Location = new System.Drawing.Point(500, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 19);
            this.label13.TabIndex = 60;
            this.label13.Text = "SMG";
            // 
            // tbSMG
            // 
            this.tbSMG.Location = new System.Drawing.Point(550, 116);
            this.tbSMG.Name = "tbSMG";
            this.tbSMG.Size = new System.Drawing.Size(133, 21);
            this.tbSMG.TabIndex = 61;
            this.tbSMG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSMG_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(296, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = "MSAF";
            // 
            // cbUid
            // 
            this.cbUid.DataSource = this.tASUserBindingSource;
            this.cbUid.DisplayMember = "UId";
            this.cbUid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUid.FormattingEnabled = true;
            this.cbUid.Location = new System.Drawing.Point(353, 52);
            this.cbUid.Name = "cbUid";
            this.cbUid.Size = new System.Drawing.Size(133, 20);
            this.cbUid.TabIndex = 42;
            this.cbUid.ValueMember = "UId";
            // 
            // tASUserBindingSource
            // 
            this.tASUserBindingSource.DataSource = typeof(CommonHelp.Models.TAS_User);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(313, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "UId";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(62, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 56;
            this.label9.Text = "ITGY";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(52, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 54;
            this.label12.Text = "UNITC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(493, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 52;
            this.label11.Text = "UNITB";
            // 
            // tbUNITB
            // 
            this.tbUNITB.Location = new System.Drawing.Point(550, 50);
            this.tbUNITB.Name = "tbUNITB";
            this.tbUNITB.Size = new System.Drawing.Size(133, 21);
            this.tbUNITB.TabIndex = 53;
            this.tbUNITB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUNITB_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(490, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 50;
            this.label10.Text = "UNITA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(313, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "HQ";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(109, 55);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(126, 21);
            this.dtp1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Schooltime";
            // 
            // cbDept
            // 
            this.cbDept.DataSource = this.deptBindingSource;
            this.cbDept.DisplayMember = "Name";
            this.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(550, 17);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(133, 20);
            this.cbDept.TabIndex = 39;
            this.cbDept.ValueMember = "Value";
            // 
            // deptBindingSource
            // 
            this.deptBindingSource.DataSource = typeof(CommonHelp.Models.Dept);
            // 
            // courseTypeBindingSource
            // 
            this.courseTypeBindingSource.DataSource = typeof(CommonHelp.Models.CourseType);
            // 
            // Uc_CourseRecordDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnsaveupdate);
            this.Controls.Add(this.gbuser);
            this.Controls.Add(this.dgCR);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_CourseRecordDetails";
            this.Size = new System.Drawing.Size(696, 534);
            this.Load += new System.EventHandler(this.Uc_UpdateDetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASCourseRecordBindingSource)).EndInit();
            this.gbuser.ResumeLayout(false);
            this.gbuser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tASUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dgCR;
        private System.Windows.Forms.Button btnsaveupdate;
        private System.Windows.Forms.TextBox tbCTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCCode;
        private System.Windows.Forms.Label UId;
        private System.Windows.Forms.GroupBox gbuser;
        private System.Windows.Forms.BindingSource courseTypeBindingSource;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUid;
        private System.Windows.Forms.BindingSource tASUserBindingSource;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSMG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUNITB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUNITC;
        private System.Windows.Forms.TextBox tbITGY;
        private System.Windows.Forms.TextBox tbMSAF;
        private System.Windows.Forms.TextBox tbHQ;
        private System.Windows.Forms.TextBox tbUNITA;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schooltimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTGYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSAFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMGDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tASCourseRecordBindingSource;
    }
}
