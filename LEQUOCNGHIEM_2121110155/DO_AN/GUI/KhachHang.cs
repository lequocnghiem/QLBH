using DO_AN.BAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class KhachHang : Form
    {
        KhachHangBAL  KHBAL = new KhachHangBAL();
        public KhachHang()
        {
            InitializeComponent();
            dgvkhach.CellClick += dgvkhach_CellClick;
            dgvkhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvkhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            List<KhachHangBEL> lstsp = KHBAL.ReadSP();
            foreach (KhachHangBEL cus in lstsp)
            {
                dgvkhach.Rows.Add(cus.MaKhachHang, cus.Ten, cus.DiaChi,cus.DienThoai);


            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            KhachHangBEL nv = new KhachHangBEL();
            nv.MaKhachHang = lbmh.Text;
            nv.Ten = lbtenhang.Text;
         
            nv.DiaChi = tbhangton.Text;
            nv.DienThoai = textBox1.Text;
        




            OpenFileDialog openFileDialog = new OpenFileDialog();


            KHBAL.NewNV(nv);



            // Xóa toàn bộ dòng trong DataGridView để chuẩn bị load lại danh sách sản phẩm
            dgvkhach.Rows.Clear();

            // Lấy danh sách tất cả sản phẩm từ cơ sở dữ liệu bằng cách gọi phương thức GetAllProducts() từ lớp SPBAL
            List<KhachHangBEL> allProducts = KHBAL.ReadSP();

            // Thêm lại tất cả sản phẩm vào DataGridView
            foreach (KhachHangBEL product in allProducts)
            {
                dgvkhach.Rows.Add(product.MaKhachHang, product.Ten, product.DiaChi, product.DienThoai);
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvkhach.CurrentRow;
            if (row != null)
            {
                // Get the ID (MaNhanVien) of the employee from the first cell of the selected row
               string  nvId = row.Cells[0].Value.ToString();
                string kiemtra =lbmh.Text;
                // Create a new NhanvienBEL object and populate it with the updated values from UI controls
                if(kiemtra!= nvId)
                {
                    MessageBox.Show("Không thể thay đổi mã hóa đơn.");
                    return;
                }
                KhachHangBEL nv = new KhachHangBEL();
                nv.MaKhachHang = kiemtra;
                nv.Ten = lbtenhang.Text;

                nv.DiaChi = tbhangton.Text;
                nv.DienThoai = textBox1.Text;

                // Call the EditNV method in NVBAL to update the employee in the database
                KHBAL.EditNV(nv);

                // Clear the DataGridView and repopulate it with the updated data
                dgvkhach.Rows.Clear();
                List<KhachHangBEL> allEmployees = KHBAL.ReadSP();
                foreach (KhachHangBEL employee in allEmployees)
                {
                    dgvkhach.Rows.Add(employee.MaKhachHang, employee.Ten, employee.DiaChi, employee.DienThoai);
                }
            }


            lbtenhang.Clear();
            textBox1.Clear();
            tbhangton.Clear();
            lbmh.Clear();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            KhachHangBEL nv = new KhachHangBEL();

            nv.MaKhachHang = lbmh.Text;
            nv.Ten = lbtenhang.Text;

            nv.DiaChi = tbhangton.Text;
            nv.DienThoai = textBox1.Text;






            KHBAL.DeletNV(nv);


            int idx = dgvkhach.CurrentCell.RowIndex;
            dgvkhach.Rows.RemoveAt(idx);


            dgvkhach.Rows.Clear();

            // Lấy danh sách tất cả sản phẩm từ cơ sở dữ liệu bằng cách gọi phương thức GetAllProducts() từ lớp SPBAL
            List<KhachHangBEL> allProducts = KHBAL.ReadSP();

            // Thêm lại tất cả sản phẩm vào DataGridView
            foreach (KhachHangBEL product in allProducts)
            {
                dgvkhach.Rows.Add(product.MaKhachHang, product.Ten, product.DiaChi, product.DienThoai);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvkhach_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dgv && dgv.CurrentRow != null)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv.Rows.Count)
                {
                    DataGridViewRow row = dgv.Rows[e.RowIndex];
                    // Lấy thông tin từ hàng hiện tại và hiển thị lên các điều khiển
                    lbmh.Text = row.Cells[0].Value?.ToString();
                    lbtenhang.Text = row.Cells[1].Value?.ToString();

                    tbhangton.Text = row.Cells[2].Value?.ToString();
                    textBox1.Text = row.Cells[3].Value?.ToString();



                }
            }


        }
    }
}
