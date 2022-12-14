using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookSell
{
    public partial class AdminLogin : Form
    {
        public string server = "localhost";
        public int port = 3306;
        public string db = "bookselldb";
        public string id = "root";
        public string pw = "1234";
        public string connectAddress = "";
        public static string memid;
        public static string memname;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
        }

        private void login_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string pw = pwTextBox.Text;

            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from adminlist where adminid = @var1 and adminpw = @var2";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", id);
                cmd.Parameters.AddWithValue("@var2", pw);
                MySqlDataReader table = cmd.ExecuteReader();

                if (table.HasRows)
                {
                    MessageBox.Show("관리자님 환영합니다");
                    this.Hide();
                    AdminBookProgram bookProgram = new AdminBookProgram();
                    bookProgram.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("로그인에 실패하셨습니다");
                }
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSignup signup = new AdminSignup();
            signup.ShowDialog();
            this.Close();
        }
    }
}
