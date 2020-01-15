using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employeeGridView.AutoGenerateColumns = false;
            GenerateColumn();
            using (dbContext db = new dbContext())
            {
                departmentViewBox.DataSource = db.Department.ToList();
                employeeDepartment.DataSource = db.Department.ToList();
            }
            departmentViewBox.DisplayMember = "Name";
            departmentViewBox.SelectedItem = null;
            employeeDepartment.DisplayMember = "Name";
            employeeDepartment.SelectedItem = null;
            GetDepartmentTree();
        }

        public void GetDepartmentTree()
        {
            List<Department> mydep;
            using (dbContext db = new dbContext())
            {
                mydep = db.Department.ToList();
            }
            foreach (var item in mydep)
            {
                if (item.ParentDepartmentID == null)
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Name = item.ID.ToString();
                    treeNode.Text = item.Name;
                    departmentTree.Nodes.Add(treeNode);
                }
            }
        }

        /// <summary>
        /// напоняем датагрид столбцами
        /// </summary>
        void GenerateColumn()
        {
            DataGridViewColumn column = new DataGridViewColumn();
            column.HeaderText = "Имя";
            column.Name = "FirstName";
            column.DataPropertyName = "FirstName";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.CellTemplate = new DataGridViewTextBoxCell();
            employeeGridView.Columns.Add(column);

            column = new DataGridViewColumn();
            column.HeaderText = "Фамилия";
            column.Name = "SurName";
            column.DataPropertyName = "SurName";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.CellTemplate = new DataGridViewTextBoxCell();
            employeeGridView.Columns.Add(column);

            column = new DataGridViewColumn();
            column.HeaderText = "Отчество";
            column.Name = "Patronymic";
            column.DataPropertyName = "Patronymic";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.CellTemplate = new DataGridViewTextBoxCell();
            employeeGridView.Columns.Add(column);

            column = new DataGridViewColumn();
            column.HeaderText = "Дата Рождения";
            column.Name = "DateOfBirth";
            column.DataPropertyName = "DateOfBirth";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.CellTemplate = new DataGridViewTextBoxCell();
            employeeGridView.Columns.Add(column);

            column = new DataGridViewColumn();
            column.HeaderText = "Возраст";
            column.Name = "Age";
            column.DataPropertyName = "Age";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.CellTemplate = new DataGridViewTextBoxCell();
            employeeGridView.Columns.Add(column);

            column = new DataGridViewColumn();
            column.HeaderText = "Должность";
            column.Name = "Position";
            column.DataPropertyName = "Position";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.CellTemplate = new DataGridViewTextBoxCell();
            employeeGridView.Columns.Add(column);

            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            col.HeaderText = "Департамент";
            col.Name = "Department";
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            col.DisplayMember = "Name";
            col.ValueMember = "ID";
            col.DataPropertyName = "DepartmentID";
            using (dbContext db = new dbContext())
            {
                col.DataSource = db.Department.ToList();
            }
            employeeGridView.Columns.Add(col);
        }

        /// <summary>
        /// при изменении комбобокса обновляем датагрид
        /// </summary>
        private void DepartmentViewBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var emploee = new List<Empoyee>();
            using (dbContext db = new dbContext())
            {
                foreach (var item in db.Empoyee.ToList())
                {
                    if ((departmentViewBox.SelectedItem as Department).ID == item.DepartmentID)
                    {
                        emploee.Add(item);
                    }
                }
                employeeGridView.DataSource = EmployeeAdapter.GetEmployees(emploee);
            }
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext db = new dbContext())
                {
                    Empoyee emp = new Empoyee
                    {
                        FirstName = employeeName.Text,
                        SurName = employeeSureName.Text,
                        Patronymic = employeePatronomyc.Text,
                        DocNumber = employeeDocNumber.Text,
                        DocSeries = employeeDocSeries.Text,
                        DateOfBirth = employeeDoB.Value,
                        Position = employeePosition.Text,
                        DepartmentID = (employeeDepartment.SelectedItem as Department).ID,
                    };
                    db.Empoyee.Add(emp);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DepartmentTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            List<Department> mydep;
            using (dbContext db = new dbContext())
            {
                mydep = db.Department.ToList();
            }
            foreach (var dep in mydep)
            {
                if (e.Node.Name == dep.ParentDepartmentID.ToString())
                {

                    TreeNode treeNode = new TreeNode();
                    treeNode.Name = dep.ID.ToString();
                    treeNode.Text = dep.Name;
                    if (!e.Node.Nodes.ContainsKey(treeNode.Name))
                        e.Node.Nodes.Add(treeNode);
                }
            }
        }

        private void EmployeeGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var a = (employeeGridView.DataSource as List<EmployeeAdapter>)[e.RowIndex].ToEmpoyee();
                using (dbContext db = new dbContext())
                {
                    var emp = db.Empoyee.Where(x => x.ID == a.ID).FirstOrDefault();
                    emp.FirstName = a.FirstName;
                    emp.SurName = a.SurName;
                    emp.Patronymic = a.Patronymic;
                    emp.DateOfBirth = a.DateOfBirth;
                    emp.DocSeries = a.DocSeries;
                    emp.DocNumber = a.DocNumber;
                    emp.Position = a.Position;
                    emp.DepartmentID = a.DepartmentID;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
