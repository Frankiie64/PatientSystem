
namespace PatientSystem.Keep
{
    partial class FrmListPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListPatients));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PtbPatients = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvPatients = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSearch = new System.Windows.Forms.Label();
            this.MtbCard = new System.Windows.Forms.MaskedTextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TlpSetting = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDeselect = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPatients)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatients)).BeginInit();
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
            this.PtbPatients.Image = ((System.Drawing.Image)(resources.GetObject("PtbPatients.Image")));
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
            this.tableLayoutPanel3.Controls.Add(this.DgvPatients, 0, 1);
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
            // DgvPatients
            // 
            this.DgvPatients.AllowUserToAddRows = false;
            this.DgvPatients.AllowUserToDeleteRows = false;
            this.DgvPatients.BackgroundColor = System.Drawing.Color.White;
            this.DgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPatients.GridColor = System.Drawing.Color.DarkGray;
            this.DgvPatients.Location = new System.Drawing.Point(3, 35);
            this.DgvPatients.MultiSelect = false;
            this.DgvPatients.Name = "DgvPatients";
            this.DgvPatients.ReadOnly = true;
            this.DgvPatients.RowHeadersWidth = 62;
            this.DgvPatients.RowTemplate.Height = 25;
            this.DgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPatients.Size = new System.Drawing.Size(382, 236);
            this.DgvPatients.TabIndex = 1;
            this.DgvPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPatients_CellClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.39267F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.5288F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.07853F));
            this.tableLayoutPanel4.Controls.Add(this.LblSearch, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.MtbCard, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnSearch, 2, 0);
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
            this.LblSearch.Location = new System.Drawing.Point(4, 0);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(90, 17);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Identity Card:";
            // 
            // MtbCard
            // 
            this.MtbCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtbCard.Location = new System.Drawing.Point(100, 3);
            this.MtbCard.Mask = "000-0000000-0";
            this.MtbCard.Name = "MtbCard";
            this.MtbCard.Size = new System.Drawing.Size(145, 23);
            this.MtbCard.TabIndex = 1;
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
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // TlpSetting
            // 
            this.TlpSetting.ColumnCount = 2;
            this.TlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSetting.Controls.Add(this.BtnDeselect, 1, 0);
            this.TlpSetting.Controls.Add(this.BtnNext, 0, 0);
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
            // BtnDeselect
            // 
            this.BtnDeselect.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDeselect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDeselect.FlatAppearance.BorderSize = 0;
            this.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeselect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeselect.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeselect.Image")));
            this.BtnDeselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeselect.Location = new System.Drawing.Point(198, 3);
            this.BtnDeselect.Name = "BtnDeselect";
            this.BtnDeselect.Size = new System.Drawing.Size(189, 29);
            this.BtnDeselect.TabIndex = 5;
            this.BtnDeselect.Text = "Deselectd";
            this.BtnDeselect.UseVisualStyleBackColor = false;
            this.BtnDeselect.Visible = false;
            this.BtnDeselect.Click += new System.EventHandler(this.BtnDeselect_Click);
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
            this.BtnNext.Location = new System.Drawing.Point(3, 3);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(189, 29);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = "Next step";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // FrmListPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListPatients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.FrmListPatients_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbPatients)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatients)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.TlpSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PtbPatients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DgvPatients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.MaskedTextBox MtbCard;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TableLayoutPanel TlpSetting;
        private System.Windows.Forms.Button BtnDeselect;
    }
}