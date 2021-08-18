using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpdbSystem
{
    public partial class Form1 : Form
    {
        PCAD2EmployeeEntities1 entities; //need to make an instance of the dbo which being inherited on context.cs
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entities = new PCAD2EmployeeEntities1();
            gridviewEmp.DataSource = entities.Emptables.ToList(); // here we are getting all data from emptables and attaching to grid view datasource
            //                                 ^^ converting emptables to a list to attach to the grid view 
            btnUpdate.Enabled = false; //button is not able to click until true
        }
        private void ClearDataNew()
        {
            //clears data and gives options to enter new data
            txtboxEmpId.Clear();
            txtboxEmpId.ReadOnly = true;
            txtboxEmpId.Text = (entities.Emptables.Max(p => p.Eid)+1).ToString();
            txtboxFname.Clear();
            txtboxLname.Clear();
            txtboxSalary.Clear();
            foreach (var d in entities.DptTables)
            {
                cmbboxDeptId.Items.Add(d.DepartmentId);
            }
            cmbboxdesig.Items.AddRange(new string[] {"Programmer", "Maneger" ,"Sr Manegar", "Developer" });

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtboxEmpId.Text == "") //emp id will be auto generated 
            {
                ClearDataNew();
            }
            //check to make sure entry isnt null or an empty string
            if (!string.IsNullOrWhiteSpace(txtboxFname.Text)&&!string.IsNullOrWhiteSpace(txtboxLname.Text) && !string.IsNullOrWhiteSpace(txtboxEmpId.Text)) 
            {
                Emptable obj = new Emptable();
                obj.Eid = Convert.ToDecimal(txtboxEmpId.Text);
                obj.EmpFirstName = txtboxFname.Text;
                obj.EmpLastName = txtboxLname.Text;
                obj.DepartmentId = Convert.ToDecimal(cmbboxDeptId.SelectedItem);
                obj.Designation = cmbboxdesig.ToString();
                obj.Salary = Convert.ToDecimal(txtboxSalary.Text);
                entities.Emptables.Add(obj);//adds new obj to entity emptable 
                entities.SaveChanges();//must call save ch;anges or it wont change in the server side
                Clear();

            }

        }
        private void Clear()
        {// clears all the txt and combo boxes 
            txtboxEmpId.Clear();
            txtboxFname.Clear();
            txtboxLname.Clear();
            txtboxSalary.Clear();
            cmbboxDeptId.Items.Clear();
            cmbboxdesig.Items.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //makes the grid nothing , then makes the grid pop up with need changes made to database
            gridviewEmp.DataSource = null;
            gridviewEmp.DataSource = entities.Emptables.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = gridviewEmp.CurrentRow.Cells[0].Value; //selecting the row to delete
            var emptodel = entities.Emptables.First(p => p.Eid == (decimal)id);// selecting the reference ,choosing the first query 
            //which is employee id bc it is a unique value
            entities.Emptables.Remove(emptodel);
            entities.SaveChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            //ability to click item and edit it
            var id = gridviewEmp.CurrentRow.Cells[0].Value;
            var emptoupdate = entities.Emptables.First(m => m.Eid == (decimal)id);//getting reference of the object selected 
            //populating everythinng here into the text boxes
            txtboxEmpId.Text = emptoupdate.Eid.ToString();
            txtboxEmpId.ReadOnly = true;
            txtboxFname.Text = emptoupdate.EmpFirstName;
            txtboxLname.Text = emptoupdate.EmpLastName;
            //populate the 
            foreach ( var d in entities.DptTables)
            {
                cmbboxDeptId.Items.Add(d.DepartmentId);
            }
            cmbboxDeptId.SelectedItem = emptoupdate.DepartmentId;

            cmbboxdesig.Items.AddRange(new string[] { "Programmer", "Maneger", "Sr Manegar", "Developer" });
            cmbboxdesig.SelectedItem = emptoupdate.Designation;
            txtboxSalary.Text = emptoupdate.Salary.ToString();
            btnUpdate.Enabled = true;



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this actually updated the whole object/row 
            var id = Convert.ToDecimal(txtboxEmpId.Text);
            var emptoupdate = entities.Emptables.First(m => m.Eid == id);//getting reference of the object selected,need to do 
            //again
            emptoupdate.EmpFirstName = txtboxFname.Text;
            emptoupdate.EmpLastName = txtboxLname.Text;
            emptoupdate.DepartmentId = Convert.ToDecimal(cmbboxDeptId.SelectedItem);
            emptoupdate.Designation = cmbboxdesig.SelectedItem.ToString();
            emptoupdate.Salary = decimal.Parse(txtboxSalary.Text);
           // entities.Emptables.Add(emptoupdate);//adds new obj to entity emptable//// dont need bc its already in the list just 
            entities.SaveChanges();
            Clear();


        }
    }
}
