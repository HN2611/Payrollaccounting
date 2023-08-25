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
    public partial class FrChuyenPhongBan : Form
    {
        public FrChuyenPhongBan()
        {
            InitializeComponent();
        }

        

        private void comboBoxS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.nVTableAdapter.Fill(this._1G215HTHNSalaryGCNV_CPB.NV, comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            if (comboBoxS.SelectedValue.ToString().Trim() == comboBoxD.SelectedValue.ToString().Trim())
            //GIỐNG NHAU
            {//Không có gì để Chuyển Nhóm 
                buttonLR.Enabled = false;
                buttonRL.Enabled = false;
                buttonALR.Enabled = false;
                buttonARL.Enabled = false;
                MessageBox.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.");
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxS);
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxD);
            }
            else// 2 Combobox Nhóm đã chọn Khác nhau: Chuyển nhóm được 
            {//chuyển nhóm được
                buttonLR.Enabled = true;
                buttonRL.Enabled = true;
                buttonALR.Enabled = true;
                buttonARL.Enabled = true;
                toolTip1.Show("", comboBoxS);
                toolTip1.Show("", comboBoxD);
            }
        }

        private void comboBoxD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.nVTableAdapter1.Fill(this._1G215HTHNSalaryGCNV_D.NV, comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            if (comboBoxS.SelectedValue.ToString().Trim() == comboBoxD.SelectedValue.ToString().Trim())
            //GIỐNG NHAU
            {//Không có gì để Chuyển Nhóm 
                buttonLR.Enabled = false;
                buttonRL.Enabled = false;
                buttonALR.Enabled = false;
                buttonARL.Enabled = false;
                MessageBox.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.");
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxS);
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxD);
            }
            else// 2 Combobox Nhóm đã chọn Khác nhau: Chuyển nhóm được 
            {//chuyển nhóm được
                buttonLR.Enabled = true;
                buttonRL.Enabled = true;
                buttonALR.Enabled = true;
                buttonARL.Enabled = true;
                toolTip1.Show("", comboBoxS);
                toolTip1.Show("", comboBoxD);
            }
        }
        private void FrChuyenPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_PB_D.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter1.Fill(this._1G215HTHNSalaryGC_PB_D.PhongBan);
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGC_PB_S.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this._1G215HTHNSalaryGC_PB_S.PhongBan);
            // TODO: This line of code loads data into the '_1G215HTHNSalaryGCNV_D.NV' table. You can move, or remove it, as needed.
            try
            {
                this.nVTableAdapter.Fill(this._1G215HTHNSalaryGCNV_CPB.NV, comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.nVTableAdapter1.Fill(this._1G215HTHNSalaryGCNV_D.NV, comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }

            // TODO: This line of code loads data into the '_1G215HTHNSalaryGCNV_CPB.NV' table. You can move, or remove it, as neede
            if (comboBoxS.SelectedValue.ToString().Trim() == comboBoxD.SelectedValue.ToString().Trim())
            //GIỐNG NHAU
            {//Không có gì để Chuyển Nhóm 
                buttonLR.Enabled = false;
                buttonRL.Enabled = false;
                buttonALR.Enabled = false;
                buttonARL.Enabled = false;
                MessageBox.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.");
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxS);
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxD);
            }
            else// 2 Combobox Nhóm đã chọn Khác nhau: Chuyển nhóm được 
            {//chuyển nhóm được
                buttonLR.Enabled = true;
                buttonRL.Enabled = true;
                buttonALR.Enabled = true;
                buttonARL.Enabled = true;
                toolTip1.Show("", comboBoxS);
                toolTip1.Show("", comboBoxD);
            }

        }

        private void button1_thoat(object sender, EventArgs e)
        {
            {
                DialogResult ch = MessageBox.Show("Bạn muốn đóng màn hình?", "Xác nhận",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes) { this.Close(); }
            }

        }

        private void buttonThoatchuongtrinh_Click(object sender, EventArgs e)
        {
            {
                DialogResult ch = MessageBox.Show("Thoát chương trình (Y/N)?", "Xác nhận",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes) { Application.Exit(); }

            }
        }

        private void buttonLR_Click(object sender, EventArgs e)
        {

            try
            {
                nVTableAdapter.Update(comboBoxD.SelectedValue.ToString().Trim(), listBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi chuyển 1 MH L=>R" + ex.Message); }
            try
            {
                this.nVTableAdapter.Fill(this._1G215HTHNSalaryGCNV_CPB.NV,comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.nVTableAdapter1.Fill(this._1G215HTHNSalaryGCNV_D.NV, comboBoxD.SelectedValue.ToString().Trim());

            }
            catch (System.Exception) { }

        }

        private void buttonRL_Click(object sender, EventArgs e)
        {
            try
            {
                nVTableAdapter1.Update(comboBoxS.SelectedValue.ToString().Trim(),
                                                 listBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi chuyển 1 nhân sự R=>L" + ex.Message); }
            //B2: Tải 2 danh sách MH lên 2 ListBox (S, D) theo Nhóm MH tương ứng đã chon
            try
            {
                this.nVTableAdapter.Fill(this._1G215HTHNSalaryGCNV_CPB.NV,
                                                      comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.nVTableAdapter1.Fill(this._1G215HTHNSalaryGCNV_D.NV,
                                                        comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }

        }

        private void buttonALR_Click(object sender, EventArgs e)
        {
            try
            {
                nVTableAdapter.UpdateQuery(comboBoxD.SelectedValue.ToString().Trim(),
                                                    comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi chuyển tất cả các nhân sự L=>R" + ex.Message); }
            //B2: Tải 2 danh sách MH lên 2 ListBox (S, D) theo Nhóm MH tương ứng đã chon
            try
            {
                this.nVTableAdapter.Fill(this._1G215HTHNSalaryGCNV_CPB.NV,
                                                      comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.nVTableAdapter1.Fill(this._1G215HTHNSalaryGCNV_D.NV,
                                                        comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }

        }

        private void buttonARL_Click(object sender, EventArgs e)
        {
            try
            {
                nVTableAdapter1.UpdateQuery(comboBoxS.SelectedValue.ToString().Trim(),
                                                       comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi chuyển tất cả các nhân sự R=>L" + ex.Message); }

            //B2: Tải 2 danh sách MH lên 2 ListBox (S, D) theo Nhóm MH tương ứng đã chon
            try
            {
                this.nVTableAdapter.Fill(this._1G215HTHNSalaryGCNV_CPB.NV,
                                                      comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.nVTableAdapter1.Fill(this._1G215HTHNSalaryGCNV_D.NV,
                                                        comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }

        }
    }
}
