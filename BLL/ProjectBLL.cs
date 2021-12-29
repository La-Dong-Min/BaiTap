using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProjectBLL
    {
        ProjectDAO dao = new ProjectDAO();
        public List<ProjectDTO> ReadCustomer()
        {
            List<ProjectDTO> lstCus = dao.ReadCustomer();

            return lstCus;
        }
    }
}
