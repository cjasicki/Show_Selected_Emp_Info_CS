namespace Example5_CS
{
    partial class Form1
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
            this.txtPayrate = new System.Windows.Forms.TextBox();
            this.lblPayrate = new System.Windows.Forms.Label();
            this.dgvPayInfo = new System.Windows.Forms.DataGridView();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPayrate
            // 
            this.txtPayrate.Location = new System.Drawing.Point(530, 75);
            this.txtPayrate.Name = "txtPayrate";
            this.txtPayrate.Size = new System.Drawing.Size(100, 22);
            this.txtPayrate.TabIndex = 3;
            // 
            // lblPayrate
            // 
            this.lblPayrate.Location = new System.Drawing.Point(425, 75);
            this.lblPayrate.Name = "lblPayrate";
            this.lblPayrate.Size = new System.Drawing.Size(100, 23);
            this.lblPayrate.TabIndex = 2;
            this.lblPayrate.Text = "Payrate:";
            this.lblPayrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvPayInfo
            // 
            this.dgvPayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayInfo.Location = new System.Drawing.Point(100, 150);
            this.dgvPayInfo.Name = "dgvPayInfo";
            this.dgvPayInfo.RowHeadersWidth = 51;
            this.dgvPayInfo.RowTemplate.Height = 24;
            this.dgvPayInfo.Size = new System.Drawing.Size(600, 250);
            this.dgvPayInfo.TabIndex = 4;
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(170, 75);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(200, 24);
            this.cboEmployee.TabIndex = 1;
            this.cboEmployee.SelectionChangeCommitted += new System.EventHandler(this.CboEmployee_SelectionChangeCommitted_1);
            // 
            // lblEmployee
            // 
            this.lblEmployee.Location = new System.Drawing.Point(65, 75);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(100, 23);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee:";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(50, 520);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(600, 23);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "(error)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtPayrate);
            this.Controls.Add(this.lblPayrate);
            this.Controls.Add(this.dgvPayInfo);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblError);
            this.Name = "Form1";
            this.Text = "Stored Proc Output Parameter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPayrate;
        internal System.Windows.Forms.Label lblPayrate;
        internal System.Windows.Forms.DataGridView dgvPayInfo;
        internal System.Windows.Forms.ComboBox cboEmployee;
        internal System.Windows.Forms.Label lblEmployee;
        internal System.Windows.Forms.Label lblError;
    }
}

