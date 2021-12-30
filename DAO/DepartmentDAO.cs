using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DepartmentDAO: DBConnection
    {
        public List<Department> ReadAreaList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Department", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Department> lstDepart = new List<Department>();
            while (reader.Read())
            {
                Department area = new Department();
                area.IdDepartment = reader["id"].ToString();
                area.Name = reader["Name"].ToString();
                lstDepart.Add(area);

            }
            conn.Close();
            return lstDepart;
        }
        public Department ReadArea(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from Department where id=" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Department area = new Department();
            if (reader.HasRows && reader.Read())
            {
                area.IdDepartment = reader["id"].ToString();
                area.Name = reader["name"].ToString();
            }
            conn.Close();
            return area;
        }
    }
}
