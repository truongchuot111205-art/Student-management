using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }


        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = rdioNam.Checked ? "Nu" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value =
            float.Parse(txtDTB.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cbBoxChuyenNghanh.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDTB.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                }
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                //TH Thêm mới
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else //TH cập nhật
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        //xóa thông tin sinh viên tại dòng tìm thấy
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

                txtMSSV.Text = row.Cells[1].Value?.ToString() ?? "";
                txtHoTen.Text = row.Cells[2].Value?.ToString() ?? "";

                string gender = row.Cells[3].Value?.ToString() ?? "";

                if (gender == "Nam")
                {
                    rdioNam.Checked = true;
                }
                else if (gender == "Nữ")
                {
                    rdioNu.Checked = true;
                }

                txtDTB.Text = row.Cells[4].Value?.ToString() ?? "";
                cbBoxChuyenNghanh.Text = row.Cells[5].Value?.ToString() ?? "";
            }
        }


        private void CountGender()
        {
            int nam = 0, nu = 0;

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    string gender = row.Cells[3].Value.ToString();

                    if (gender == "Nam")
                        nam++;
                    else if (gender == "Nữ")
                        nu++;
                }
            }

            txtNam.Text = nam.ToString();
            txtNu.Text = nu.ToString();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbBoxChuyenNghanh.SelectedIndex = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxChuyenNghanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
