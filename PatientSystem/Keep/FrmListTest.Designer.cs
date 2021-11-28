
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
            this.btnDeselected = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.461538F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 748);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // PtbPatients
            // 
            this.PtbPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbPatients.Location = new System.Drawing.Point(69, 5);
            this.PtbPatients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PtbPatients.Name = "PtbPatients";
            this.PtbPatients.Size = new System.Drawing.Size(555, 208);
            this.PtbPatients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbPatients.TabIndex = 0;
            this.PtbPatients.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Controls.Add(this.DgvTest, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(69, 223);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.94969F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.05032F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(555, 456);
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
            this.DgvTest.Location = new System.Drawing.Point(4, 59);
            this.DgvTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvTest.Name = "DgvTest";
            this.DgvTest.ReadOnly = true;
            this.DgvTest.RowHeadersWidth = 62;
            this.DgvTest.RowTemplate.Height = 25;
            this.DgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTest.Size = new System.Drawing.Size(547, 392);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(547, 44);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // LblSearch
            // 
            this.LblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSearch.Location = new System.Drawing.Point(23, 0);
            this.LblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(111, 28);
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
            this.BtnSearch.Location = new System.Drawing.Point(358, 5);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(185, 34);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtTestName
            // 
            this.TxtTestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtTestName.Location = new System.Drawing.Point(141, 3);
            this.TxtTestName.Name = "TxtTestName";
            this.TxtTestName.Size = new System.Drawing.Size(210, 31);
            this.TxtTestName.TabIndex = 3;
            // 
            // TlpSetting
            // 
            this.TlpSetting.ColumnCount = 2;
            this.TlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSetting.Controls.Add(this.btnDeselected, 1, 0);
            this.TlpSetting.Controls.Add(this.BtnSelected, 0, 0);
            this.TlpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSetting.Location = new System.Drawing.Point(68, 687);
            this.TlpSetting.Name = "TlpSetting";
            this.TlpSetting.RowCount = 1;
            this.TlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpSetting.Size = new System.Drawing.Size(557, 58);
            this.TlpSetting.TabIndex = 5;
            // 
            // btnDeselected
            // 
            this.btnDeselected.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeselected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeselected.Enabled = false;
            this.btnDeselected.FlatAppearance.BorderSize = 0;
            this.btnDeselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselected.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeselected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeselected.Location = new System.Drawing.Point(282, 5);
            this.btnDeselected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeselected.Name = "btnDeselected";
            this.btnDeselected.Size = new System.Drawing.Size(271, 48);
            this.btnDeselected.TabIndex = 5;
            this.btnDeselected.Text = "Deselected";
            this.btnDeselected.UseVisualStyleBackColor = false;
            this.btnDeselected.Click += new System.EventHandler(this.btnDeselected_Click);
            // 
            // BtnSelected
            // 
            this.BtnSelected.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelected.Enabled = false;
            this.BtnSelected.FlatAppearance.BorderSize = 0;
            this.BtnSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelected.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelected.Location = new System.Drawing.Point(4, 5);
            this.BtnSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelected.Name = "BtnSelected";
            this.BtnSelected.Size = new System.Drawing.Size(270, 48);
            this.BtnSelected.TabIndex = 4;
            this.BtnSelected.Text = "Save";
            this.BtnSelected.UseVisualStyleBackColor = false;
            this.BtnSelected.Click += new System.EventHandler(this.BtnSelected_Click);
            // 
            // FrmListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 748);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListTest";
            this.Text = "List Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListTest_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListTest_FormClosed);
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
        private System.Windows.Forms.Button btnDeselected;
    }

}