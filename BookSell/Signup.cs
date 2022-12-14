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
    public partial class Signup : Form
    {
        public string server = "localhost";
        public int port = 3306;
        public string db = "bookselldb";
        public string id = "root";
        public string pw = "1234";
        public string connectAddress = "";
        public int idCheck = 0;
        public Signup()
        {
            InitializeComponent();
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string memid = textBox1.Text;
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select memid from memberlist where memid = @var1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", memid);
                MySqlDataReader table = cmd.ExecuteReader();

                if(table.Read())
                    MessageBox.Show("중복된 아이디입니다!");
                else if (memid.Equals(""))
                    MessageBox.Show("칸이 공백입니다");

                else
                {
                    MessageBox.Show("사용 가능한 아이디입니다");
                    idCheck = 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(idCheck == 0)
                MessageBox.Show("중복 체크를 수행하고 오세요!");
            else if (textBox1.Text.Equals("")|| textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals(""))
            {

            }
            else
            {
                string memid = textBox1.Text;
                string memname = textBox2.Text;
                string mempw = textBox3.Text;
                string memphone = textBox4.Text;
                string memaddre = textBox5.Text;

                using (MySqlConnection con = new MySqlConnection(connectAddress))
                {
                    con.Open();
                    string sql = "insert into memberlist values(@var1,@var2,@var3,@var4,@var5)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@var1", memid);
                    cmd.Parameters.AddWithValue("@var2", memname);
                    cmd.Parameters.AddWithValue("@var3", mempw);
                    cmd.Parameters.AddWithValue("@var4", memphone);
                    cmd.Parameters.AddWithValue("@var5", memaddre);

                    if (cmd.ExecuteNonQuery() == 0)
                        MessageBox.Show("회원가입 실패");
                    else { 
                        MessageBox.Show("회원가입 성공!");
                        this.Hide();
                        UserLogin uv = new UserLogin();
                        uv.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin uv = new UserLogin();
            uv.ShowDialog();
            this.Close();

        }
    }
}
