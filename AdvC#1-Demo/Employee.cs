using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_1_Demo
{
    internal struct Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Salary { get; set; }

        public Employee(int _Id, string _Name, double _Salary)
        {
            Id = _Id;
            Name = _Name;
            Salary = _Salary;

        }

        public override bool Equals(object? obj)
        {
            Employee PassedEmp = (Employee)obj;
            return this.Id == PassedEmp.Id && this.Name == PassedEmp.Name && this.Salary == PassedEmp.Salary;
        }

        //public static bool operator == ( Employee left , Employee right)
        //{
        //    return left.Equals (right); 
        //   // return left.Id  == right.Id && left.Name == right.Name && left.Salary == right.Salary;
        //}


        //public static bool operator !=(Employee left, Employee right)
        //{
        //    return left.Id != right.Id && left.Name != right.Name && left.Salary != right.Salary;
        //}


        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }


        public int CompareTo(object? obj)
        {
            Employee? PassedEmp = (Employee)obj; // Explicit Casting // Unsafe casting make throw exception => invalid casting exception

            if (this.Salary > PassedEmp?.Salary)
            {
                return 1;
            }
            else if (this.Salary < PassedEmp?.Salary)
            {
                return -1;
            }
            else return 0;
        }

        public int CompareTo(Employee CompareEmployee)
        {
            if (this.Salary > CompareEmployee.Salary)
            {
                return 1;
            }
            else if (this.Salary < CompareEmployee.Salary)
            {
                return -1;
            }
            else return 0;
        }
    }
}
