namespace MyTestApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.departmentTree = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.departmentViewBox = new System.Windows.Forms.ComboBox();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addEmployee = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeePosition = new System.Windows.Forms.TextBox();
            this.employeeDocNumber = new System.Windows.Forms.TextBox();
            this.employeeDocSeries = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeePatronomyc = new System.Windows.Forms.TextBox();
            this.employeeSureName = new System.Windows.Forms.TextBox();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.employeeDoB = new System.Windows.Forms.DateTimePicker();
            this.employeeDepartment = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.departmentTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Структура предприятия";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // departmentTree
            // 
            this.departmentTree.Location = new System.Drawing.Point(35, 64);
            this.departmentTree.Name = "departmentTree";
            this.departmentTree.Size = new System.Drawing.Size(788, 456);
            this.departmentTree.TabIndex = 0;
            this.departmentTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.DepartmentTree_BeforeSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.departmentViewBox);
            this.tabPage2.Controls.Add(this.employeeGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Управление сотрудниками";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // departmentViewBox
            // 
            this.departmentViewBox.FormattingEnabled = true;
            this.departmentViewBox.Location = new System.Drawing.Point(23, 30);
            this.departmentViewBox.Name = "departmentViewBox";
            this.departmentViewBox.Size = new System.Drawing.Size(721, 28);
            this.departmentViewBox.TabIndex = 1;
            this.departmentViewBox.SelectionChangeCommitted += new System.EventHandler(this.DepartmentViewBox_SelectionChangeCommitted);
            // 
            // employeeGridView
            // 
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Location = new System.Drawing.Point(3, 80);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.RowHeadersWidth = 62;
            this.employeeGridView.RowTemplate.Height = 28;
            this.employeeGridView.Size = new System.Drawing.Size(888, 474);
            this.employeeGridView.TabIndex = 0;
            this.employeeGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGridView_CellValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.addEmployee);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.employeePosition);
            this.tabPage3.Controls.Add(this.employeeDocNumber);
            this.tabPage3.Controls.Add(this.employeeDocSeries);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.employeePatronomyc);
            this.tabPage3.Controls.Add(this.employeeSureName);
            this.tabPage3.Controls.Add(this.employeeName);
            this.tabPage3.Controls.Add(this.employeeDoB);
            this.tabPage3.Controls.Add(this.employeeDepartment);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(898, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Добавление нового сотрудника";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(402, 291);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(102, 48);
            this.addEmployee.TabIndex = 16;
            this.addEmployee.Text = "Добавить";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Департамент";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер документа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Серия документа";
            // 
            // employeePosition
            // 
            this.employeePosition.Location = new System.Drawing.Point(608, 126);
            this.employeePosition.Name = "employeePosition";
            this.employeePosition.Size = new System.Drawing.Size(257, 26);
            this.employeePosition.TabIndex = 10;
            // 
            // employeeDocNumber
            // 
            this.employeeDocNumber.Location = new System.Drawing.Point(332, 126);
            this.employeeDocNumber.Name = "employeeDocNumber";
            this.employeeDocNumber.Size = new System.Drawing.Size(257, 26);
            this.employeeDocNumber.TabIndex = 9;
            // 
            // employeeDocSeries
            // 
            this.employeeDocSeries.Location = new System.Drawing.Point(55, 126);
            this.employeeDocSeries.Name = "employeeDocSeries";
            this.employeeDocSeries.Size = new System.Drawing.Size(257, 26);
            this.employeeDocSeries.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // employeePatronomyc
            // 
            this.employeePatronomyc.Location = new System.Drawing.Point(608, 64);
            this.employeePatronomyc.Name = "employeePatronomyc";
            this.employeePatronomyc.Size = new System.Drawing.Size(257, 26);
            this.employeePatronomyc.TabIndex = 4;
            // 
            // employeeSureName
            // 
            this.employeeSureName.Location = new System.Drawing.Point(332, 64);
            this.employeeSureName.Name = "employeeSureName";
            this.employeeSureName.Size = new System.Drawing.Size(257, 26);
            this.employeeSureName.TabIndex = 3;
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(55, 64);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(257, 26);
            this.employeeName.TabIndex = 2;
            // 
            // employeeDoB
            // 
            this.employeeDoB.Location = new System.Drawing.Point(55, 192);
            this.employeeDoB.Name = "employeeDoB";
            this.employeeDoB.Size = new System.Drawing.Size(257, 26);
            this.employeeDoB.TabIndex = 1;
            // 
            // employeeDepartment
            // 
            this.employeeDepartment.FormattingEnabled = true;
            this.employeeDepartment.Location = new System.Drawing.Point(332, 190);
            this.employeeDepartment.Name = "employeeDepartment";
            this.employeeDepartment.Size = new System.Drawing.Size(533, 28);
            this.employeeDepartment.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 595);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Работа с сотрудниками";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.ComboBox departmentViewBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeePatronomyc;
        private System.Windows.Forms.TextBox employeeSureName;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.DateTimePicker employeeDoB;
        private System.Windows.Forms.ComboBox employeeDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox employeePosition;
        private System.Windows.Forms.TextBox employeeDocNumber;
        private System.Windows.Forms.TextBox employeeDocSeries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.TreeView departmentTree;
    }
}

