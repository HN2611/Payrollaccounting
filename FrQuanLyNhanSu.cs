using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace G215HTHN_SalaryGC
{
    public partial class FrQuanLyNhanSu : Form
    {
        static string app_dir = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\Media\\";
        //static không bị giải phóng vùng nhớ
        static Boolean pic_selected = false;//giữ lại hình cũ hay chưa chọn hình
        public FrQuanLyNhanSu()
        {
            InitializeComponent();
            //User ID=sa;
            //Password=123
        }

        private void FrQuanLyNhanSu_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the '_1G215HTHNSalaryGCPB.PhongBan' table. You can move, or remove it, as needed.
            
            //tải ds phòng ban, ngạch, nhân viên vào form
            this.phongBanTableAdapter1.Fill(this._1G215HTHNSalaryGCDataSet5.PhongBan);
            this.ngachTableAdapter.Fill(this._1G215HTHNSalaryGCNgach_NS.Ngach);
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_Bac_NS.Bac' table. You can move, or remove it, as needed.
            this.bacTableAdapter.Fill(this._1G215HTHNSalaryGC_Bac_NS.Bac);
          
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGCNgach_NS.Ngach' table. You can move, or remove it, as needed.
            try
            {
                this.nVTableAdapter.Fill(this._1G215HTHNSalaryGCDSetNV.NV,comboBoxPhongBan.SelectedValue.ToString().Trim());
            }
            catch (System.Exception){}

            
   
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGCDataSet5.PhongBan' table. You can move, or remove it, as needed.
            
        }
        //tự chạy khi người sử dụng thay đổi lựa chọn trong combobox nhóm
        private void comboBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                this.nVTableAdapter.Fill(this._1G215HTHNSalaryGCDSetNV.NV, comboBoxPhongBan.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            DialogResult ct = MessageBox.Show("Bạn muốn về màn hình chính?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ct == DialogResult.Yes)
            { this.Close(); }
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {//B1 thêm nhân sự
            textBox1.Enabled = !textBox1.Enabled;
            textBoxdiachi.Enabled = !textBoxdiachi.Enabled;
            textBoxcmnd.Enabled = !textBoxcmnd.Enabled;
            textBoxgioitinh.Enabled = !textBoxgioitinh.Enabled;
           
            textBoxsdt.Enabled = !textBoxsdt.Enabled;
            textBoxghichu.Enabled = !textBoxghichu.Enabled;
            textBoxmanv.Enabled = !textBoxmanv.Enabled;
            comboBoxNgach.Enabled = !comboBoxNgach.Enabled;
            comboBoxBac.Enabled = !comboBoxBac.Enabled;
            dateTimePicker1.Enabled = !dateTimePicker1.Enabled;
            //B2:
            buttonsua.Enabled = !buttonsua.Enabled;
            buttonxoa.Enabled = !buttonxoa.Enabled;
            buttonchuyen.Enabled = !buttonchuyen.Enabled;
           
            //B3
            if(buttonthem.Text.Trim()== "Thêm Nhân Sự")
            {
                textBox1.Text = "";
                textBoxdiachi.Text = "";
                textBoxcmnd.Text = "";
                textBoxgioitinh.Text = "";
                
                textBoxsdt.Text = "";
                textBoxmanv.Text = "";

                MessageBox.Show("Bạn điền thông tin mới vào các ô dữ liệu trong phần chi tiết nhân sự (góc trên bên phải màn hình)");
                //đổi nhãn
                //thông báo gán Picture hình
                pictureBoxhinh.ImageLocation = app_dir + "hinhmau.png";
                pictureBoxhinh.Click += new EventHandler(pictureBoxhinh_Click);
                
                buttonthem.Text = "Lưu Nhân Sự";
            }    
            else
            {
            
                try
                {
                    if (!pic_selected) app_dir = "";
                    nVTableAdapter.Insert(textBoxmanv.Text.Trim(), textBox1.Text, textBoxdiachi.Text, textBoxcmnd.Text.Trim(), textBoxgioitinh.Text.Trim(),textBoxsdt.Text.Trim(), comboBoxNgach.SelectedValue.ToString().Trim(), comboBoxBac.SelectedValue.ToString().Trim(),comboBoxPhongBan.SelectedValue.ToString().Trim(), textBoxghichu.Text, DateTime.Parse(dateTimePicker1.Value.ToShortDateString()), app_dir);
                    MessageBox.Show("Thêm Xong!");
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi " + ex.Message); }
                
                buttonthem.Text = "Thêm nhân sự mới";
                try
                {
                    this.nVTableAdapter.Fill(this._1G215HTHNSalaryGCDSetNV.NV, comboBoxPhongBan.SelectedValue.ToString().Trim());
                }
                catch (System.Exception) { }
                //khóa chọn hình
                //Chưa xử lý
                pictureBoxhinh.Click += null;
            }

        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            
                //B1 Đóng mở
                textBox1.Enabled = !textBox1.Enabled;
                textBoxdiachi.Enabled = !textBoxdiachi.Enabled;
                textBoxcmnd.Enabled = !textBoxcmnd.Enabled;
                textBoxgioitinh.Enabled = !textBoxgioitinh.Enabled;
            comboBoxNgach.Enabled = !comboBoxNgach.Enabled;
            comboBoxBac.Enabled = !comboBoxBac.Enabled;
                textBoxsdt.Enabled = !textBoxsdt.Enabled;
                textBoxghichu.Enabled = !textBoxghichu.Enabled;
      
            dateTimePicker1.Enabled = !dateTimePicker1.Enabled;
                //textBoxmanv.Enabled = !textBoxmanv.Enabled;
                //Nút lệnh
                buttonthem.Enabled = !buttonthem.Enabled;
                buttonxoa.Enabled = !buttonxoa.Enabled;
                buttonchuyen.Enabled = !buttonchuyen.Enabled;
            

            // B2 đổi nhãn
            if (buttonsua.Text.Trim() == "Chỉnh Sửa Nhân Sự")
            {
                MessageBox.Show("Bạn sửa thông tin vào các ô dữ liệu trong phần chi tiết nhân sự (góc trên bên phải màn hình)");
                if (!pic_selected) app_dir = pictureBoxhinh.ImageLocation;
                pictureBoxhinh.ImageLocation = app_dir + "hinhmau.png";
                pictureBoxhinh.Click += new EventHandler(pictureBoxhinh_Click);
                //đổi nhãn
                buttonsua.Text = "Lưu Nhân Sự Sau Khi Sửa";
            }
            else
            {
                try
                {
                    nVTableAdapter.Update(textBox1.Text, textBoxdiachi.Text, textBoxcmnd.Text.Trim(), textBoxgioitinh.Text, textBoxsdt.Text,
                     textBoxghichu.Text, app_dir, dateTimePicker1.Value.ToShortDateString(), comboBoxBac.SelectedValue.ToString().Trim(), comboBoxNgach.SelectedValue.ToString().Trim(), textBoxmanv.Text);
                    MessageBox.Show("Sửa Xong!");
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi chưa sửa thông tin mới" + ex.Message); }

                buttonsua.Text = "Chỉnh Sửa Nhân Sự";
                comboBoxPhongBan_SelectedIndexChanged(sender, e);
                pictureBoxhinh.Click += null;
            }

        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            //B1 hỏi xác nhận
            DialogResult ch = MessageBox.Show("Có muốn xóa Nhân Viên " + textBoxmanv.Text.Trim() + "Có Không", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    nVTableAdapter.Delete(textBoxmanv.Text.Trim());
                    MessageBox.Show("Xóa Xong");
                }
                catch (System.Exception ex) 
                {
                    MessageBox.Show("Có lỗi khi xóa nhân sự do ràng buộc toàn vẹn dữ liệu" + ex.Message);
                    FrXLRBTV fr = new FrXLRBTV(textBoxmanv.Text.Trim(), textBox1.Text.Trim());
                    fr.ShowDialog();
                };
            }
            comboBoxPhongBan_SelectedIndexChanged(sender, e);
        }

        private void pictureBoxhinh_Click(object sender, EventArgs e)
        {

            pic_selected = false;
            app_dir = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\Media\\";
            DialogResult ch = openFileDialoghinh.ShowDialog();//mở hộp thoại 
            if (ch == DialogResult.OK)
            {
                //B1: gán hình vào đường dẫn media
                app_dir = Path.GetFileName(openFileDialoghinh.FileName);
                if (File.Exists(app_dir))
                {
                    DialogResult c = MessageBox.Show("Đã có sẵn file hình. Có muốn hình mới? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   
                    if (c == DialogResult.Yes)
                    {

                        File.Copy(openFileDialoghinh.FileName, app_dir, true);//copy file hình
                        MessageBox.Show("Đã tải lên xong!");
                    }
                    else
                    {
                        MessageBox.Show("Sử dụng hình đã có sẵn");
                    }

                }
                else
                {
                    File.Copy(openFileDialoghinh.FileName, app_dir);
                }

                //ghi nhận đã chọn kể cả hình cũ đã có trong thư mục\ Media
                pic_selected = true;
            }
        }

        private void buttonchuyen_Click(object sender, EventArgs e)
        {
            FrChuyenPhongBan fr = new FrChuyenPhongBan();
            fr.ShowDialog();
        }
    }
}
    


