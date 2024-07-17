using DataBaseWinforms.DataAccessLayer;
using System.Collections.Generic;
using WindowsFormsDBLinq;

namespace DataBaseWinforms.BusinessLayer
{
    public class DepartmentService
    {
        private DepartmentCRUD _departmentCrud;

        public DepartmentService()
        {
            _departmentCrud = new DepartmentCRUD();
        }

        public List<departments> GetDepartmentList()
        {
            return _departmentCrud.GetDepartmentListFromDB();
        }
    }
}
