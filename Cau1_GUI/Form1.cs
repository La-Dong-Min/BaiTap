using BLL;
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

        private void btThem_Click(object sender, EventArgs e)
        {
            ProjectDTO cus = new ProjectDTO();
            if (tbMa.Text.Equals("") || tbHoTen.Text.Equals("") || tbNoiSinh.Text.Equals(""))
            {
                MessageBox.Show("Không bỏ trống", "Thông báo");
            }
            else
            {
                cus.IdDepartment = tbMa.Text;
                cus.Name = tbHoTen.Text;
                cus.DateBirth = dateNgaySinh.Value.Date.ToString();
                cus.Gender = checkBoxGioiTinh.Checked;
                cus.PlaceBirth = tbNoiSinh.Text;
                cus.Depart = (Department)cmBDonVi.SelectedItem;
                cusBLL.NewCustomer(cus);

                dgvNhanVien.Rows.Add(cus.IdDepartment, cus.Name, cus.DateBirth, cus.Gender, cus.PlaceBirth, cus.IdEmployee, cus.Name);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.dgvNhanVien.SelectedRows.Count > 0)
            {
                dgvNhanVien.Rows.RemoveAt(this.dgvNhanVien.SelectedRows[0].Index);
            }
        }
    }
}
