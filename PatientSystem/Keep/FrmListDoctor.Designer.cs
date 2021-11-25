
namespace PatientSystem.Keep
{
    partial class FrmListDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListDoctor));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNext = new System.Windows.Forms.Button();
            this.PtbDoctor = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvDoctor = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSearch = new System.Windows.Forms.Label();
            this.MtbCard = new System.Windows.Forms.MaskedTextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbDoctor)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctor)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.382743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.23451F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.382743F));
            this.tableLayoutPanel1.Controls.Add(this.BtnNext, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PtbDoctor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.96154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.461538F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 449);
            this.tableLayoutPanel1.TabIndex = 8;
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
            this.BtnNext.Location = new System.Drawing.Point(48, 413);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(388, 33);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = "Next step";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // PtbDoctor
            // 
            this.PtbDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbDoctor.Image = ((System.Drawing.Image)(resources.GetObject("PtbDoctor.Image")));
            this.PtbDoctor.Location = new System.Drawing.Point(48, 3);
            this.PtbDoctor.Name = "PtbDoctor";
            this.PtbDoctor.Size = new System.Drawing.Size(388, 130);
            this.PtbDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbDoctor.TabIndex = 0;
            this.PtbDoctor.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.DgvDoctor, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(48, 139);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.54019F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.45981F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 268);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // DgvDoctor
            // 
            this.DgvDoctor.AllowUserToAddRows = false;
            this.DgvDoctor.AllowUserToDeleteRows = false;
            this.DgvDoctor.BackgroundColor = System.Drawing.Color.White;
            this.DgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDoctor.GridColor = System.Drawing.Color.DarkGray;
            this.DgvDoctor.Location = new System.Drawing.Point(3, 36);
            this.DgvDoctor.MultiSelect = false;
            this.DgvDoctor.Name = "DgvDoctor";
            this.DgvDoctor.ReadOnly = true;
            this.DgvDoctor.RowHeadersWidth = 62;
            this.DgvDoctor.RowTemplate.Height = 25;
            this.DgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDoctor.Size = new System.Drawing.Size(382, 229);
            this.DgvDoctor.TabIndex = 1;
            this.DgvDoctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoctor_CellClick);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(382, 27);
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
            this.BtnSearch.Size = new System.Drawing.Size(128, 21);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FrmListDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListDoctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.FrmListDoctor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbDoctor)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctor)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.PictureBox PtbDoctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DgvDoctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.MaskedTextBox MtbCard;
        private System.Windows.Forms.Button BtnSearch;
    }
}