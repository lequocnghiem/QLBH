namespace DO_AN
{
    partial class Nhanvien
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvqlsp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tbtenanh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbdongiaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsp)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(309, 648);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 31);
            this.btDelete.TabIndex = 63;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(168, 648);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(96, 31);
            this.btEdit.TabIndex = 62;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(37, 648);
            this.btNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(96, 31);
            this.btNew.TabIndex = 61;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(892, 648);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 31);
            this.button5.TabIndex = 65;
            this.button5.Text = "Quay Lại";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvqlsp
            // 
            this.dgvqlsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dgvqlsp.Location = new System.Drawing.Point(37, 357);
            this.dgvqlsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvqlsp.Name = "dgvqlsp";
            this.dgvqlsp.RowTemplate.Height = 25;
            this.dgvqlsp.Size = new System.Drawing.Size(951, 256);
            this.dgvqlsp.TabIndex = 60;
            this.dgvqlsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqlsp_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Điện Thoại";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Địa Chỉ";
            this.Column7.Name = "Column7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(375, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 32);
            this.label9.TabIndex = 59;
            this.label9.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // tbtenanh
            // 
            this.tbtenanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtenanh.Location = new System.Drawing.Point(738, 105);
            this.tbtenanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbtenanh.Name = "tbtenanh";
            this.tbtenanh.Size = new System.Drawing.Size(206, 27);
            this.tbtenanh.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Địa Chỉ";
            // 
            // tbdongiaban
            // 
            this.tbdongiaban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbdongiaban.Location = new System.Drawing.Point(738, 208);
            this.tbdongiaban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbdongiaban.Name = "tbdongiaban";
            this.tbdongiaban.Size = new System.Drawing.Size(206, 27);
            this.tbdongiaban.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ngày Sinh";
            // 
            // lbtenhang
            // 
            this.lbtenhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtenhang.Location = new System.Drawing.Point(147, 155);
            this.lbtenhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbtenhang.Name = "lbtenhang";
            this.lbtenhang.Size = new System.Drawing.Size(214, 27);
            this.lbtenhang.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // lbmh
            // 
            this.lbmh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbmh.Location = new System.Drawing.Point(145, 105);
            this.lbmh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbmh.Name = "lbmh";
            this.lbmh.Size = new System.Drawing.Size(214, 27);
            this.lbmh.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 219);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 27);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(738, 168);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 24);
            this.checkBox1.TabIndex = 68;
            this.checkBox1.Text = "Nam";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 700);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvqlsp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbtenanh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbdongiaban);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbtenhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbmh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btDelete;
        private Button btEdit;
        private Button btNew;
        private Button button5;
        private DataGridView dgvqlsp;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private Label label9;
        private TextBox tbtenanh;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox tbdongiaban;
        private Label label4;
        private TextBox lbtenhang;
        private Label label2;
        private TextBox lbmh;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
    }
}