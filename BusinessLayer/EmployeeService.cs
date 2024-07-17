using System;
using System.Collections.Generic;
using WindowsFormsDBLinq;

namespace DataBaseWinforms.BusinessLayer
{
    public class EmployeeService
    {
        private EmployeeCRUD _employeeCRUD;

        public EmployeeService()
        {
            _employeeCRUD = new EmployeeCRUD();
        }

        public List<employees> GetEmployeeList()
        {
            return _employeeCRUD.GetEmployeeListFromDB();
        }

        public void InsertEmployee(string first_name, string last_name, string email, string phone_number, DateTime hire_date,int job_id, decimal salary, int? manager_id, int? department_id)
        {
            employees newEmployee = new employees();

            newEmployee.first_name = first_name;
            newEmployee.last_name = last_name;
            newEmployee.email = email;  
            newEmployee.phone_number = phone_number;
            newEmployee.hire_date = hire_date;
            newEmployee.job_id = job_id;
            newEmployee.salary = salary;
            newEmployee.manager_id = manager_id;
            newEmployee.department_id = department_id;

            _employeeCRUD.InsertEmployeeToDB(newEmployee);
        }
    }
}
