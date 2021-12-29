using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProjectDAO : DBConnection
    {
        public List<ProjectDTO> ReadCustomer()
        {

            {

                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Employee", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProjectDTO> lstCus = new List<ProjectDTO>();

                while (reader.Read())
                {
                    ProjectDTO cus = new ProjectDTO();
                    cus.IdEmployee = reader["IdEmployee"].ToString();
                    cus.Name = reader["Name"].ToString();
                    cus.DateBirth = reader["DateBirth"].ToString();
                    cus.Gender = (bool.Parse(reader["Gender"].ToString()));
                    cus.PlaceBirth = reader["PlaceBirth"].ToString();
                    cus.IdDepartment = reader["IdDepartment"].ToString();
                    lstCus.Add(cus);
                }
                conn.Close();
                return lstCus;

            }
        }
    }
}

