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
    public partial class AdminBookProgram : Form
    {
        public string server = "localhost";
        public int port = 3306;
        public string db = "bookselldb";
        public string id = "root";
        public string pw = "1234";
        public string connectAddress = "";
        public static string insertid = "";
        public static string insertname = "";
        public static string insertpw = "";
        public static string insertphone = "";
        public static string insertaddre = "";
        public ListViewItem item;

        public AdminBookProgram()
        {
            InitializeComponent();
        }

        private void booklist_Click(object sender, EventArgs e)
        {
            bookListView1.Items.Clear();
            bookListView1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            bookNumBox.Visible = false;
            bookNameBox.Visible = false;
            bookPubBox.Visible = false;
            bookPriceBox.Visible = false;
            addButton.Visible = false;
            label5.Visible = false;
            removeBookBox.Visible = false;
            removeBookButton.Visible = false;
            removeBookView.Visible = false;
            label6.Visible = false;
            userIdBox.Visible = false;
            userIdSearchButton.Visible = false;
            userInsertButton.Visible = false;
            userRemoveButton.Visible = false;
            userListView.Visible = false;
            orderListView.Visible = false;

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
                    bookListView1.Items.Add(item);
                }
                table.Close();
            }
        }

        private void AdminBookProgram_Load(object sender, EventArgs e)
        {
            connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
            bookListView1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            bookNumBox.Visible = false;
            bookNameBox.Visible = false;
            bookPubBox.Visible = false;
            bookPriceBox.Visible = false;
            addButton.Visible = false;
            label5.Visible = false;
            removeBookBox.Visible = false;
            removeBookButton.Visible = false;
            removeBookView.Visible = false;
            label6.Visible = false;
            userIdBox.Visible = false;
            userIdSearchButton.Visible = false;
            userInsertButton.Visible = false;
            userRemoveButton.Visible = false;
            userListView.Visible = false;
            orderListView.Visible = false;

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
                    bookListView1.Items.Add(item);
                }
                table.Close();
            }
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            bookListView1.Visible = false;
            removeBookView.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            bookNumBox.Visible = true;
            bookNameBox.Visible = true;
            bookPubBox.Visible = true;
            bookPriceBox.Visible = true;
            addButton.Visible = true;
            label5.Visible = false;
            removeBookBox.Visible = false;
            removeBookButton.Visible = false;
            removeBookView.Visible = false;
            label6.Visible = false;
            userIdBox.Visible = false;
            userIdSearchButton.Visible = false;
            userInsertButton.Visible = false;
            userRemoveButton.Visible = false;
            userListView.Visible = false;
            orderListView.Visible = false;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int booknum = int.Parse(bookNumBox.Text);
            string bookname = bookNameBox.Text;
            string bookpub = bookPubBox.Text;
            int bookprice = int.Parse(bookPriceBox.Text);

            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from booklist where booknum = @var1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", booknum);
                MySqlDataReader table = cmd.ExecuteReader();
                if (table.HasRows)
                {
                    MessageBox.Show("책번호가 중복입니다!");
                    table.Close();
                    return;
                }
                else
                {
                    table.Close();
                    sql = "insert into booklist values(@var1,@var2,@var3,@var4)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@var1", booknum);
                    cmd.Parameters.AddWithValue("@var2", bookname);
                    cmd.Parameters.AddWithValue("@var3", bookpub);
                    cmd.Parameters.AddWithValue("@var4", bookprice);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("추가 성공!");
                    }
                    else
                    {
                        MessageBox.Show("추가 실패!");
                    }
                }
            }
        }

        private void removeBook_Click(object sender, EventArgs e)
        {

            bookListView1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            bookNumBox.Visible = false;
            bookNameBox.Visible = false;
            bookPubBox.Visible = false;
            bookPriceBox.Visible = false;
            addButton.Visible = false;
            label6.Visible = false;
            userIdBox.Visible = false;
            userIdSearchButton.Visible = false;
            userInsertButton.Visible = false;
            userRemoveButton.Visible = false;
            userListView.Visible = false;
            orderListView.Visible = false;
            label5.Visible = true;
            removeBookBox.Visible = true;
            removeBookButton.Visible = true;
            removeBookView.Visible = true;
            removeBookView.Items.Clear();

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
                    removeBookView.Items.Add(item);
                }
                table.Close();

                
            }
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from booklist where bookname like @var1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", removeBookBox.Text);
                MySqlDataReader table = cmd.ExecuteReader();

                if (table.HasRows)
                {
                    table.Close();
                    sql = "delete from booklist where bookname like @var1";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@var1", removeBookBox.Text);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("삭제 완료!");
                        removeBookView.Items.Clear();

                        sql = "select * from booklist";
                        cmd = new MySqlCommand(sql, con);
                        table = cmd.ExecuteReader();

                        while (table.Read())
                        {
                            item = new ListViewItem(table["booknum"].ToString());
                            item.SubItems.Add(table["bookname"].ToString());
                            item.SubItems.Add(table["bookpub"].ToString());
                            item.SubItems.Add(table["bookprice"].ToString());
                            removeBookView.Items.Add(item);
                        }
                        table.Close();
                    }
                }
                else
                {
                    MessageBox.Show("그런 책은 없습니다!");
                }
            }
        }

        private void removeBookView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (removeBookView.SelectedItems.Count != 0)
            {
                int selectRow = removeBookView.SelectedItems[0].Index;

                string bookname = removeBookView.Items[selectRow].SubItems[1].Text;
                removeBookBox.Text = bookname;
            }
        }

        private void userIdSearchButton_Click(object sender, EventArgs e)
        {
            string id = userIdBox.Text;
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from memberlist where memid like @var1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", id);
                MySqlDataReader table = cmd.ExecuteReader();

                if (table.HasRows)
                {
                    userListView.Items.Clear();
                    while (table.Read()) { 
                        item = new ListViewItem(table["memid"].ToString());
                        item.SubItems.Add(table["memname"].ToString());
                        item.SubItems.Add(table["mempw"].ToString());
                        item.SubItems.Add(table["memphone"].ToString());
                        item.SubItems.Add(table["memaddre"].ToString());
                        userListView.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("그런 유저는 없습니다!");
                }
                table.Close();
            }
        }

        private void userInsertButton_Click(object sender, EventArgs e)
        {
            string id = userIdBox.Text;
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from memberlist where memid like @var1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@var1", id);
                MySqlDataReader table = cmd.ExecuteReader();

                if (table.HasRows)
                {
                    while (table.Read())
                    {
                        insertid = table["memid"].ToString();
                        insertname = table["memname"].ToString();
                        insertpw = table["mempw"].ToString();
                        insertphone = table["memphone"].ToString();
                        insertaddre = table["memaddre"].ToString();
                        UserInsert ui = new UserInsert();
                        ui.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("그런 유저는 없습니다!");
                }
                table.Close();
            }
        }

        private void userRemoveButton_Click(object sender, EventArgs e)
        {
            string id = userIdBox.Text;
            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제창", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sql = "select * from memberlist where memid like @var1";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@var1", id);
                    MySqlDataReader table = cmd.ExecuteReader();

                    if (table.HasRows)
                    {
                        sql = "delete from memberlist where memid like @var1";
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@var1", id);
                        table.Close();

                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("삭제 성공");

                            sql = "select * from memberlist";
                            cmd = new MySqlCommand(sql, con);
                            table = cmd.ExecuteReader();
                            userListView.Items.Clear();

                            while (table.Read())
                            {
                                item = new ListViewItem(table["memid"].ToString());
                                item.SubItems.Add(table["memname"].ToString());
                                item.SubItems.Add(table["mempw"].ToString());
                                item.SubItems.Add(table["memphone"].ToString());
                                item.SubItems.Add(table["memaddre"].ToString());
                                userListView.Items.Add(item);
                            }
                            table.Close();
                        }
                        else
                        {
                            MessageBox.Show("삭제 실패");
                        }
                    }
                    else
                    {
                        MessageBox.Show("그런 아이디는 없습니다!");
                    }
                }
                
            }
        }

        private void manageMember_Click(object sender, EventArgs e)
        {
            bookListView1.Visible = false;
            removeBookView.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            bookNumBox.Visible = false;
            bookNameBox.Visible = false;
            bookPubBox.Visible = false;
            bookPriceBox.Visible = false;
            addButton.Visible = false;
            label5.Visible = false;
            removeBookBox.Visible = false;
            removeBookButton.Visible = false;
            removeBookView.Visible = false;
            orderListView.Visible = false;
            label6.Visible = true;
            userIdBox.Visible = true;
            userIdSearchButton.Visible = true;
            userInsertButton.Visible = true;
            userRemoveButton.Visible = true;
            userListView.Visible = true;

            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from memberlist";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader table = cmd.ExecuteReader();
                userListView.Items.Clear();

                while (table.Read())
                {
                    item = new ListViewItem(table["memid"].ToString());
                    item.SubItems.Add(table["memname"].ToString());
                    item.SubItems.Add(table["mempw"].ToString());
                    item.SubItems.Add(table["memphone"].ToString());
                    item.SubItems.Add(table["memaddre"].ToString());
                    userListView.Items.Add(item);
                }
                table.Close();


            }
        }

        private void userListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userListView.SelectedItems.Count != 0)
            {
                int selectRow = userListView.SelectedItems[0].Index;

                string bookname = userListView.Items[selectRow].SubItems[0].Text;
                userIdBox.Text = bookname;
            }
        }

        private void sellList_Click(object sender, EventArgs e)
        {
            bookListView1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            bookNumBox.Visible = false;
            bookNameBox.Visible = false;
            bookPubBox.Visible = false;
            bookPriceBox.Visible = false;
            addButton.Visible = false;
            label6.Visible = false;
            userIdBox.Visible = false;
            userIdSearchButton.Visible = false;
            userInsertButton.Visible = false;
            userRemoveButton.Visible = false;
            userListView.Visible = false;
            label5.Visible = false;
            removeBookBox.Visible = false;
            removeBookButton.Visible = false;
            removeBookView.Visible = false;
            orderListView.Visible = true;
            orderListView.Items.Clear();

            using (MySqlConnection con = new MySqlConnection(connectAddress))
            {
                con.Open();
                string sql = "select * from orderlist";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    item = new ListViewItem(table["ordernum"].ToString());
                    item.SubItems.Add(table["booknum"].ToString());
                    item.SubItems.Add(table["bookname"].ToString());
                    item.SubItems.Add(table["memid"].ToString());
                    item.SubItems.Add(table["bookcount"].ToString());
                    item.SubItems.Add(table["bookprice"].ToString());
                    orderListView.Items.Add(item);
                }
                table.Close();
            }
        }

        private void orderListView_DoubleClick(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("구매를 취소시키겠습니까?", "취소창", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connectAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset=utf8", server, port, db, id, pw);
                    using (MySqlConnection con = new MySqlConnection(connectAddress))
                    {
                        con.Open();
                        string sql = "delete from orderlist where ordernum = @var1";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        int selectRow = orderListView.SelectedItems[0].Index;
                        string ordernum = orderListView.Items[selectRow].SubItems[0].Text;
                        cmd.Parameters.AddWithValue("@var1", ordernum);

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("오류 발생!");
                        }
                        else
                        {
                            MessageBox.Show("완료!");
                        }

                        orderListView.Items.Clear();
                        sql = "select * from orderlist";
                        cmd = new MySqlCommand(sql, con);
                        MySqlDataReader table = cmd.ExecuteReader();

                        if (table.HasRows)
                        {
                            while (table.Read())
                            {
                                item = new ListViewItem(table["ordernum"].ToString());
                                item.SubItems.Add(table["booknum"].ToString());
                                item.SubItems.Add(table["bookname"].ToString());
                                item.SubItems.Add(table["memid"].ToString());
                                item.SubItems.Add(table["bookcount"].ToString());
                                item.SubItems.Add(table["bookprice"].ToString());
                                orderListView.Items.Add(item);
                            }
                            table.Close();
                        }
                    }
                }
            }
        }
    }
}
