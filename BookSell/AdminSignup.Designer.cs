
namespace BookSell
{
    partial class AdminSignup
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
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pwLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(135, 161);
            this.pwTextBox.Multiline = true;
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(154, 21);
            this.pwTextBox.TabIndex = 11;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(135, 89);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(154, 21);
            this.idTextBox.TabIndex = 10;
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwLabel.Location = new System.Drawing.Point(44, 161);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(74, 21);
            this.pwLabel.TabIndex = 9;
            this.pwLabel.Text = "비밀번호";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idLabel.Location = new System.Drawing.Point(60, 88);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(58, 21);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "아아디";
            // 
            // Signup
            // 
            this.Signup.Location = new System.Drawing.Point(48, 235);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(102, 34);
            this.Signup.TabIndex = 12;
            this.Signup.Text = "관리자등록";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(187, 235);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(102, 34);
            this.Back.TabIndex = 13;
            this.Back.Text = "이전으로";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AdminSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 333);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "AdminSignup";
            this.Text = "관리자등록";
            this.Load += new System.EventHandler(this.AdminSignup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button Back;
    }
}