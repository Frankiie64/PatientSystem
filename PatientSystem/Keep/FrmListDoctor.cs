﻿using LogicLayer;
using LogicLayer.LogicKeep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientSystem.Keep
{   
    public partial class FrmListDoctor : Form
    {
        SqlConnection _cn;
        ServiceKeep _service;
        private bool validate = true;
        public FrmListDoctor(SqlConnection cn)
        {
            InitializeComponent();
            _cn = cn;
            _service = new ServiceKeep(_cn);
        }
        private void FrmListDoctor_Load(object sender, EventArgs e)
        {
            LoadData();
           
        }
        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void LoadData()
        {
            DgvDoctor.DataSource = _service.GetListDoctors();
            DgvDoctor.ClearSelection();
            DgvDoctor.Columns[0].Visible = false;
            DgvDoctor.Columns[6].Visible = false;
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (ValidtionNextSteph())
            {
                GlobalRepositoty.Instance.Doc = _service.GetDoctorsById(GlobalRepositoty.Instance.id);
                Deselect();
                validate = false;               
                this.Close();
            }
            else
            {
                MessageBox.Show("Select a Doctor, to continue.");
            }                      
        }
        private bool ValidtionNextSteph()
        {
            return GlobalRepositoty.Instance.id > 0 ? true : false;
        }
        private void DgvDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvDoctor.CurrentRow.Cells[0].Value);

                BtnDeselect.Visible = true;

            }
        }
        private bool validationSearch()
        {
            return (MtbCard.MaskFull);
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (validationSearch())
            {
                DgvDoctor.DataSource = _service.GetUniqueDoctors(MtbCard.Text);
                BtnDeselect.Visible = true;
                if (DgvDoctor.Rows.Count == 0)
                {
                    MessageBox.Show($"The id {DgvDoctor.DataSource} does not exist in the current context.Please try again :)");
                }
                else
                {
                    DgvDoctor.Rows[0].Selected = true;
                    GlobalRepositoty.Instance.id = Convert.ToInt32(DgvDoctor.CurrentRow.Cells[0].Value);

                }
            }
            else
            {
                MessageBox.Show("Please, complete the form");
            }
        }
       
        private void Deselect()
        {


            MtbCard.Clear();
            DgvDoctor.ClearSelection();
            BtnDeselect.Visible = false;
            LoadData();

            GlobalRepositoty.Instance.id = new int();

        }

        private void FrmListDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (validate)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {

                    e.Cancel = false;
                }
            }
        }

        private void FrmListDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!validate)
            {
                FrmDate date = new FrmDate(_cn);
                date.Show();
            }
            else
            {
                FrmKeep keep = new FrmKeep(_cn);
                keep.Show();
            }
            
        }

       
    }
}
