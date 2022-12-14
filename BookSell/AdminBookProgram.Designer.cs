
namespace BookSell
{
    partial class AdminBookProgram
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
            this.booklist = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.removeBook = new System.Windows.Forms.Button();
            this.manageMember = new System.Windows.Forms.Button();
            this.sellList = new System.Windows.Forms.Button();
            this.bookListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookNumBox = new System.Windows.Forms.TextBox();
            this.bookNameBox = new System.Windows.Forms.TextBox();
            this.bookPubBox = new System.Windows.Forms.TextBox();
            this.bookPriceBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.removeBookBox = new System.Windows.Forms.TextBox();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.removeBookView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.userIdSearchButton = new System.Windows.Forms.Button();
            this.userInsertButton = new System.Windows.Forms.Button();
            this.userRemoveButton = new System.Windows.Forms.Button();
            this.userListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderListView = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // booklist
            // 
            this.booklist.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.booklist.Location = new System.Drawing.Point(12, 12);
            this.booklist.Name = "booklist";
            this.booklist.Size = new System.Drawing.Size(178, 63);
            this.booklist.TabIndex = 0;
            this.booklist.Text = "도서조회";
            this.booklist.UseVisualStyleBackColor = true;
            this.booklist.Click += new System.EventHandler(this.booklist_Click);
            // 
            // addBook
            // 
            this.addBook.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addBook.Location = new System.Drawing.Point(13, 112);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(178, 63);
            this.addBook.TabIndex = 1;
            this.addBook.Text = "도서추가";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // removeBook
            // 
            this.removeBook.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.removeBook.Location = new System.Drawing.Point(13, 222);
            this.removeBook.Name = "removeBook";
            this.removeBook.Size = new System.Drawing.Size(178, 63);
            this.removeBook.TabIndex = 2;
            this.removeBook.Text = "도서삭제";
            this.removeBook.UseVisualStyleBackColor = true;
            this.removeBook.Click += new System.EventHandler(this.removeBook_Click);
            // 
            // manageMember
            // 
            this.manageMember.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.manageMember.Location = new System.Drawing.Point(12, 342);
            this.manageMember.Name = "manageMember";
            this.manageMember.Size = new System.Drawing.Size(178, 63);
            this.manageMember.TabIndex = 3;
            this.manageMember.Text = "회원관리";
            this.manageMember.UseVisualStyleBackColor = true;
            this.manageMember.Click += new System.EventHandler(this.manageMember_Click);
            // 
            // sellList
            // 
            this.sellList.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellList.Location = new System.Drawing.Point(12, 451);
            this.sellList.Name = "sellList";
            this.sellList.Size = new System.Drawing.Size(178, 63);
            this.sellList.TabIndex = 4;
            this.sellList.Text = "판매현황";
            this.sellList.UseVisualStyleBackColor = true;
            this.sellList.Click += new System.EventHandler(this.sellList_Click);
            // 
            // bookListView1
            // 
            this.bookListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.bookListView1.HideSelection = false;
            this.bookListView1.Location = new System.Drawing.Point(212, 12);
            this.bookListView1.Name = "bookListView1";
            this.bookListView1.Size = new System.Drawing.Size(634, 502);
            this.bookListView1.TabIndex = 5;
            this.bookListView1.UseCompatibleStateImageBehavior = false;
            this.bookListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "책번호";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "책이름";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "저자";
            this.columnHeader3.Width = 181;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "가격";
            this.columnHeader4.Width = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(327, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "책번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(327, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "책이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(342, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(342, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "저자";
            // 
            // bookNumBox
            // 
            this.bookNumBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookNumBox.Location = new System.Drawing.Point(406, 82);
            this.bookNumBox.Name = "bookNumBox";
            this.bookNumBox.Size = new System.Drawing.Size(93, 27);
            this.bookNumBox.TabIndex = 10;
            // 
            // bookNameBox
            // 
            this.bookNameBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookNameBox.Location = new System.Drawing.Point(406, 173);
            this.bookNameBox.Name = "bookNameBox";
            this.bookNameBox.Size = new System.Drawing.Size(239, 27);
            this.bookNameBox.TabIndex = 11;
            // 
            // bookPubBox
            // 
            this.bookPubBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookPubBox.Location = new System.Drawing.Point(406, 265);
            this.bookPubBox.Name = "bookPubBox";
            this.bookPubBox.Size = new System.Drawing.Size(93, 27);
            this.bookPubBox.TabIndex = 12;
            // 
            // bookPriceBox
            // 
            this.bookPriceBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookPriceBox.Location = new System.Drawing.Point(406, 363);
            this.bookPriceBox.Name = "bookPriceBox";
            this.bookPriceBox.Size = new System.Drawing.Size(93, 27);
            this.bookPriceBox.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(346, 432);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(500, 36);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "도서추가";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(281, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "책이름";
            // 
            // removeBookBox
            // 
            this.removeBookBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.removeBookBox.Location = new System.Drawing.Point(360, 31);
            this.removeBookBox.Name = "removeBookBox";
            this.removeBookBox.Size = new System.Drawing.Size(258, 27);
            this.removeBookBox.TabIndex = 16;
            // 
            // removeBookButton
            // 
            this.removeBookButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.removeBookButton.Location = new System.Drawing.Point(636, 31);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(111, 27);
            this.removeBookButton.TabIndex = 17;
            this.removeBookButton.Text = "삭제";
            this.removeBookButton.UseVisualStyleBackColor = true;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // removeBookView
            // 
            this.removeBookView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.removeBookView.HideSelection = false;
            this.removeBookView.Location = new System.Drawing.Point(212, 112);
            this.removeBookView.Name = "removeBookView";
            this.removeBookView.Size = new System.Drawing.Size(634, 402);
            this.removeBookView.TabIndex = 18;
            this.removeBookView.UseCompatibleStateImageBehavior = false;
            this.removeBookView.View = System.Windows.Forms.View.Details;
            this.removeBookView.SelectedIndexChanged += new System.EventHandler(this.removeBookView_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "책번호";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "책이름";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "저자";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "가격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(281, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "유저ID";
            // 
            // userIdBox
            // 
            this.userIdBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdBox.Location = new System.Drawing.Point(360, 30);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(258, 27);
            this.userIdBox.TabIndex = 20;
            // 
            // userIdSearchButton
            // 
            this.userIdSearchButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIdSearchButton.Location = new System.Drawing.Point(625, 30);
            this.userIdSearchButton.Name = "userIdSearchButton";
            this.userIdSearchButton.Size = new System.Drawing.Size(55, 27);
            this.userIdSearchButton.TabIndex = 21;
            this.userIdSearchButton.Text = "검색";
            this.userIdSearchButton.UseVisualStyleBackColor = true;
            this.userIdSearchButton.Click += new System.EventHandler(this.userIdSearchButton_Click);
            // 
            // userInsertButton
            // 
            this.userInsertButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userInsertButton.Location = new System.Drawing.Point(692, 30);
            this.userInsertButton.Name = "userInsertButton";
            this.userInsertButton.Size = new System.Drawing.Size(55, 27);
            this.userInsertButton.TabIndex = 22;
            this.userInsertButton.Text = "수정";
            this.userInsertButton.UseVisualStyleBackColor = true;
            this.userInsertButton.Click += new System.EventHandler(this.userInsertButton_Click);
            // 
            // userRemoveButton
            // 
            this.userRemoveButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userRemoveButton.Location = new System.Drawing.Point(756, 30);
            this.userRemoveButton.Name = "userRemoveButton";
            this.userRemoveButton.Size = new System.Drawing.Size(55, 27);
            this.userRemoveButton.TabIndex = 23;
            this.userRemoveButton.Text = "삭제";
            this.userRemoveButton.UseVisualStyleBackColor = true;
            this.userRemoveButton.Click += new System.EventHandler(this.userRemoveButton_Click);
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(212, 112);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(634, 402);
            this.userListView.TabIndex = 24;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.SelectedIndexChanged += new System.EventHandler(this.userListView_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 131;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "이름";
            this.columnHeader10.Width = 131;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "PW";
            this.columnHeader11.Width = 123;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "휴대폰";
            this.columnHeader12.Width = 139;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "주소";
            this.columnHeader13.Width = 104;
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(212, 12);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(634, 502);
            this.orderListView.TabIndex = 25;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            this.orderListView.DoubleClick += new System.EventHandler(this.orderListView_DoubleClick);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "주문번";
            this.columnHeader14.Width = 126;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "책번호";
            this.columnHeader15.Width = 128;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "책이름";
            this.columnHeader16.Width = 114;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "사용자ID";
            this.columnHeader17.Width = 101;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "구매갯수";
            this.columnHeader18.Width = 82;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "가격";
            this.columnHeader19.Width = 80;
            // 
            // AdminBookProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 526);
            this.Controls.Add(this.orderListView);
            this.Controls.Add(this.userListView);
            this.Controls.Add(this.userRemoveButton);
            this.Controls.Add(this.userInsertButton);
            this.Controls.Add(this.userIdSearchButton);
            this.Controls.Add(this.userIdBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.removeBookView);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.removeBookBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bookPriceBox);
            this.Controls.Add(this.bookPubBox);
            this.Controls.Add(this.bookNameBox);
            this.Controls.Add(this.bookNumBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookListView1);
            this.Controls.Add(this.sellList);
            this.Controls.Add(this.manageMember);
            this.Controls.Add(this.removeBook);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.booklist);
            this.Name = "AdminBookProgram";
            this.Text = "AdminBookProgram";
            this.Load += new System.EventHandler(this.AdminBookProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button booklist;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button removeBook;
        private System.Windows.Forms.Button manageMember;
        private System.Windows.Forms.Button sellList;
        private System.Windows.Forms.ListView bookListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookNumBox;
        private System.Windows.Forms.TextBox bookNameBox;
        private System.Windows.Forms.TextBox bookPubBox;
        private System.Windows.Forms.TextBox bookPriceBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox removeBookBox;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.ListView removeBookView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.Button userIdSearchButton;
        private System.Windows.Forms.Button userInsertButton;
        private System.Windows.Forms.Button userRemoveButton;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
    }
}