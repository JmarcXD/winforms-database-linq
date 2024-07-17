using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsDBLinq;

namespace DataBaseWinforms.DataAccessLayer
{
    public class DepartmentCRUD
    {
        private EmployeesDataContext _context;

        public DepartmentCRUD()
        {

            _context = new EmployeesDataContext();
        }

        public List<departments> GetDepartmentListFromDB()
        {
            List<departments> departments = new List<departments>();

            try
            {
                departments = _context.departments.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return departments;
        }
    }
}
