using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G215HTHN_SalaryGC
{
    public partial class FrXLRBTV : Form
    {
        //gán
        static string ms = "";
        static string tennv = "";

       

        //Khởi tạo
        public FrXLRBTV(string msnv, string tennhanvien)
        {
            ms = msnv;
            tennv = tennhanvien;
            InitializeComponent();
        }
        private void FrXLRBTV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_luong01.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter1.Fill(this._1G215HTHNSalaryGC_luong01.Luong,ms);
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_Luong.Luong' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_CTkhautru.ChiTietKhauTru' table. You can move, or remove it, as needed.
            this.chiTietKhauTruTableAdapter.Fill(this._1G215HTHNSalaryGC_CTkhautru.ChiTietKhauTru,ms);
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_CTphucap.ChiTietPhuCap' table. You can move, or remove it, as needed.
            this.chiTietPhuCapTableAdapter.Fill(this._1G215HTHNSalaryGC_CTphucap.ChiTietPhuCap,ms);
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGCKicong.KiChamCong' table. You can move, or remove it, as needed.
            this.kiChamCongTableAdapter.Fill(this._1G215HTHNSalaryGCKicong.KiChamCong);


            try
            {// TODO: This line of code loads data into the '_1G215HTHNSalaryGCLuong.Luong' table. You can move, or remove it, as needed.
               
                this.chamCongTableAdapter.Fill(this._1G215HTHNSalaryGCChamCong_XLRB.ChamCong,ms);
                this.luongTableAdapter1.Fill(this._1G215HTHNSalaryGC_luong01.Luong, ms);


                // TODO: This line of code loads data into the '_1G215HTHNSalaryGCChamCong.ChamCong' table. You can move, or remove it, as needed.

            }
            catch (System.Exception) { }
                label1.Text = "G215_HTHN_Xử Lý Ràng Buộc Khi Giải Quyết Thôi Việc Nhân Sự " + ms + ": " + tennv;
           
        }

        private void btnXL1CC_Click(object sender, EventArgs e)
        {
            if (dataGridViewCC.Rows.Count > 1)
            {
                btnXLnhieuCC.Enabled = true;
                btnXL1CC.Enabled = true;
                DataGridViewRow r = null;
                try
                {
                    r = dataGridViewCC.SelectedRows[0];
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. Trước khi bấm");
                    goto kt;
                }
                DialogResult ch = MessageBox.Show("Xử lý chấm công có mã:" + ms + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        
                        chamCongTableAdapter.Delete(ms,r.Cells[1].Value.ToString().Trim());
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi =" + ex.Message);
                    }
                }
                try
                {// TODO: This line of code loads data into the '_1G215HTHNSalaryGCLuong.Luong' table. You can move, or remove it, as needed

                    // TODO: This line of code loads data into the '_1G215HTHNSalaryGCChamCong.ChamCong' table. You can move, or remove it, as needed.
                    this.chamCongTableAdapter.Fill(this._1G215HTHNSalaryGCChamCong_XLRB.ChamCong, ms);
                }
                catch (System.Exception) { }
            }
           else
            {
                btnXLnhieuCC.Enabled = false;
                btnXL1CC.Enabled = false;
            }
            kt:;
        }

        private void btnXLnhieuCC_Click(object sender, EventArgs e)
        {
            if (dataGridViewCC.Rows.Count > 1)
            {
                btnXLnhieuCC.Enabled = true;
                btnXL1CC.Enabled = true;
                DataGridViewRow r = null;
                try
                {
                    r = dataGridViewCC.SelectedRows[0];
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. Trước khi bấm");
                    goto kt;
                }
                DialogResult ch = MessageBox.Show("Xử lý chấm công có mã:" + ms + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        chamCongTableAdapter.DeleteQuery(ms);
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi =" + ex.Message);
                    }
                }
                try
                {// TODO: This line of code loads data into the '_1G215HTHNSalaryGCLuong.Luong' table. You can move, or remove it, as needed
                    this.chamCongTableAdapter.Fill(this._1G215HTHNSalaryGCChamCong_XLRB.ChamCong, ms);
                    // TODO: This line of code loads data into the '_1G215HTHNSalaryGCChamCong.ChamCong' table. You can move, or remove it, as needed.

                }
                catch (System.Exception) { }
            }
            else
            {
                btnXLnhieuCC.Enabled = false;
                btnXL1CC.Enabled = false;
            }
        kt:;
        }

        private void btnCTO_Click(object sender, EventArgs e)
        {
            if (dataGridViewTL.Rows.Count > 1)
            {
                btnCTO.Enabled = true;
                btnTLA.Enabled = true;
                DataGridViewRow r = null;
                try
                {
                    r = dataGridViewTL.SelectedRows[0];
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. Trước khi bấm");
                    goto kt;
                }
                DialogResult ch = MessageBox.Show("Hủy Lương có mã:" + ms + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        luongTableAdapter1.Delete(ms);
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi =" + ex.Message);
                    }
                }
                try
                {// TODO: This line of code loads data into the '_1G215HTHNSalaryGCLuong.Luong' table. You can move, or remove it, as needed
                    this.luongTableAdapter1.Fill(this._1G215HTHNSalaryGC_luong01.Luong, ms);
                    // TODO: This line of code loads data into the '_1G215HTHNSalaryGCChamCong.ChamCong' table. You can move, or remove it, as needed.

                }
                catch (System.Exception) { }
            }
            else
            {
                btnCTO.Enabled = false;
                btnTLA.Enabled = false;
            }
        kt:;
        }

        private void btnTLA_Click(object sender, EventArgs e)
        {
            if (dataGridViewTL.Rows.Count > 1)
            {
                btnCTO.Enabled = true;
                btnTLA.Enabled = true;
                DataGridViewRow r = null;
                try
                {
                    r = dataGridViewTL.SelectedRows[0];
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. Trước khi bấm");
                    goto kt;
                }
                DialogResult ch = MessageBox.Show("Xử lý lương có mã:" + ms + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        luongTableAdapter1.DeleteQuery(ms);
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi =" + ex.Message);
                    }
                }
                try
                {// TODO: This line of code loads data into the '_1G215HTHNSalaryGCLuong.Luong' table. You can move, or remove it, as needed
                    this.luongTableAdapter1.Fill(this._1G215HTHNSalaryGC_luong01.Luong, ms);
                    // TODO: This line of code loads data into the '_1G215HTHNSalaryGCChamCong.ChamCong' table. You can move, or remove it, as needed.

                }
                catch (System.Exception) { }
            }
            else
            {
                btnCTO.Enabled = false;
                btnTLA.Enabled = false;
            }
        kt:;
        }

        private void btn1pc_Click(object sender, EventArgs e)
        {
            if (dataGridViewpc.Rows.Count > 1)
            {
                btn1pc.Enabled = true;
                btnnhieupc.Enabled = true;
                DataGridViewRow r = null;
                try
                {
                    r = dataGridViewpc.SelectedRows[0];
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. Trước khi bấm");
                    goto kt;
                }
                DialogResult ch = MessageBox.Show("Xử lý chấm công có mã:" + ms + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    try
                    {

                        chiTietPhuCapTableAdapter.Delete(ms, r.Cells[1].Value.ToString().Trim());
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi =" + ex.Message);
                    }
                }
                try
                {// TODO: This line of code loads data into the '_1G215HTHNSalaryGCLuong.Luong' table. You can move, or remove it, as needed

                    // TODO: This line of code loads data into the '_1G215HTHNSalaryGCChamCong.ChamCong' table. You can move, or remove it, as needed.
                    this.chiTietPhuCapTableAdapter.Fill(this._1G215HTHNSalaryGC_CTphucap.ChiTietPhuCap, ms);
                }
                catch (System.Exception) { }
            }
            else
            {
                btn1pc.Enabled = false;
                btnnhieupc.Enabled = false;
            }
        kt:;
        }
    
        private void btnnhieupc_Click(object sender, EventArgs e)
        {
            if (dataGridViewpc.Rows.Count > 1)
            {
                btn1pc.Enabled = true;
                btnnhieupc.Enabled = true;
                DataGridViewRow r = null;
                try
                {
                    r = dataGridViewpc.SelectedRows[0];
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. Trước khi bấm");
                    goto kt;
                }
                DialogResult ch = MessageBox.Show("Xử lý lương có mã:" + ms + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        chiTietPhuCapTableAdapter.DeleteQuery(ms);
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi =" + ex.Message);
                    }
                }
                try
                {
                    this.chiTietPhuCapTableAdapter.Fill(this._1G215HTHNSalaryGC_CTphucap.ChiTietPhuCap, ms);

                }
                catch (System.Exception) { }
            }
            else
            {
                btn1pc.Enabled = false;
                btnnhieupc.Enabled = false;
            }
        kt:;
        }

        private void btn1kt_Click(object sender, EventArgs e)
        {
            if (dataGridViewkt.Rows.Count > 1)
            {
                btn1kt.Enabled = true;
                btnnhieukt.Enabled = true;
                DataGridViewRow r = null;
                try
                {
                    r = dataGridViewkt.SelectedRows[0];
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. Trước khi bấm");
                    goto kt;
                }
                DialogResult ch = MessageBox.Show("Xử lý chấm công có mã:" + ms + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    try
                    {

                        chiTietKhauTruTableAdapter.Delete(ms, r.Cells[1].Value.ToString().Trim());
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi =" + ex.Message);
                    }
                }
                try
                {
                    this.chiTietKhauTruTableAdapter.Fill(this._1G215HTHNSalaryGC_CTkhautru.ChiTietKhauTru, ms);

                }
                catch (System.Exception) { }
            }
            else
            {
                btn1kt.Enabled = false;
                btnnhieukt.Enabled = false;
            }
        kt:;
        }

        private void btnnhieukt_Click(object sender, EventArgs e)
        {
            if (dataGridViewkt.Rows.Count > 1)
            {
                btn1kt.Enabled = true;
                btnnhieukt.Enabled = true;
                DataGridViewRow r = null;
                try
                {
                    r = dataGridViewkt.SelectedRows[0];
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. Trước khi bấm");
                    goto kt;
                }
                DialogResult ch = MessageBox.Show("Xử lý lương có mã:" + ms + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        chiTietKhauTruTableAdapter.DeleteQuery(ms);
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi =" + ex.Message);
                    }
                }
                try
                {
                    this.chiTietKhauTruTableAdapter.Fill(this._1G215HTHNSalaryGC_CTkhautru.ChiTietKhauTru, ms);

                }
                catch (System.Exception) { }
            }
            else
            {
                btn1kt.Enabled = false;
                btnnhieukt.Enabled = false;
            }
        kt:;
        }
        private void btnquayve_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
