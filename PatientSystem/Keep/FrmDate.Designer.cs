
namespace PatientSystem.Keep
{
    partial class FrmDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDate));
            this.TblRegister = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNext = new System.Windows.Forms.Button();
            this.PtbDate = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblPatient = new System.Windows.Forms.Label();
            this.LblDoctor = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblHour = new System.Windows.Forms.Label();
            this.LblReason = new System.Windows.Forms.Label();
            this.TxbPatient = new System.Windows.Forms.TextBox();
            this.TxbDoctorName = new System.Windows.Forms.TextBox();
            this.MtbDate = new System.Windows.Forms.MaskedTextBox();
            this.MtbHour = new System.Windows.Forms.MaskedTextBox();
            this.TxbReason = new System.Windows.Forms.TextBox();
            this.TblRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbDate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblRegister
            // 
            this.TblRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TblRegister.ColumnCount = 3;
            this.TblRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70596F));
            this.TblRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58862F));
            this.TblRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70542F));
            this.TblRegister.Controls.Add(this.BtnNext, 1, 2);
            this.TblRegister.Controls.Add(this.PtbDate, 1, 0);
            this.TblRegister.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.TblRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblRegister.Location = new System.Drawing.Point(0, 0);
            this.TblRegister.Name = "TblRegister";
            this.TblRegister.RowCount = 3;
            this.TblRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.53846F));
            this.TblRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.19231F));
            this.TblRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.269231F));
            this.TblRegister.Size = new System.Drawing.Size(486, 449);
            this.TblRegister.TabIndex = 4;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNext.Location = new System.Drawing.Point(74, 414);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(337, 32);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = "Create Appointment";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // PtbDate
            // 
            this.PtbDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PtbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbDate.Image = ((System.Drawing.Image)(resources.GetObject("PtbDate.Image")));
            this.PtbDate.Location = new System.Drawing.Point(74, 3);
            this.PtbDate.Name = "PtbDate";
            this.PtbDate.Size = new System.Drawing.Size(337, 158);
            this.PtbDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbDate.TabIndex = 0;
            this.PtbDate.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblPatient, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblDoctor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblHour, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblReason, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxbPatient, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxbDoctorName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MtbDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MtbHour, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxbReason, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 241);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblPatient
            // 
            this.LblPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPatient.AutoSize = true;
            this.LblPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPatient.Location = new System.Drawing.Point(111, 0);
            this.LblPatient.Name = "LblPatient";
            this.LblPatient.Size = new System.Drawing.Size(54, 17);
            this.LblPatient.TabIndex = 0;
            this.LblPatient.Text = "Patient:";
            // 
            // LblDoctor
            // 
            this.LblDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDoctor.AutoSize = true;
            this.LblDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDoctor.Location = new System.Drawing.Point(112, 48);
            this.LblDoctor.Name = "LblDoctor";
            this.LblDoctor.Size = new System.Drawing.Size(53, 17);
            this.LblDoctor.TabIndex = 1;
            this.LblDoctor.Text = "Doctor:";
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDate.Location = new System.Drawing.Point(126, 96);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(39, 17);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Date:";
            // 
            // LblHour
            // 
            this.LblHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHour.AutoSize = true;
            this.LblHour.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHour.Location = new System.Drawing.Point(122, 144);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(43, 17);
            this.LblHour.TabIndex = 3;
            this.LblHour.Text = "Hour:";
            // 
            // LblReason
            // 
            this.LblReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblReason.AutoSize = true;
            this.LblReason.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblReason.Location = new System.Drawing.Point(110, 192);
            this.LblReason.Name = "LblReason";
            this.LblReason.Size = new System.Drawing.Size(55, 17);
            this.LblReason.TabIndex = 4;
            this.LblReason.Text = "Reason:";
            // 
            // TxbPatient
            // 
            this.TxbPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbPatient.Location = new System.Drawing.Point(171, 3);
            this.TxbPatient.Name = "TxbPatient";
            this.TxbPatient.ReadOnly = true;
            this.TxbPatient.Size = new System.Drawing.Size(163, 23);
            this.TxbPatient.TabIndex = 5;
            // 
            // TxbDoctorName
            // 
            this.TxbDoctorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbDoctorName.Location = new System.Drawing.Point(171, 51);
            this.TxbDoctorName.Name = "TxbDoctorName";
            this.TxbDoctorName.ReadOnly = true;
            this.TxbDoctorName.Size = new System.Drawing.Size(163, 23);
            this.TxbDoctorName.TabIndex = 6;
            // 
            // MtbDate
            // 
            this.MtbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtbDate.Location = new System.Drawing.Point(171, 99);
            this.MtbDate.Mask = "00/00/0000";
            this.MtbDate.Name = "MtbDate";
            this.MtbDate.Size = new System.Drawing.Size(163, 23);
            this.MtbDate.TabIndex = 7;
            this.MtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // MtbHour
            // 
            this.MtbHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtbHour.Location = new System.Drawing.Point(171, 147);
            this.MtbHour.Mask = "00:00";
            this.MtbHour.Name = "MtbHour";
            this.MtbHour.Size = new System.Drawing.Size(163, 23);
            this.MtbHour.TabIndex = 8;
            this.MtbHour.ValidatingType = typeof(System.DateTime);
            // 
            // TxbReason
            // 
            this.TxbReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbReason.Location = new System.Drawing.Point(171, 195);
            this.TxbReason.Name = "TxbReason";
            this.TxbReason.Size = new System.Drawing.Size(163, 23);
            this.TxbReason.TabIndex = 9;
            // 
            // FrmDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 449);
            this.Controls.Add(this.TblRegister);
            this.Name = "FrmDate";
            this.Text = "Date";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDate_FormClosed);
            this.Load += new System.EventHandler(this.FrmDate_Load);
            this.TblRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbDate)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblRegister;
        private System.Windows.Forms.PictureBox PtbDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblPatient;
        private System.Windows.Forms.Label LblDoctor;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.Label LblReason;
        private System.Windows.Forms.TextBox TxbPatient;
        private System.Windows.Forms.TextBox TxbDoctorName;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.MaskedTextBox MtbDate;
        private System.Windows.Forms.MaskedTextBox MtbHour;
        private System.Windows.Forms.TextBox TxbReason;
    }
}