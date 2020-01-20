using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example5_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //*****
        //** Form
        //**
        //*******************************************************
        //** Procedure: Form1_Load()
        //**   Initializes combobox
        //*******************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            LoadEmployeeNames();
        }

        //ADD the selectionChangeCommitted EVENT to the cboEmployee control.
        // comboBox
        // Load payroll information and payrate for employee
        private void cboEmployee_SelectionChangeCommitted(object Sender, EventArgs e)
        {
            lblError.Text = "";
            if (cboEmployee.SelectedIndex >= 0)
            {
                DisplayEmployeePayroll(Convert.ToInt32(cboEmployee.SelectedValue));
            }
        }

        //*****
        //** Procedure
        //*****
        //*******************************************************
        //** Procedure: LoadEmployeeNames()
        //**   Populate combo box with employee name and id
        //*******************************************************
        private void LoadEmployeeNames()
        {
            DataSet dsData;

            lblError.Text = "";

            dsData = clsDatabase.GetEmployeeNames();
            if(dsData== null)
            {
                lblError.Text = "Error retrieving employee names";
            }
            else if (dsData.Tables.Count <1)
            {
                lblError.Text = "Error retrieving employee names";
                dsData.Dispose();
            }
            else
            {
                cboEmployee.DataSource = dsData.Tables[0];
                cboEmployee.DisplayMember = "LName";
                cboEmployee.ValueMember = "EmpID";

                if(cboEmployee.Items.Count > 0)
                {
                    cboEmployee.SelectedIndex = 0;
                    DisplayEmployeePayroll(Convert.ToInt32(cboEmployee.SelectedValue));
                }
            }

        }
        // Display payrate and payroll for specified employee
        private void DisplayEmployeePayroll(Int32 intEmpID)
        {
            DataSet dsData;
            Decimal decPayrate;

            decPayrate = clsDatabase.GetEmployeePayrate(intEmpID);
            if(decPayrate < 0m)
            {
                lblError.Text = "$0.00";
            }
            else
            {
                txtPayrate.Text = decPayrate.ToString("c");
            }

            dsData = clsDatabase.GetEmplyeePayroll(intEmpID);
            if (dsData ==null)
            {
                lblError.Text = "Error retrieving payroll info";
            }
            else if(dsData.Tables.Count < 1)
            {
                lblError.Text = "Error retrieving payroll info";
                dsData.Dispose();
            }
            else
            {
                dgvPayInfo.DataSource = dsData.Tables[0];
            }
        }

  

        private void CboEmployee_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (cboEmployee.SelectedIndex >= 0)
            {
                Int32 x = Convert.ToInt32(cboEmployee.SelectedValue);
                DisplayEmployeePayroll(x);
            }
        }
    }
}
