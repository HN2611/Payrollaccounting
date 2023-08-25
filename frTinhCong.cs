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
    public partial class frTinhCong : Form
    {
        public frTinhCong()
        {
            InitializeComponent();
        }
        static DataTable b = new DataTable(); // lưu thông tin chi tiết của tính công
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tc = MessageBox.Show("Bạn muốn về màn hình chính?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tc == DialogResult.Yes)
            { this.Close(); }
        }
        private void BCheck()

        {   //CHO LẬP HÓA ĐƠN OR CHUYỂN CÔNG NƠ (PHẢI THU) NẾU NHƯ BILL CÓ ÍT NHẤT 1 MỘT MH 

            if (dataGridViewTC.Rows.Count > 1)
            {

                btnPL.Visible = true;

                buttondel.Visible = true;

                buttonChuyenTC.Visible = true;
            }

            else

            { 
                btnPL.Visible = false;

                buttondel.Visible = false;

                buttonChuyenTC.Visible = false;


            }

        }//Bcheck 
        private void frTinhCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_ChamCong_TC.ChamCong' table. You can move, or remove it, as needed.
           
            this.kiChamCongTableAdapter.Fill(this._1G215HTHNSalaryGCKiCong.KiChamCong);

            // TODO: This line of code loads data into the '_1G215HTHNSalaryGCPhongBan_TC.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this._1G215HTHNSalaryGCPhongBan_TC.PhongBan);
            this.nVTableAdapter1.Fill(this._1G215HTHNSalaryGC_NV01.NV, comboBoxNV.SelectedValue.ToString().Trim());
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_ChamCongTC.ChamCong' table. You can move, or remove it, as needed.
            this.chamCongTableAdapter.Fill(this._1G215HTHNSalaryGC_ChamCong_TC.ChamCong, comboBoxNV.SelectedValue.ToString().Trim());
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGCngaycong.Ngay_Cong' table. You can move, or remove it, as needed.
            this.ngay_CongTableAdapter.Fill(this._1G215HTHNSalaryGCngaycong.Ngay_Cong);
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGCKiCong.KiChamCong' table. You can move, or remove it, as needed.
           
            // Định nghĩa biến toàn cục 

            try
            {
                this.ngayCongTableAdapter.Fill(this._1G215HTHNSalaryGC_NgayCong.NgayCong);
            }

            catch (System.Exception) { }
            b.Rows.Clear();//Xóa ALL dòng rác 

            b.Columns.Clear();//Xóa ALL cột rác 
            b.Columns.Add("msnv", typeof(string));
            b.Columns.Add("msngaycong", typeof(string));

            b.Columns.Add("ngaythangnam", typeof(DateTime));

            b.Columns.Add("tennv", typeof(string)); //Đa số bài của sv là Int32 

            b.Columns.Add("giocong", typeof(float));
            b.Columns.Add("giotangca", typeof(int));
            b.Columns.Add("sogiolamviec", typeof(float),"giocong + giotangca");
            BCheck();
            

        }
       
        
       
        
        private void comboBoxNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                this.nVTableAdapter1.Fill(this._1G215HTHNSalaryGC_NV01.NV, comboBoxNV.SelectedValue.ToString().Trim());
                this.chamCongTableAdapter.Fill(this._1G215HTHNSalaryGC_ChamCong_TC.ChamCong, textBoxMaNV.Text.Trim());
            }
            catch (System.Exception) { };

        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            frLuong lg = new frLuong(b);
            lg.ShowDialog();
        }
        static int vt = 0;

        private void dataGridViewChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
        }
        //static int d = 0;
        private void dGVNgayCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.chamCongTableAdapter.Fill(this._1G215HTHNSalaryGC_ChamCong_TC.ChamCong, textBoxMaNV.Text.Trim());
        }




        static int pos= 0;
        private void dataGridViewTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = e.RowIndex;
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            

            if (dataGridViewChamCong.Rows.Count>1)
            {
                DataGridViewRow h = dataGridViewChamCong.Rows[vt];
                foreach (DataRow r in b.Rows)
                {
                    
                    if (r["msnv"].ToString().Trim() == h.Cells[0].Value.ToString().Trim() && r["ngaythangnam"].ToString().Trim() == dateTimePickerCC.Value.ToShortDateString().ToString().Trim())
                    {
                        try
                        {
                            r["giocong"] = (float)r["giocong"] + float.Parse(textBoxhr.Text.Trim());
                            r["giotangca"] = (int)r["giotangca"] + int.Parse(textBoxtangca.Text.Trim());
                        }
                        catch (System.Exception) { MessageBox.Show("Một ngày chỉ được chấm một lần"); };
                        
                        goto kt;
                    }
                    
                }
            kt:;
                try
                {
                    b.Rows.Add(labelmapb.Text.ToString().Trim(), labelngaycong.Text.ToString().Trim(), DateTime.Parse(dateTimePickerCC.Value.ToShortDateString().ToString().Trim()), textBoxTenNV.Text.Trim(), float.Parse(h.Cells[2].Value.ToString().Trim()), h.Cells[3].Value.ToString().Trim());
                //kt
                    //d += 1;
                    //hr += float.Parse(textBoxhr.Text) + int.Parse(textBoxtangca.Text);

                    ngay_CongTableAdapter.Update(dateTimePickerCC.Value.ToShortDateString(), comboBoxKY.SelectedValue.ToString().Trim());

                    labelSUM.Text = " Số NV: " + b.Compute("Count(msnv)", "") + " người".ToString() + ", TỔNG GIỜ LÀM VIỆC = " + b.Compute("Sum(sogiolamviec)", "") + "giờ";
                    lbtennv.Text = textBoxTenNV.Text;
                    dataGridViewTC.DataSource = b;
                    BCheck();
                }
                catch(System.Exception)
                {
                    MessageBox.Show("Chưa nhập đúng yêu cầu. Xin xem lại!");
                }

               
            }
        
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn muốn xóa nhân viên " + b.Rows[pos]["tennv"].ToString() + " không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)

            {

                b.Rows.RemoveAt(pos);

                //TÍNH LẠI TỒNG SỐ MÓN & TỔNG SỐ TIỀN CỦA BILL 


                labelSUM.Text = " Số NV: " + b.Compute("Count(msnv)", "") + " người".ToString() + ", TỔNG GIỜ LÀM VIỆC = " + b.Compute("Sum(sogiolamviec)", "") + "giờ";

                
                dataGridViewTC.DataSource = b;


                BCheck();

            }
        }

       
    }
}
