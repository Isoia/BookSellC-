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
    public partial class UserLogin : Form
    {
        public string server = "localhost";
        public int port = 3306;
        public string db = "bookselldb";
        public string id = "root";
        public string pw = "1234";
        public string connectAddress = "";
        public static string memid;
        public static string memname;

        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pw = textBox2.Text;
            string name;
            int tf = 0;

            using(MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from memberlist where memid = @var1 and mempw = @var2";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", id);
                cmd.Parameters.AddWithValue("@var2", pw);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    if(table["memid"].Equals(id) && table["mempw"].Equals(pw))
                    {
                        name = table["memname"].ToString();
                        tf = 1;
                        MessageBox.Show(name + "님 환영합니다!");
                        memid = id;
                        memname = name;
                        this.Hide();
                        UserBookProgram uv = new UserBookProgram();
                        uv.ShowDialog();
                        this.Close();
                    }
                }

                if(tf != 1)
                {
                    MessageBox.Show("잘못 입력하셨습니다!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
            this.Close();
        }
    }
}
