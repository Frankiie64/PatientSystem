
namespace PatientSystem.Home
{
    partial class FrmHome
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnMedical = new System.Windows.Forms.Button();
            this.BtnTestLab = new System.Windows.Forms.Button();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnKeep = new System.Windows.Forms.Button();
            this.BtnTestResult = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.7572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.63374F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60905F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.85149F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.14851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 842);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.78025F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.4442F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.77555F));
            this.tableLayoutPanel2.Controls.Add(this.BtnUser, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnMedical, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnTestLab, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnPatient, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnKeep, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnTestResult, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(92, 298);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80328F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.98361F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80328F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80328F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80328F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(496, 539);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.Color.Honeydew;
            this.BtnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUser.FlatAppearance.BorderSize = 0;
            this.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUser.Location = new System.Drawing.Point(131, 5);
            this.BtnUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(232, 79);
            this.BtnUser.TabIndex = 0;
            this.BtnUser.Text = "User maintenance";
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnMedical
            // 
            this.BtnMedical.BackColor = System.Drawing.Color.Honeydew;
            this.BtnMedical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMedical.FlatAppearance.BorderSize = 0;
            this.BtnMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedical.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMedical.Location = new System.Drawing.Point(131, 94);
            this.BtnMedical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMedical.Name = "BtnMedical";
            this.BtnMedical.Size = new System.Drawing.Size(232, 80);
            this.BtnMedical.TabIndex = 1;
            this.BtnMedical.Text = "Medical maintenance";
            this.BtnMedical.UseVisualStyleBackColor = false;
            this.BtnMedical.Click += new System.EventHandler(this.BtnMedical_Click);
            // 
            // BtnTestLab
            // 
            this.BtnTestLab.BackColor = System.Drawing.Color.Honeydew;
            this.BtnTestLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTestLab.FlatAppearance.BorderSize = 0;
            this.BtnTestLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTestLab.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTestLab.Location = new System.Drawing.Point(131, 184);
            this.BtnTestLab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTestLab.Name = "BtnTestLab";
            this.BtnTestLab.Size = new System.Drawing.Size(232, 76);
            this.BtnTestLab.TabIndex = 2;
            this.BtnTestLab.Text = "Laboratory Test maintenance";
            this.BtnTestLab.UseVisualStyleBackColor = false;
            this.BtnTestLab.Click += new System.EventHandler(this.BtnTestLab_Click);
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackColor = System.Drawing.Color.Honeydew;
            this.BtnPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPatient.FlatAppearance.BorderSize = 0;
            this.BtnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPatient.Location = new System.Drawing.Point(131, 270);
            this.BtnPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(232, 80);
            this.BtnPatient.TabIndex = 3;
            this.BtnPatient.Text = "Patient maintenance";
            this.BtnPatient.UseVisualStyleBackColor = false;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // BtnKeep
            // 
            this.BtnKeep.BackColor = System.Drawing.Color.Honeydew;
            this.BtnKeep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnKeep.FlatAppearance.BorderSize = 0;
            this.BtnKeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKeep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnKeep.Location = new System.Drawing.Point(131, 360);
            this.BtnKeep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnKeep.Name = "BtnKeep";
            this.BtnKeep.Size = new System.Drawing.Size(232, 80);
            this.BtnKeep.TabIndex = 4;
            this.BtnKeep.Text = "Keeping maintenance";
            this.BtnKeep.UseVisualStyleBackColor = false;
            this.BtnKeep.Click += new System.EventHandler(this.BtnKeep_Click);
            // 
            // BtnTestResult
            // 
            this.BtnTestResult.BackColor = System.Drawing.Color.Honeydew;
            this.BtnTestResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTestResult.FlatAppearance.BorderSize = 0;
            this.BtnTestResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTestResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTestResult.Location = new System.Drawing.Point(131, 450);
            this.BtnTestResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTestResult.Name = "BtnTestResult";
            this.BtnTestResult.Size = new System.Drawing.Size(232, 84);
            this.BtnTestResult.TabIndex = 5;
            this.BtnTestResult.Text = "Maintaining laboratory test results";
            this.BtnTestResult.UseVisualStyleBackColor = false;
            this.BtnTestResult.Click += new System.EventHandler(this.BtnTestResult_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 842);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnMedical;
        private System.Windows.Forms.Button BtnTestLab;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button BtnKeep;
        private System.Windows.Forms.Button BtnTestResult;
    }
}