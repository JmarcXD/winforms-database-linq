using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsDBLinq;

namespace DataBaseWinforms.DataAccessLayer
{
    public class JobCRUD
    {
        private EmployeesDataContext _context;

        public JobCRUD()
        {
            _context = new EmployeesDataContext();
        }

        public List<jobs> GetJobsListFromDB()
        {
            List<jobs> jobs = new List<jobs>();

            try
            {
                jobs = _context.jobs.ToList();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return jobs;
        }
    }
}
