
namespace EmpdbSystem
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
            this.gridviewEmp = new System.Windows.Forms.DataGridView();
            this.lblempid = new System.Windows.Forms.Label();
            this.lbldptid = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.lbldeg = new System.Windows.Forms.Label();
            this.lblsal = new System.Windows.Forms.Label();
            this.txtboxEmpId = new System.Windows.Forms.TextBox();
            this.txtboxFname = new System.Windows.Forms.TextBox();
            this.txtboxLname = new System.Windows.Forms.TextBox();
            this.txtboxSalary = new System.Windows.Forms.TextBox();
            this.cmbboxDeptId = new System.Windows.Forms.ComboBox();
            this.cmbboxdesig = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewEmp
            // 
            this.gridviewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewEmp.Location = new System.Drawing.Point(79, 50);
            this.gridviewEmp.Name = "gridviewEmp";
            this.gridviewEmp.Size = new System.Drawing.Size(609, 150);
            this.gridviewEmp.TabIndex = 0;
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.Location = new System.Drawing.Point(76, 203);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(113, 28);
            this.lblempid.TabIndex = 1;
            this.lblempid.Text = "Employee Id";
            // 
            // lbldptid
            // 
            this.lbldptid.AutoSize = true;
            this.lbldptid.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldptid.Location = new System.Drawing.Point(74, 324);
            this.lbldptid.Name = "lbldptid";
            this.lbldptid.Size = new System.Drawing.Size(133, 28);
            this.lbldptid.TabIndex = 2;
            this.lbldptid.Text = "Department Id";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllname.Location = new System.Drawing.Point(74, 283);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(186, 28);
            this.lbllname.TabIndex = 3;
            this.lbllname.Text = "Employee Last Name";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(76, 244);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(190, 28);
            this.lblfname.TabIndex = 4;
            this.lblfname.Text = "Employee First Name";
            // 
            // lbldeg
            // 
            this.lbldeg.AutoSize = true;
            this.lbldeg.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeg.Location = new System.Drawing.Point(76, 363);
            this.lbldeg.Name = "lbldeg";
            this.lbldeg.Size = new System.Drawing.Size(113, 28);
            this.lbldeg.TabIndex = 5;
            this.lbldeg.Text = "Designation";
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsal.Location = new System.Drawing.Point(76, 400);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(65, 28);
            this.lblsal.TabIndex = 6;
            this.lblsal.Text = "Salary";
            // 
            // txtboxEmpId
            // 
            this.txtboxEmpId.Font = new System.Drawing.Font("Sitka Subheading", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmpId.Location = new System.Drawing.Point(306, 211);
            this.txtboxEmpId.Name = "txtboxEmpId";
            this.txtboxEmpId.Size = new System.Drawing.Size(100, 21);
            this.txtboxEmpId.TabIndex = 7;
            // 
            // txtboxFname
            // 
            this.txtboxFname.Font = new System.Drawing.Font("Sitka Subheading", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFname.Location = new System.Drawing.Point(306, 250);
            this.txtboxFname.Name = "txtboxFname";
            this.txtboxFname.Size = new System.Drawing.Size(100, 21);
            this.txtboxFname.TabIndex = 8;
            // 
            // txtboxLname
            // 
            this.txtboxLname.Font = new System.Drawing.Font("Sitka Subheading", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLname.Location = new System.Drawing.Point(306, 290);
            this.txtboxLname.Name = "txtboxLname";
            this.txtboxLname.Size = new System.Drawing.Size(100, 21);
            this.txtboxLname.TabIndex = 9;
            // 
            // txtboxSalary
            // 
            this.txtboxSalary.Font = new System.Drawing.Font("Sitka Subheading", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSalary.Location = new System.Drawing.Point(306, 400);
            this.txtboxSalary.Name = "txtboxSalary";
            this.txtboxSalary.Size = new System.Drawing.Size(100, 21);
            this.txtboxSalary.TabIndex = 10;
            // 
            // cmbboxDeptId
            // 
            this.cmbboxDeptId.FormattingEnabled = true;
            this.cmbboxDeptId.Location = new System.Drawing.Point(306, 330);
            this.cmbboxDeptId.Name = "cmbboxDeptId";
            this.cmbboxDeptId.Size = new System.Drawing.Size(121, 21);
            this.cmbboxDeptId.TabIndex = 11;
            // 
            // cmbboxdesig
            // 
            this.cmbboxdesig.FormattingEnabled = true;
            this.cmbboxdesig.Location = new System.Drawing.Point(306, 363);
            this.cmbboxdesig.Name = "cmbboxdesig";
            this.cmbboxdesig.Size = new System.Drawing.Size(121, 21);
            this.cmbboxdesig.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(483, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add New Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(652, 231);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 40);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(483, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 40);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(652, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 40);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(568, 363);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 40);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Select to Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbboxdesig);
            this.Controls.Add(this.cmbboxDeptId);
            this.Controls.Add(this.txtboxSalary);
            this.Controls.Add(this.txtboxLname);
            this.Controls.Add(this.txtboxFname);
            this.Controls.Add(this.txtboxEmpId);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.lbldeg);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lbldptid);
            this.Controls.Add(this.lblempid);
            this.Controls.Add(this.gridviewEmp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewEmp;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lbldptid;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label lbldeg;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.TextBox txtboxEmpId;
        private System.Windows.Forms.TextBox txtboxFname;
        private System.Windows.Forms.TextBox txtboxLname;
        private System.Windows.Forms.TextBox txtboxSalary;
        private System.Windows.Forms.ComboBox cmbboxDeptId;
        private System.Windows.Forms.ComboBox cmbboxdesig;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEdit;
    }
}

