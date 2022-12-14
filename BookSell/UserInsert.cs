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
    public partial class UserInsert : Form
    {
        public string server = "localhost";
        public int port = 3306;
        public string db = "bookselldb";
        public string id = "root";
        public string pw = "1234";
        public string connectAddress = "";
        public UserInsert()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string sql = "update memberlist set memid = @var1, memname = @var2, mempw = @var3, memphone = @var4, memaddre = @var5 where memid like @var6";
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1",userIdBox.Text);
                cmd.Parameters.AddWithValue("@var2", userNameBox.Text);
                cmd.Parameters.AddWithValue("@var3", userPwBox.Text);
                cmd.Parameters.AddWithValue("@var4", userPhoneBox.Text);
                cmd.Parameters.AddWithValue("@var5", userAddrBox.Text);
                cmd.Parameters.AddWithValue("@var6", userIdBox.Text);

                if(cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("수정 완료!");
                }
                else
                {
                    MessageBox.Show("수정 실패");
                }
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserInsert_Load(object sender, EventArgs e)
        {
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
            userIdBox.Text = AdminBookProgram.insertid;
            userNameBox.Text = AdminBookProgram.insertname;
            userPwBox.Text = AdminBookProgram.insertpw;
            userPhoneBox.Text = AdminBookProgram.insertphone;
            userAddrBox.Text = AdminBookProgram.insertaddre;
        }
    }
}
