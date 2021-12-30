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
        public void NewCustomer(ProjectDTO cus)
        {
            dao.NewCustomer(cus);
        }
        public void DeleteCustomer(ProjectDTO cus)
        {
            dao.DeleteCustomer(cus);
        }
        //public void EditCustomer(ProjectDTO cus)
        //{
        //    dao.EditCustomer(cus);
        //}
    }
}
