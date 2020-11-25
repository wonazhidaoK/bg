namespace bg.UserControls
{
    partial class Uc_CentralFeeder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCF = new System.Windows.Forms.DataGridView();
            this.dtSchooltime = new System.Windows.Forms.DateTimePicker();
            this.lbSchooltime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCF)).BeginInit();
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
            // dgvCF
            // 
            this.dgvCF.AllowUserToAddRows = false;
            this.dgvCF.AllowUserToDeleteRows = false;
            this.dgvCF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCF.Location = new System.Drawing.Point(0, 116);
            this.dgvCF.Name = "dgvCF";
            this.dgvCF.ReadOnly = true;
            this.dgvCF.RowTemplate.Height = 23;
            this.dgvCF.Size = new System.Drawing.Size(696, 418);
            this.dgvCF.TabIndex = 3;
            // 
            // dtSchooltime
            // 
            this.dtSchooltime.CustomFormat = "yyyy-MM";
            this.dtSchooltime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSchooltime.Location = new System.Drawing.Point(83, 73);
            this.dtSchooltime.Name = "dtSchooltime";
            this.dtSchooltime.ShowUpDown = true;
            this.dtSchooltime.Size = new System.Drawing.Size(200, 21);
            this.dtSchooltime.TabIndex = 13;
            this.dtSchooltime.ValueChanged += new System.EventHandler(this.dtSchooltime_ValueChanged);
            // 
            // lbSchooltime
            // 
            this.lbSchooltime.AutoSize = true;
            this.lbSchooltime.Location = new System.Drawing.Point(12, 79);
            this.lbSchooltime.Name = "lbSchooltime";
            this.lbSchooltime.Size = new System.Drawing.Size(65, 12);
            this.lbSchooltime.TabIndex = 12;
            this.lbSchooltime.Text = "Schooltime";
            // 
            // Uc_CentralFeeder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dtSchooltime);
            this.Controls.Add(this.lbSchooltime);
            this.Controls.Add(this.dgvCF);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_CentralFeeder";
            this.Size = new System.Drawing.Size(696, 534);
            this.Load += new System.EventHandler(this.Uc_CentralFeeder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCF;
        private System.Windows.Forms.DateTimePicker dtSchooltime;
        private System.Windows.Forms.Label lbSchooltime;
    }
}
