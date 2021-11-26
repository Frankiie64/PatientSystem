
namespace PatientSystem.Keep
{
    partial class FrmListTest
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
            this.PtbPatients = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvTest = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSearch = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtTestName = new System.Windows.Forms.TextBox();
            this.TlpSetting = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSelected = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPatients)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTest)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.TlpSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.382743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.23451F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.382743F));
            this.tableLayoutPanel1.Controls.Add(this.PtbPatients, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TlpSetting, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.461538F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 449);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // PtbPatients
            // 
            this.PtbPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbPatients.Location = new System.Drawing.Point(48, 3);
            this.PtbPatients.Name = "PtbPatients";
            this.PtbPatients.Size = new System.Drawing.Size(388, 124);
            this.PtbPatients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbPatients.TabIndex = 0;
            this.PtbPatients.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.DgvTest, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(48, 133);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.94969F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.05032F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 274);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // DgvTest
            // 
            this.DgvTest.AllowUserToAddRows = false;
            this.DgvTest.AllowUserToDeleteRows = false;
            this.DgvTest.BackgroundColor = System.Drawing.Color.White;
            this.DgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTest.GridColor = System.Drawing.Color.DarkGray;
            this.DgvTest.Location = new System.Drawing.Point(3, 35);
            this.DgvTest.Name = "DgvTest";
            this.DgvTest.ReadOnly = true;
            this.DgvTest.RowHeadersWidth = 62;
            this.DgvTest.RowTemplate.Height = 25;
            this.DgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTest.Size = new System.Drawing.Size(382, 236);
            this.DgvTest.TabIndex = 1;
            this.DgvTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTest_CellClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.39267F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.5288F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.07853F));
            this.tableLayoutPanel4.Controls.Add(this.LblSearch, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnSearch, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.TxtTestName, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(382, 26);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // LblSearch
            // 
            this.LblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSearch.Location = new System.Drawing.Point(20, 0);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(74, 17);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Name test:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Azure;
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(251, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(128, 20);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtTestName
            // 
            this.TxtTestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtTestName.Location = new System.Drawing.Point(99, 2);
            this.TxtTestName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTestName.Name = "TxtTestName";
            this.TxtTestName.Size = new System.Drawing.Size(147, 23);
            this.TxtTestName.TabIndex = 3;
            // 
            // TlpSetting
            // 
            this.TlpSetting.ColumnCount = 2;
            this.TlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSetting.Controls.Add(this.BtnSelected, 0, 0);
            this.TlpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSetting.Location = new System.Drawing.Point(47, 412);
            this.TlpSetting.Margin = new System.Windows.Forms.Padding(2);
            this.TlpSetting.Name = "TlpSetting";
            this.TlpSetting.RowCount = 1;
            this.TlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.TlpSetting.Size = new System.Drawing.Size(390, 35);
            this.TlpSetting.TabIndex = 5;
            // 
            // BtnSelected
            // 
            this.BtnSelected.BackColor = System.Drawing.Color.SteelBlue;
            this.TlpSetting.SetColumnSpan(this.BtnSelected, 2);
            this.BtnSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelected.FlatAppearance.BorderSize = 0;
            this.BtnSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelected.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelected.Location = new System.Drawing.Point(3, 3);
            this.BtnSelected.Name = "BtnSelected";
            this.BtnSelected.Size = new System.Drawing.Size(384, 29);
            this.BtnSelected.TabIndex = 4;
            this.BtnSelected.Text = "Save";
            this.BtnSelected.UseVisualStyleBackColor = false;
            this.BtnSelected.Click += new System.EventHandler(this.BtnSelected_Click);
            // 
            // FrmListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListTest";
            this.Text = "List Test";
            this.Load += new System.EventHandler(this.FrmListTest_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbPatients)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTest)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.TlpSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PtbPatients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DgvTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSelected;
        private System.Windows.Forms.TableLayoutPanel TlpSetting;
        private System.Windows.Forms.TextBox TxtTestName;
    }

}