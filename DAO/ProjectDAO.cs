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
        public void NewCustomer(ProjectDTO cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Employee values(@IdEmployee, @Name, @DateBirth ,@Gender, @PlaceBirth, @IdDepartment, @Department)", conn);
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", cus.IdDepartment));
            cmd.Parameters.Add(new SqlParameter("@Name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", cus.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", cus.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", cus.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("@IdDepartment", cus.IdDepartment));
            cmd.Parameters.Add(new SqlParameter("@Department", cus.Depart.IdDepartment));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteCustomer(ProjectDTO cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Employee where IdEmployee = @IdEmployee", conn);
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", cus.IdDepartment));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

