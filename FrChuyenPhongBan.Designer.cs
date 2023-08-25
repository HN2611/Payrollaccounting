
namespace G215HTHN_SalaryGC
{
    partial class FrChuyenPhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrChuyenPhongBan));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxS = new System.Windows.Forms.ListBox();
            this.nVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1G215HTHNSalaryGCNV_CPB = new G215HTHN_SalaryGC._1G215HTHNSalaryGCNV_CPB();
            this.comboBoxS = new System.Windows.Forms.ComboBox();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1G215HTHNSalaryGC_PB_S = new G215HTHN_SalaryGC._1G215HTHNSalaryGC_PB_S();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxD = new System.Windows.Forms.ListBox();
            this.nVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._1G215HTHNSalaryGCNV_D = new G215HTHN_SalaryGC._1G215HTHNSalaryGCNV_D();
            this.comboBoxD = new System.Windows.Forms.ComboBox();
            this.phongBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._1G215HTHNSalaryGC_PB_D = new G215HTHN_SalaryGC._1G215HTHNSalaryGC_PB_D();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonARL = new System.Windows.Forms.Button();
            this.buttonALR = new System.Windows.Forms.Button();
            this.buttonRL = new System.Windows.Forms.Button();
            this.buttonLR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nVTableAdapter = new G215HTHN_SalaryGC._1G215HTHNSalaryGCNV_CPBTableAdapters.NVTableAdapter();
            this.nVTableAdapter1 = new G215HTHN_SalaryGC._1G215HTHNSalaryGCNV_DTableAdapters.NVTableAdapter();
            this.phongBanTableAdapter = new G215HTHN_SalaryGC._1G215HTHNSalaryGC_PB_STableAdapters.PhongBanTableAdapter();
            this.phongBanTableAdapter1 = new G215HTHN_SalaryGC._1G215HTHNSalaryGC_PB_DTableAdapters.PhongBanTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1G215HTHNSalaryGCNV_CPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1G215HTHNSalaryGC_PB_S)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1G215HTHNSalaryGCNV_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1G215HTHNSalaryGC_PB_D)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(213, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "G215_HTHN_CHUYỂN PHÒNG BAN CHO NHÂN SỰ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.listBoxS);
            this.groupBox1.Controls.Add(this.comboBoxS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 397);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm Nguồn (Source)";
            // 
            // listBoxS
            // 
            this.listBoxS.DataSource = this.nVBindingSource;
            this.listBoxS.DisplayMember = "tennv";
            this.listBoxS.FormattingEnabled = true;
            this.listBoxS.ItemHeight = 20;
            this.listBoxS.Location = new System.Drawing.Point(10, 96);
            this.listBoxS.Name = "listBoxS";
            this.listBoxS.Size = new System.Drawing.Size(405, 264);
            this.listBoxS.TabIndex = 2;
            this.listBoxS.ValueMember = "msnv";
            // 
            // nVBindingSource
            // 
            this.nVBindingSource.DataMember = "NV";
            this.nVBindingSource.DataSource = this._1G215HTHNSalaryGCNV_CPB;
            // 
            // _1G215HTHNSalaryGCNV_CPB
            // 
            this._1G215HTHNSalaryGCNV_CPB.DataSetName = "_1G215HTHNSalaryGCNV_CPB";
            this._1G215HTHNSalaryGCNV_CPB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxS
            // 
            this.comboBoxS.DataSource = this.phongBanBindingSource;
            this.comboBoxS.DisplayMember = "tenphongban";
            this.comboBoxS.FormattingEnabled = true;
            this.comboBoxS.Location = new System.Drawing.Point(192, 31);
            this.comboBoxS.Name = "comboBoxS";
            this.comboBoxS.Size = new System.Drawing.Size(212, 28);
            this.comboBoxS.TabIndex = 1;
            this.comboBoxS.ValueMember = "maphongban";
            this.comboBoxS.SelectedIndexChanged += new System.EventHandler(this.comboBoxS_SelectedIndexChanged);
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this._1G215HTHNSalaryGC_PB_S;
            // 
            // _1G215HTHNSalaryGC_PB_S
            // 
            this._1G215HTHNSalaryGC_PB_S.DataSetName = "_1G215HTHNSalaryGC_PB_S";
            this._1G215HTHNSalaryGC_PB_S.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách phòng ban nguồn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn phòng ban nguồn:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.listBoxD);
            this.groupBox2.Controls.Add(this.comboBoxD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(601, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 397);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhóm Đích (Destination)";
            // 
            // listBoxD
            // 
            this.listBoxD.DataSource = this.nVBindingSource1;
            this.listBoxD.DisplayMember = "tennv";
            this.listBoxD.FormattingEnabled = true;
            this.listBoxD.ItemHeight = 20;
            this.listBoxD.Location = new System.Drawing.Point(28, 96);
            this.listBoxD.Name = "listBoxD";
            this.listBoxD.Size = new System.Drawing.Size(405, 264);
            this.listBoxD.TabIndex = 2;
            this.listBoxD.ValueMember = "msnv";
            // 
            // nVBindingSource1
            // 
            this.nVBindingSource1.DataMember = "NV";
            this.nVBindingSource1.DataSource = this._1G215HTHNSalaryGCNV_D;
            // 
            // _1G215HTHNSalaryGCNV_D
            // 
            this._1G215HTHNSalaryGCNV_D.DataSetName = "_1G215HTHNSalaryGCNV_D";
            this._1G215HTHNSalaryGCNV_D.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxD
            // 
            this.comboBoxD.DataSource = this.phongBanBindingSource1;
            this.comboBoxD.DisplayMember = "tenphongban";
            this.comboBoxD.FormattingEnabled = true;
            this.comboBoxD.Location = new System.Drawing.Point(231, 34);
            this.comboBoxD.Name = "comboBoxD";
            this.comboBoxD.Size = new System.Drawing.Size(202, 28);
            this.comboBoxD.TabIndex = 1;
            this.comboBoxD.ValueMember = "maphongban";
            this.comboBoxD.SelectedIndexChanged += new System.EventHandler(this.comboBoxD_SelectedIndexChanged);
            // 
            // phongBanBindingSource1
            // 
            this.phongBanBindingSource1.DataMember = "PhongBan";
            this.phongBanBindingSource1.DataSource = this._1G215HTHNSalaryGC_PB_D;
            // 
            // _1G215HTHNSalaryGC_PB_D
            // 
            this._1G215HTHNSalaryGC_PB_D.DataSetName = "_1G215HTHNSalaryGC_PB_D";
            this._1G215HTHNSalaryGC_PB_D.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách phòng ban kết thúc: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn phòng ban kết thúc: ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.buttonARL);
            this.groupBox3.Controls.Add(this.buttonALR);
            this.groupBox3.Controls.Add(this.buttonRL);
            this.groupBox3.Controls.Add(this.buttonLR);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(450, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 397);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuyển Đổi";
            // 
            // buttonARL
            // 
            this.buttonARL.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonARL.Location = new System.Drawing.Point(28, 320);
            this.buttonARL.Name = "buttonARL";
            this.buttonARL.Size = new System.Drawing.Size(62, 40);
            this.buttonARL.TabIndex = 3;
            this.buttonARL.Text = "<<";
            this.buttonARL.UseVisualStyleBackColor = false;
            this.buttonARL.Click += new System.EventHandler(this.buttonARL_Click);
            // 
            // buttonALR
            // 
            this.buttonALR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonALR.Location = new System.Drawing.Point(28, 274);
            this.buttonALR.Name = "buttonALR";
            this.buttonALR.Size = new System.Drawing.Size(62, 40);
            this.buttonALR.TabIndex = 3;
            this.buttonALR.Text = ">>";
            this.buttonALR.UseVisualStyleBackColor = false;
            this.buttonALR.Click += new System.EventHandler(this.buttonALR_Click);
            // 
            // buttonRL
            // 
            this.buttonRL.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonRL.Location = new System.Drawing.Point(28, 73);
            this.buttonRL.Name = "buttonRL";
            this.buttonRL.Size = new System.Drawing.Size(62, 40);
            this.buttonRL.TabIndex = 3;
            this.buttonRL.Text = "<";
            this.buttonRL.UseVisualStyleBackColor = false;
            this.buttonRL.Click += new System.EventHandler(this.buttonRL_Click);
            // 
            // buttonLR
            // 
            this.buttonLR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLR.Location = new System.Drawing.Point(28, 27);
            this.buttonLR.Name = "buttonLR";
            this.buttonLR.Size = new System.Drawing.Size(62, 40);
            this.buttonLR.TabIndex = 3;
            this.buttonLR.Text = ">";
            this.buttonLR.UseVisualStyleBackColor = false;
            this.buttonLR.Click += new System.EventHandler(this.buttonLR_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Location = new System.Drawing.Point(267, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Về màn hình chính";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_thoat);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(601, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát chương trình";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonThoatchuongtrinh_Click);
            // 
            // nVTableAdapter
            // 
            this.nVTableAdapter.ClearBeforeFill = true;
            // 
            // nVTableAdapter1
            // 
            this.nVTableAdapter1.ClearBeforeFill = true;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // phongBanTableAdapter1
            // 
            this.phongBanTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1007, 488);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FrChuyenPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1067, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrChuyenPhongBan";
            this.Text = "Chuyển Phòng Ban";
            this.Load += new System.EventHandler(this.FrChuyenPhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1G215HTHNSalaryGCNV_CPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1G215HTHNSalaryGC_PB_S)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1G215HTHNSalaryGCNV_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1G215HTHNSalaryGC_PB_D)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonARL;
        private System.Windows.Forms.Button buttonALR;
        private System.Windows.Forms.Button buttonRL;
        private System.Windows.Forms.Button buttonLR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private _1G215HTHNSalaryGCNV_CPB _1G215HTHNSalaryGCNV_CPB;
        private System.Windows.Forms.BindingSource nVBindingSource;
        private _1G215HTHNSalaryGCNV_CPBTableAdapters.NVTableAdapter nVTableAdapter;
        private _1G215HTHNSalaryGCNV_D _1G215HTHNSalaryGCNV_D;
        private System.Windows.Forms.BindingSource nVBindingSource1;
        private _1G215HTHNSalaryGCNV_DTableAdapters.NVTableAdapter nVTableAdapter1;
        private _1G215HTHNSalaryGC_PB_S _1G215HTHNSalaryGC_PB_S;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private _1G215HTHNSalaryGC_PB_STableAdapters.PhongBanTableAdapter phongBanTableAdapter;
        private _1G215HTHNSalaryGC_PB_D _1G215HTHNSalaryGC_PB_D;
        private System.Windows.Forms.BindingSource phongBanBindingSource1;
        private _1G215HTHNSalaryGC_PB_DTableAdapters.PhongBanTableAdapter phongBanTableAdapter1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}