﻿namespace DO_AN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btTk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btMk = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbqmk = new System.Windows.Forms.Label();
            this.btexit = new System.Windows.Forms.Button();
            this.cluu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // btTk
            // 
            this.btTk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTk.Location = new System.Drawing.Point(255, 92);
            this.btTk.Name = "btTk";
            this.btTk.Size = new System.Drawing.Size(334, 27);
            this.btTk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(148, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // btMk
            // 
            this.btMk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMk.Location = new System.Drawing.Point(255, 153);
            this.btMk.Name = "btMk";
            this.btMk.Size = new System.Drawing.Size(334, 29);
            this.btMk.TabIndex = 3;
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(255, 262);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(116, 34);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "Đăng Nhập";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(347, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // lbqmk
            // 
            this.lbqmk.AutoSize = true;
            this.lbqmk.BackColor = System.Drawing.SystemColors.Control;
            this.lbqmk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbqmk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbqmk.Location = new System.Drawing.Point(469, 209);
            this.lbqmk.Name = "lbqmk";
            this.lbqmk.Size = new System.Drawing.Size(120, 20);
            this.lbqmk.TabIndex = 8;
            this.lbqmk.Text = "Quên mật khẩu ?";
            this.lbqmk.Click += new System.EventHandler(this.lbqmk_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(479, 262);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(110, 31);
            this.btexit.TabIndex = 9;
            this.btexit.Text = "Thoát";
            this.btexit.UseVisualStyleBackColor = true;
            // 
            // cluu
            // 
            this.cluu.AutoSize = true;
            this.cluu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cluu.Location = new System.Drawing.Point(255, 209);
            this.cluu.Name = "cluu";
            this.cluu.Size = new System.Drawing.Size(119, 24);
            this.cluu.TabIndex = 10;
            this.cluu.Text = "Lưu Mật Khẩu";
            this.cluu.UseVisualStyleBackColor = true;
            this.cluu.CheckedChanged += new System.EventHandler(this.cluu_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cluu);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.lbqmk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.btMk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox btTk;
        private Label label2;
        private TextBox btMk;
        private Button btlogin;
        private Label label3;
        private Label lbqmk;
        private Button btexit;
        private CheckBox cluu;
    }
}