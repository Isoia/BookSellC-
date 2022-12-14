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
    public partial class AdminSignup : Form
    {
        public string server = "localhost";
        public int port = 3306;
        public string db = "bookselldb";
        public string id = "root";
        public string pw = "1234";
        public string connectAddress = "";
        public AdminSignup()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string pw = pwTextBox.Text;
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from adminlist where adminid like @var1";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", id);

                MySqlDataReader table = cmd.ExecuteReader();

                if (table.HasRows)
                {
                    MessageBox.Show("중복된 아이디입니다!");
                    table.Close();
                }
                else
                {
                    table.Close();
                    sql = "insert into adminlist values (@var1,@var2)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@var1", id);
                    cmd.Parameters.AddWithValue("@var2", pw);

                    if(cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("등록 성공!");
                    }
                    else
                    {
                        MessageBox.Show("등록 실패");
                    }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin av = new AdminLogin();
            av.ShowDialog();
            this.Close();
        }

        private void AdminSignup_Load(object sender, EventArgs e)
        {
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
        }
    }
}
