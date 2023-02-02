using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bookingsystem.Model
{
    public class EmployeeCatalog
    {
        private List<Employee> _employees;

       public List<Employee> Employees
        { get { return _employees; } set { _employees = value; } }

        public EmployeeCatalog()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee newEmployee) 
        {
            _employees.Add(newEmployee);
        }

        public void PrintAll ()
        {
            foreach (Employee e in _employees)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public Employee GetByPhoneId (string phoneId)
        {
            foreach (Employee e in _employees)
            {
                if(e.Phone==phoneId)
                    return e;
            }
            return null;
        }


    }


}
