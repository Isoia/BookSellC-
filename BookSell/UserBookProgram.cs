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
    public partial class UserBookProgram : Form
    {
        public string server = "localhost";
        public int port = 3306;
        public string db = "bookselldb";
        public string id = "root";
        public string pw = "1234";
        public string connectAddress = "";
        public ListViewItem item;
        public UserBookProgram()
        {
            InitializeComponent();
        }

        private void UserBookProgram_Load(object sender, EventArgs e)
        {
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
            label1.Visible = false;
            textBox1.Visible = false;
            searchBtn.Visible = false;
            SellListView.Visible = false;
            sellBtn.Visible = false;
            listView2.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from booklist";
                MySqlCommand cmd = new MySqlCommand(sql,con);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    item = new ListViewItem(table["booknum"].ToString());
                    item.SubItems.Add(table["bookname"].ToString());
                    item.SubItems.Add(table["bookpub"].ToString());
                    item.SubItems.Add(table["bookprice"].ToString());
                    listView1.Items.Add(item);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
            searchBtn.Visible = false;
            SellListView.Visible = false;
            sellBtn.Visible = false;
            listView2.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            textBox1.Clear();
            label2.Visible = false;
            textBox2.Visible = false;
            listView1.Visible = false;
            SellListView.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            searchBtn.Visible = true;
            sellBtn.Visible = false;
            listView2.Visible = true;
            textBox1.Size = new System.Drawing.Size(272,33);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listView1.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            searchBtn.Visible = false;
            SellListView.Visible = false;
            sellBtn.Visible = true;
            listView2.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            textBox1.Size = new System.Drawing.Size(155, 33);
            listView2.Items.Clear();

            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from booklist";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    item = new ListViewItem(table["booknum"].ToString());
                    item.SubItems.Add(table["bookname"].ToString());
                    item.SubItems.Add(table["bookpub"].ToString());
                    item.SubItems.Add(table["bookprice"].ToString());
                    listView2.Items.Add(item);
                }
                table.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            searchBtn.Visible = false;
            sellBtn.Visible = false;
            listView2.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            SellListView.Visible = true;
            SellListView.Items.Clear();

            string memname = UserLogin.memname;
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select ordernum,bookname,bookcount,bookprice from orderlist where memid = @var1";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", UserLogin.memid);
                MySqlDataReader table = cmd.ExecuteReader();

                if (table.HasRows)
                {
                    while (table.Read())
                    {
                        item = new ListViewItem(table["ordernum"].ToString());
                        item.SubItems.Add(table["bookname"].ToString());
                        item.SubItems.Add(memname);
                        item.SubItems.Add(table["bookcount"].ToString());
                        item.SubItems.Add(table["bookprice"].ToString());
                        SellListView.Items.Add(item);
                    }
                    table.Close();
                }
            }
        }
        private void SellListView_DoubleClick(object sender, EventArgs e)
        {
            if (SellListView.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("구매를 취소하시겠습니까?", "취소창", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
                    using (MySqlConnection con = new MySqlConnection(connectAddress))
                    {
                        con.Open();
                        string sql = "delete from orderlist where ordernum = @var1";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        int selectRow = SellListView.SelectedItems[0].Index;
                        string ordernum = SellListView.Items[selectRow].SubItems[0].Text;
                        cmd.Parameters.AddWithValue("@var1", ordernum);

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("오류 발생!");
                        }
                        else
                        {
                            MessageBox.Show("완료!");
                        }

                        SellListView.Items.Clear();
                        sql = "select ordernum,bookname,bookcount,bookprice from orderlist where memid = @var1";
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@var1", UserLogin.memid);
                        MySqlDataReader table = cmd.ExecuteReader();

                        if (table.HasRows)
                        {
                            while (table.Read())
                            {
                                item = new ListViewItem(table["ordernum"].ToString());
                                item.SubItems.Add(table["bookname"].ToString());
                                item.SubItems.Add(UserLogin.memname);
                                item.SubItems.Add(table["bookcount"].ToString());
                                item.SubItems.Add(table["bookprice"].ToString());
                                SellListView.Items.Add(item);
                            }
                            table.Close();
                        }
                    }
                }
            }
        }
        //아이템 검색
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView2.SelectedItems.Count != 0)
            {
                int selectRow = listView2.SelectedItems[0].Index;

                string bookname = listView2.Items[selectRow].SubItems[1].Text;
                textBox1.Text = bookname;
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from booklist where bookname like @var1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", "%" + textBox1.Text + "%");
                MySqlDataReader table = cmd.ExecuteReader();

                if (table.HasRows)
                {
                    while (table.Read())
                    {
                        item = new ListViewItem(table["booknum"].ToString());
                        item.SubItems.Add(table["bookname"].ToString());
                        item.SubItems.Add(table["bookpub"].ToString());
                        item.SubItems.Add(table["bookprice"].ToString());
                        listView2.Items.Add(item);
                    }
                    table.Close();
                }
                else
                {
                    MessageBox.Show("그런 도서는 없습니다!");
                }
            }
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            string booknames = null;
            string booknum = null;
            int bookprice = 0;
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select booknum, bookname, bookprice from booklist where bookname = @var1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", textBox1.Text);

                MySqlDataReader table = cmd.ExecuteReader();

                if (table.HasRows)
                {
                    while (table.Read()) { 
                        booknames = table["bookname"].ToString();
                        booknum = table["booknum"].ToString();
                        bookprice = int.Parse(table["bookprice"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("그런 책은 없습니다!");
                    return;
                }
                table.Close();
                sql = "insert into orderlist values(null,@var1,@var2,@var3,@var4,@var5)";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", booknum);
                cmd.Parameters.AddWithValue("@var2", booknames);
                cmd.Parameters.AddWithValue("@var3", UserLogin.memid);
                cmd.Parameters.AddWithValue("@var4",int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@var5", int.Parse(textBox2.Text) * bookprice);

                if (cmd.ExecuteNonQuery() == 0)
                    MessageBox.Show("구입 실패");
                else
                {
                    MessageBox.Show("구입 성공!");
                }

            }
        }

        
    }
}
