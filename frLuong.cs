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
    public partial class frLuong : Form
    {
        static DataTable b = new DataTable();
        static Boolean NVChamLuong = false, Phucap=false, khautru=false;
        public frLuong(DataTable tb)
        {
            InitializeComponent();
            b = tb;
        }
      
        
     
        private void frLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_luong_chamluong.Luong' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_NV_CL.NV' table. You can move, or remove it, as needed.
          

           
            this.khauTruTableAdapter.Fill(this._1G215HTHNSalaryGC_LoaiKhauTru.KhauTru);
            
            this.phuCapTableAdapter.Fill(this._1G215HTHNSalaryGC_LoaiPhuCap.PhuCap);
            
            this.chiTietKhauTruTableAdapter.Fill(this._1G215HTHNSalaryGC_KhauTru.ChiTietKhauTru,cbbkhautru.SelectedValue.ToString().Trim());
            try
            {
                this.nVTableAdapter.Fill(this._1G215HTHNSalaryGC_NV_CL.NV);
            }
            catch(System.Exception ex)
            {
                MessageBox.Show("Mở Form Tính Lương ");
            }
            
            this.chiTietPhuCapTableAdapter.Fill(this._1G215HTHNSalaryGC_PhuCap.ChiTietPhuCap,cbbphucap.SelectedValue.ToString().Trim());
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_TL_NV.NV' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this._1G215HTHNSalaryGC_luong_chamluong.Luong);


            cbbnvchamcong_cl_SelectedIndexChanged(sender, e);
            lbday_cl.Text = System.DateTime.Now.ToShortDateString();
           
            lbgio_cl.Text = "Chưa bắt đầu";
            
                if (b != null)
                {
                    dataGridViewTC.DataSource = b;
                    labelsum.Text = " Số NV: " + b.Compute("Count(msnv)", "") + " người".ToString() + ", TỔNG GIỜ LÀM VIỆC = " + b.Compute("Sum(sogiolamviec)", "") + " giờ";
                    
                }
                else MessageBox.Show("Không có dữ liệu!");
            


        }

        private void Salary()
        {
            lb_ml_bl.Visible = true;
            lb_nl_bl.Visible = true;
            lb_luongcanban.Visible = true;
            lb_hesoluong.Visible = true;
            lb_cackhoanCong.Visible = true;
           
            lbml_bl.Visible = true;
            
            DateTime t = System.DateTime.Now;
            lbnl_bl.Text = t.ToShortDateString();
            lbnl_bl.Visible = true;
            txt_lcb_bl.Visible = true;
            txt_hsl_bl.Visible = true;
            lbcong_bl.Visible = true;
            
            lb_sgl_bl.Visible = true;
            
           
            txt_sgl_bl.Visible = true;
            
            btn_lapphieuluong.Visible = true;
            btn_huyphieu.Visible = true;
            lb_cackhoantru.Visible = true;
            lb_luongtra.Visible = true;
            lbtru_bl.Visible = true;
            lbluongtra_bl.Visible = true;
            labelsum.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tc = MessageBox.Show("Bạn muốn về phiếu tính công?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tc == DialogResult.Yes)
            { this.Close(); }
        }
        static int vt = 0;
        
        private void dataGridViewpc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            txtmanv_pc.Text = txttimnv_pc.Text = dataGridViewpc.Rows[vt].Cells[0].Value.ToString().Trim();
            cbbphucap.Text = dataGridViewpc.Rows[vt].Cells[1].Value.ToString().Trim();
            txttienpc.Text = dataGridViewpc.Rows[vt].Cells[2].Value.ToString().Trim();
        }
        
        private void dataGridViewkt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt= e.RowIndex;
            txtmanv_kt.Text = txttimnvkt.Text = dataGridViewkt.Rows[vt].Cells[0].Value.ToString().Trim();
            cbbkhautru.Text = dataGridViewkt.Rows[vt].Cells[1].Value.ToString().Trim();
            txttienkt.Text = dataGridViewkt.Rows[vt].Cells[2].Value.ToString().Trim();
        }

        private void cbbnvchamcong_cl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lbmanv_cl.Text = cbbnvchamcong_cl.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime_cl.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void cbbkhautru_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chiTietKhauTruTableAdapter.Fill(this._1G215HTHNSalaryGC_KhauTru.ChiTietKhauTru, cbbkhautru.SelectedValue.ToString().Trim());
        }
        private void btnchonnv_cl_Click(object sender, EventArgs e)
        {
            btnhuynv_cl.Visible = true;

            cbbnvchamcong_cl.Enabled = false;

            btnchonnv_cl.Enabled = false;

            lbday_cl.Text = System.DateTime.Now.ToShortDateString();

            lbgio_cl.Text= lbtime_cl.Text.Trim();
            NVChamLuong = true;
            if (NVChamLuong && Phucap && khautru) Salary();

        }

        private void btnhuynv_cl_Click(object sender, EventArgs e)
        {
            btnhuynv_cl.Visible = false;

            cbbnvchamcong_cl.Enabled = true;

            btnchonnv_cl.Enabled = true;

            lbday_cl.Text = System.DateTime.Now.ToShortDateString();

            lbgio_cl.Text = "Chưa bắt đầu";
        }

        private void btnyespc_Click(object sender, EventArgs e)
        {
            //Hủy bất cứ lúc nào
            btnhuypc.Visible = true;
            if(btnyespc.Text.Trim()== "Tìm PC")
            {
                try
                {
                    this.chiTietPhuCapTableAdapter.Fill(this._1G215HTHNSalaryGC_PhuCap.ChiTietPhuCap, txttimnv_pc.Text.Trim());

                }
                catch (System.Exception) { };
                //Tìm không có phụ cấp nhập phụ cấp mới
                if(dataGridViewpc.Rows.Count<2)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu. Yêu cầu thêm mới");
                    btnyespc.Text = "Thêm";
                    dataGridViewpc.Visible = false;// ẩn ds phucap, không có dữ liệu không tự ẩn
                }   
                else
                {
                    btnyespc.Text = "Chọn";
                    dataGridViewpc.Visible = true;
                }    
            } else if(btnyespc.Text.Trim()=="Thêm")//nhập thông tin phụ cấp mới
            {
                //hiện các textbox nhập
                lbnhapmnv.Visible = true;
                lbnhappc.Visible = true;
                lbnhaptienpc.Visible = true;
                cbbphucap.Visible = true;
                txttienpc.Visible = true;
                txtmanv_pc.Visible = true;
                //xóa trống
                txtmanv_pc.Text = "";
                txttienpc.Text = "";
                cbbphucap.Text= "";
                txttimnv_pc.Text = "";
                //đổi nhãn lệnh thành lưu
                btnyespc.Text = "Lưu";
            }  else if(btnyespc.Text.Trim()=="Lưu")//lưu thông tin pc mới
            {   
                if(txtmanv_pc.Text!="")
                {
                    try
                    {
                        chiTietPhuCapTableAdapter.Insert(txtmanv_pc.Text, cbbphucap.SelectedValue.ToString().Trim(), double.Parse(txttienpc.Text));
                        MessageBox.Show("Thêm xong");
                        //cho phép chọn
                        txttimnv_pc.Text = txtmanv_pc.Text.Trim();
                        btnyespc.Text = "Chọn";//xử lý bên dưới
                        //khóa textbox
                        txtmanv_pc.Enabled = false;
                        cbbphucap.Enabled = false;
                        txttienpc.Enabled = false;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi" + ex.Message);
                        btnyespc.Text = "Thêm";
                    }
                }
               else
                {
                    MessageBox.Show("Phải nhập ít nhất một phụ cấp");
                    btnyespc.Text = "Thêm";
                }    
                
            }  else if(btnyespc.Text.Trim()=="Chọn")

            {
                //Ẩn data
                dataGridViewpc.Visible = false;
                //Khóa các ô thông tin cho hiện lên
              
                txtmanv_pc.Enabled = false;
                cbbphucap.Enabled = false;
                txttienpc.Enabled = false;
                //Hiện lên 
                lbnhapmnv.Visible = true;
                lbnhaptienpc.Visible = true;
                lbnhappc.Visible = true;
                cbbphucap.Visible = true;
                txttienpc.Visible = true;
                txtmanv_pc.Visible = true;
                btnyespc.Enabled = false;
                txttimnv_pc.Enabled = false;

                //Xử lý Invoice
                Phucap = true;
                if (NVChamLuong && Phucap && khautru) Salary();
            }
            lbcong_bl.Text = "+"+txttienpc.Text;
            



        }

        private void cbbphucap_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chiTietPhuCapTableAdapter.Fill(this._1G215HTHNSalaryGC_PhuCap.ChiTietPhuCap, cbbphucap.SelectedValue.ToString().Trim());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnhuypc_Click(object sender, EventArgs e)
        {
            //cho tìm lại
            btnyespc.Enabled = true;
            txttimnv_pc.Text = "";
            btnyespc.Text = "Tìm PC";
            //ẩn các nội dung 
            lbnhapmnv.Visible = false;
            lbnhappc.Visible = false;
            lbnhaptienpc.Visible = false;
            cbbphucap.Visible = false;
            txttienpc.Visible = false;
            txtmanv_pc.Visible = false;
            //xóa trống
            txtmanv_pc.Text = "";
            txttienpc.Text = "";
            cbbphucap.Text = "";
            txttimnv_pc.Text = "";
            dataGridViewpc.Visible = false;
            btnhuypc.Visible = false;
        }

        

        private void btnyeskt_Click(object sender, EventArgs e)
        {
            //Hủy bất cứ lúc nào
            btnhuykt.Visible = true;
            if (btnyeskt.Text.Trim() == "Tìm KT")
            {
                try
                {
                    this.chiTietKhauTruTableAdapter.Fill(this._1G215HTHNSalaryGC_KhauTru.ChiTietKhauTru, txttimnvkt.Text);

                }
                catch (System.Exception) { };
                //Tìm không có phụ cấp nhập phụ cấp mới
                if (dataGridViewkt.Rows.Count < 2)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu. Yêu cầu thêm mới");
                    btnyeskt.Text = "Thêm";
                    dataGridViewkt.Visible = false;// ẩn ds phucap, không có dữ liệu không tự ẩn
                }
                else
                {
                    btnyeskt.Text = "Chọn";
                    dataGridViewkt.Visible = true;
                }
            }
            else if (btnyeskt.Text.Trim() == "Thêm")//nhập thông tin phụ cấp mới
            {
                //hiện các textbox nhập
                lbchonnv_kt.Visible = true;
                lb_loaikt.Visible = true;
                lb_tienkt.Visible = true;
                cbbkhautru.Visible = true;
                txttienkt.Visible = true;
                txtmanv_kt.Visible = true;
                //xóa trống
                txtmanv_kt.Text = "";
                txttienkt.Text = "";
                cbbkhautru.Text = "";
                txttimnvkt.Text = "";
                //đổi nhãn lệnh thành lưu
                btnyeskt.Text = "Lưu";
            }
            else if (btnyeskt.Text.Trim() == "Lưu")//lưu thông tin pc mới
            {
                if (txtmanv_kt.Text != "")
                {
                    try
                    {
                        chiTietKhauTruTableAdapter.Insert(txtmanv_kt.Text, cbbkhautru.SelectedValue.ToString().Trim(), double.Parse(txttienkt.Text));
                        MessageBox.Show("Thêm xong");
                        //cho phép chọn
                        txttimnvkt.Text = txtmanv_kt.Text.Trim();
                        btnyespc.Text = "Chọn";//xử lý bên dưới
                        //khóa textbox
                        txtmanv_kt.Enabled = false;
                        cbbkhautru.Enabled = false;
                        txttienkt.Enabled = false;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi" + ex.Message);
                        btnyeskt.Text = "Thêm";
                    }
                }
                else
                {
                    MessageBox.Show("Phải nhập ít nhất một phụ cấp");
                    btnyeskt.Text = "Thêm";
                }

            }
            else if (btnyeskt.Text.Trim() == "Chọn")

            {
                //Ẩn data
                dataGridViewkt.Visible = false;
                //Khóa các ô thông tin cho hiện lên

                txtmanv_kt.Enabled = false;
                cbbkhautru.Enabled = false;
                txttienkt.Enabled = false;
                //Hiện lên 
                lbchonnv_kt.Visible = true;
                lb_loaikt.Visible = true;
                lb_tienkt.Visible = true;
                cbbkhautru.Visible = true;
                txttienkt.Visible = true;
                txtmanv_kt.Visible = true;
                //xóa trống
              

                btnyeskt.Enabled = false;
                txttimnvkt.Enabled = false;

                //Xử lý Invoice
                khautru = true;
                if (NVChamLuong && Phucap && khautru) Salary();
            }

            lbtru_bl.Text = "-" +txttienkt.Text;

        }

        
        private void btn_huyphieu_Click(object sender, EventArgs e)
        {
            txt_lcb_bl.Enabled = !txt_lcb_bl.Enabled;
            txt_hsl_bl.Enabled = !txt_hsl_bl.Enabled;
            txt_sgl_bl.Enabled = !txt_sgl_bl.Enabled;

            txt_lcb_bl.Text = "";
            txt_hsl_bl.Text = "";
            txt_sgl_bl.Text = "";
           
        }

        private void btnhuykt_Click(object sender, EventArgs e)
        {
            btnyeskt.Enabled = true;
            txttimnvkt.Text = "";
            btnyeskt.Text = "Tìm KT";
            //ẩn các nội dung 
            lbchonnv_kt.Visible = false;
            lb_loaikt.Visible = false;
            lb_tienkt.Visible = false;
            cbbkhautru.Visible = false;
            txttienkt.Visible = false;
            txtmanv_kt.Visible = false;
            //xóa trống
            txtmanv_kt.Text = "";
            txttienkt.Text = "";
            cbbkhautru.Text = "";
            txttimnvkt.Text = "";
            dataGridViewkt.Visible = false;
            btnhuykt.Visible = false;
        }

        private void btn_lapphieuluong_Click(object sender, EventArgs e)
        {
            
               
                //Mở Khóa
                txt_lcb_bl.Enabled =! txt_lcb_bl.Enabled;
                txt_hsl_bl.Enabled =! txt_hsl_bl.Enabled;
                txt_sgl_bl.Enabled =! txt_sgl_bl.Enabled;
               //ĐỔi nhãn
               if(btn_lapphieuluong.Text.Trim()== "Lập Phiếu Lương")
                 {
                    btn_lapphieuluong.Text = "Lưu Phiếu";
                  }
               else
                {
                    try
                    {
                        luongTableAdapter.Update(dataGridViewTC.Rows[0].Cells[0].Value.ToString().Trim(), double.Parse(txt_hsl_bl.Text), int.Parse(txt_lcb_bl.Text), int.Parse(lbcong_bl.Text), int.Parse(lbtru_bl.Text), lbml_bl.Text.Trim());
                    lbluongtra_bl.Text = ((double.Parse(txt_lcb_bl.Text) * double.Parse(txt_hsl_bl.Text))+ (double.Parse(txt_lcb_bl.Text)/10* double.Parse(txt_sgl_bl.Text))+double.Parse(txttienpc.Text)-double.Parse(txttienkt.Text)).ToString();

                        MessageBox.Show("Lập thành công!");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi thêm! " + ex.Message);
                    }
                    btn_lapphieuluong.Text = "Lập Phiếu Lương";
                }

                
            
        }
        private void grbbangluong_Enter(object sender, EventArgs e)
        {

        }

        
        //Xác định vị trí chọn

    }
  
}

