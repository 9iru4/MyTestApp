using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp
{
    internal class EmployeeAdapter
    {
        public decimal ID { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string Patronymic { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get;}

        public string DocSeries { get; set; }

        public string DocNumber { get; set; }

        public string Position { get; set; }

        public Guid DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public EmployeeAdapter(Empoyee empoyee)
        {
            ID = empoyee.ID;
            FirstName = empoyee.FirstName;
            SurName = empoyee.SurName;
            Patronymic = empoyee.Patronymic;
            DateOfBirth = empoyee.DateOfBirth;
            Age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateOfBirth > DateTime.Now.AddYears(-Age)) Age--;
            DocSeries = empoyee.DocSeries;
            DocNumber = empoyee.DocNumber;
            Position = empoyee.Position;
            DepartmentID = empoyee.DepartmentID;
            Department = empoyee.Department;
        }

        public static List<EmployeeAdapter> GetEmployees(List<Empoyee> emp)
        {
            List<EmployeeAdapter> col = new List<EmployeeAdapter>();
            foreach (var item in emp)
            {
                col.Add(new EmployeeAdapter(item));
            }
            return col;
        }

        public Empoyee ToEmpoyee()
        {
            return new Empoyee
            {
                ID = ID,
                FirstName = FirstName,
                SurName = SurName,
                Patronymic = Patronymic,
                DateOfBirth = DateOfBirth,
                DocSeries = DocSeries,
                DocNumber = DocNumber,
                Position = Position,
                DepartmentID = DepartmentID,
                Department = Department
            };
        }
    }
}
