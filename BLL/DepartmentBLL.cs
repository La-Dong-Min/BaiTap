using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DepartmentBLL
    {
        DepartmentDAO dao = new DepartmentDAO();
        public List<Department> ReadAreaList()
        {
            List<Department> lstDepart = dao.ReadAreaList();
            return lstDepart;
        }
    }
}
