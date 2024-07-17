using DataBaseWinforms.DataAccessLayer;
using System.Collections.Generic;
using WindowsFormsDBLinq;

namespace DataBaseWinforms.BusinessLayer
{
    public class JobService
    {
        private JobCRUD _jobcrud;

        public JobService()
        {
            _jobcrud = new JobCRUD();
        }

        public List<jobs> GetJobsList()
        {
            return _jobcrud.GetJobsListFromDB();
        }
    }
}
