

using System.Data.SqlClient;
using static DO_AN.BAL.dangnhap;

namespace DO_AN
{
    public partial class Form1 : Form
    {
        private BusinessLogicLayer businessLogic;

        public Form1()
        {
            InitializeComponent();
            businessLogic = new BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btTk.Text = Properties.Settings.Default.username;
            btMk.Text = Properties.Settings.Default.password;
            if (Properties.Settings.Default.username != "")
            {
                cluu.Checked = true;
            }


        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username = btTk.Text;
            string password = btMk.Text;

            // kiem tra tk mk dung hay k 
            bool isAuthenticated = BusinessLogicLayer.ValidateLoginCredentials(username, password);

            if (isAuthenticated)
            {
                bool isAdmin = businessLogic.IsAdminAccount(username);
                if (isAdmin)
                {
                    MessageBox.Show("dây là admin");
                    Main Main = new Main();
                    Main.ShowDialog();
                }
                else
                {
                    Main Main = new Main();
                    Main.ShowDialog();

                    //giaodien giaodien = new giaodien();
                    //giaodien.ShowDialog();
                }



            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
            }
        }

        private void cluu_CheckedChanged(object sender, EventArgs e)
        {
            if (btTk.Text != "" && btMk.Text != "")
            {
                if (cluu.Checked == true)
                {
                    string users = btTk.Text;
                    string pwd = btMk.Text;
                    Properties.Settings.Default.username = users;
                    Properties.Settings.Default.password = pwd;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }

            }
        }

        private void lbqmk_Click(object sender, EventArgs e)
        {
            QuenTKMK QuenTKMK = new QuenTKMK();
            QuenTKMK.ShowDialog();


            this.Show();
        }
    }
}
