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
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }
        //thủ tục gọi form tính công
        
        private void btnTC_Click(object sender, EventArgs e)
        {
            frTinhCong fr = new frTinhCong();
            fr.ShowDialog();
        }
        private void frMain_Load(object sender, EventArgs e)
        {

        }
        //thủ tục tắt chương trình
        private void button1_Click_1(object sender, EventArgs e)
        {
           DialogResult ch= MessageBox.Show("Bạn muốn Thoát?", "Xác Nhận", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            { Application.Exit(); }

        }
        private void btnE_Click(object sender, EventArgs e)
        {//thoát chương trình
            DialogResult ch = MessageBox.Show("Bạn muốn Thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            { Application.Exit(); }
        }
        //thủ tục gọi form Lương

        /// <summary>
        /// CHẠY ĐỒNG HÔ
        /// đều đặn sau Interval thời gian chạy thủ tục này: Interval=100
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //đồng hồ
            toolStripStatusLabel2.Text= lbtime.Text = DateTime.Now.ToLongTimeString();//lấy giờ phút hiện tại
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //bật tắt đồng hồ
            timer1.Enabled = !timer1.Enabled;
        }
        //gọi form nhân viên từ ToolStripMenuItem
        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gọi form quản lý
            FrQuanLyNhanSu fr = new FrQuanLyNhanSu();
            fr.ShowDialog();
        }

        private void chuyểnNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gọi chuyển phòng ban
            FrChuyenPhongBan fr = new FrChuyenPhongBan();
            fr.ShowDialog();
        }

        private void phongban_Click(object sender, EventArgs e)
        {//gọi chuyển phòng ban
            FrChuyenPhongBan fr = new FrChuyenPhongBan();
            fr.ShowDialog();
        }
    }
}
