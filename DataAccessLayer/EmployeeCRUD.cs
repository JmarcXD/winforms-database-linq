using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsDBLinq;

namespace DataBaseWinforms
{
    public class EmployeeCRUD
    {
        private EmployeesDataContext _context;

        public EmployeeCRUD()
        {
            _context = new EmployeesDataContext();
        }

        public List<employees> GetEmployeeListFromDB()
        {
            try
            {
                return _context.employees.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<employees>();
            }
        }

        public void InsertEmployeeToDB(employees newEmployee)
        {
            try
            {
                _context.employees.InsertOnSubmit(newEmployee);
                _context.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
