using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1_GUI
{
    public partial class Form1 : Form
    {
        ProjectDAO cusBLL = new ProjectDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProjectDTO> lstCus = cusBLL.ReadCustomer();
            foreach (ProjectDTO cus in lstCus)
            {
                dgvNhanVien.Rows.Add(cus.IdEmployee, cus.Name, cus.DateBirth, cus.Gender, cus.PlaceBirth, cus.IdDepartment);
            }

            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=ADMIN\SQLEXPRESS;
                                                    Initial Catalog=HR; User Id=sa; Password=12345";
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Name from Department", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmBDonVi.Items.Add(reader[0].ToString());
                }
                conn.Close();
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult Thoat;
            Thoat = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Thoat == DialogResult.OK)
            {
                this.Close();
            }
        }


    }
}
