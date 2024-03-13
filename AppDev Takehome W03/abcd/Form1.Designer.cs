namespace abcd
{
    partial class Form1
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
            this.tb_usernamelogin = new System.Windows.Forms.TextBox();
            this.tb_passwordlogin = new System.Windows.Forms.TextBox();
            this.lb_ucbank = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.panel_login = new System.Windows.Forms.Panel();
            this.lb_username2 = new System.Windows.Forms.Label();
            this.lb_password2 = new System.Windows.Forms.Label();
            this.lb_ucbank2 = new System.Windows.Forms.Label();
            this.tb_usernameregist = new System.Windows.Forms.TextBox();
            this.tb_passwordregist = new System.Windows.Forms.TextBox();
            this.btn_registernew = new System.Windows.Forms.Button();
            this.panel_register = new System.Windows.Forms.Panel();
            this.panel_mainview = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lb_balance = new System.Windows.Forms.Label();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.lb_ucbank3 = new System.Windows.Forms.Label();
            this.lb_balancetext = new System.Windows.Forms.Label();
            this.panel_deposit = new System.Windows.Forms.Panel();
            this.lb_deposit = new System.Windows.Forms.Label();
            this.tb_deposit = new System.Windows.Forms.TextBox();
            this.btn_logoutdepo = new System.Windows.Forms.Button();
            this.btn_depositdepo = new System.Windows.Forms.Button();
            this.lb_ucbank5 = new System.Windows.Forms.Label();
            this.lb_inputdepo = new System.Windows.Forms.Label();
            this.panel_withdraw = new System.Windows.Forms.Panel();
            this.lb_withdraw = new System.Windows.Forms.Label();
            this.tb_withdraw = new System.Windows.Forms.TextBox();
            this.btn_logoutwd = new System.Windows.Forms.Button();
            this.btn_withdrawwd = new System.Windows.Forms.Button();
            this.lb_ucbank4 = new System.Windows.Forms.Label();
            this.lb_wd = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            this.panel_register.SuspendLayout();
            this.panel_mainview.SuspendLayout();
            this.panel_deposit.SuspendLayout();
            this.panel_withdraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_usernamelogin
            // 
            this.tb_usernamelogin.Location = new System.Drawing.Point(135, 78);
            this.tb_usernamelogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_usernamelogin.Name = "tb_usernamelogin";
            this.tb_usernamelogin.Size = new System.Drawing.Size(148, 26);
            this.tb_usernamelogin.TabIndex = 0;
            // 
            // tb_passwordlogin
            // 
            this.tb_passwordlogin.Location = new System.Drawing.Point(135, 123);
            this.tb_passwordlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_passwordlogin.Name = "tb_passwordlogin";
            this.tb_passwordlogin.Size = new System.Drawing.Size(148, 26);
            this.tb_passwordlogin.TabIndex = 1;
            // 
            // lb_ucbank
            // 
            this.lb_ucbank.AutoSize = true;
            this.lb_ucbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ucbank.Location = new System.Drawing.Point(57, 11);
            this.lb_ucbank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ucbank.Name = "lb_ucbank";
            this.lb_ucbank.Size = new System.Drawing.Size(152, 37);
            this.lb_ucbank.TabIndex = 2;
            this.lb_ucbank.Text = "UC Bank";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(42, 83);
            this.lb_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(87, 20);
            this.lb_username.TabIndex = 3;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(45, 128);
            this.lb_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(82, 20);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(135, 173);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(112, 35);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(135, 221);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(112, 31);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.btn_register);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.lb_password);
            this.panel_login.Controls.Add(this.lb_username);
            this.panel_login.Controls.Add(this.lb_ucbank);
            this.panel_login.Controls.Add(this.tb_passwordlogin);
            this.panel_login.Controls.Add(this.tb_usernamelogin);
            this.panel_login.Location = new System.Drawing.Point(48, 22);
            this.panel_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(320, 278);
            this.panel_login.TabIndex = 7;
            // 
            // lb_username2
            // 
            this.lb_username2.AutoSize = true;
            this.lb_username2.Location = new System.Drawing.Point(48, 83);
            this.lb_username2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username2.Name = "lb_username2";
            this.lb_username2.Size = new System.Drawing.Size(91, 20);
            this.lb_username2.TabIndex = 8;
            this.lb_username2.Text = "Username: ";
            // 
            // lb_password2
            // 
            this.lb_password2.AutoSize = true;
            this.lb_password2.Location = new System.Drawing.Point(48, 123);
            this.lb_password2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_password2.Name = "lb_password2";
            this.lb_password2.Size = new System.Drawing.Size(82, 20);
            this.lb_password2.TabIndex = 9;
            this.lb_password2.Text = "Password:";
            // 
            // lb_ucbank2
            // 
            this.lb_ucbank2.AutoSize = true;
            this.lb_ucbank2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ucbank2.Location = new System.Drawing.Point(57, 26);
            this.lb_ucbank2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ucbank2.Name = "lb_ucbank2";
            this.lb_ucbank2.Size = new System.Drawing.Size(152, 37);
            this.lb_ucbank2.TabIndex = 10;
            this.lb_ucbank2.Text = "UC Bank";
            // 
            // tb_usernameregist
            // 
            this.tb_usernameregist.Location = new System.Drawing.Point(135, 82);
            this.tb_usernameregist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_usernameregist.Name = "tb_usernameregist";
            this.tb_usernameregist.Size = new System.Drawing.Size(148, 26);
            this.tb_usernameregist.TabIndex = 11;
            // 
            // tb_passwordregist
            // 
            this.tb_passwordregist.Location = new System.Drawing.Point(135, 118);
            this.tb_passwordregist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_passwordregist.Name = "tb_passwordregist";
            this.tb_passwordregist.Size = new System.Drawing.Size(148, 26);
            this.tb_passwordregist.TabIndex = 12;
            // 
            // btn_registernew
            // 
            this.btn_registernew.Location = new System.Drawing.Point(103, 175);
            this.btn_registernew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_registernew.Name = "btn_registernew";
            this.btn_registernew.Size = new System.Drawing.Size(112, 35);
            this.btn_registernew.TabIndex = 13;
            this.btn_registernew.Text = "Register";
            this.btn_registernew.UseVisualStyleBackColor = true;
            // 
            // panel_register
            // 
            this.panel_register.Controls.Add(this.btn_registernew);
            this.panel_register.Controls.Add(this.tb_passwordregist);
            this.panel_register.Controls.Add(this.tb_usernameregist);
            this.panel_register.Controls.Add(this.lb_ucbank2);
            this.panel_register.Controls.Add(this.lb_password2);
            this.panel_register.Controls.Add(this.lb_username2);
            this.panel_register.Location = new System.Drawing.Point(503, 360);
            this.panel_register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(320, 278);
            this.panel_register.TabIndex = 14;
            // 
            // panel_mainview
            // 
            this.panel_mainview.Controls.Add(this.btn_logout);
            this.panel_mainview.Controls.Add(this.lb_balance);
            this.panel_mainview.Controls.Add(this.btn_deposit);
            this.panel_mainview.Controls.Add(this.btn_withdraw);
            this.panel_mainview.Controls.Add(this.lb_ucbank3);
            this.panel_mainview.Controls.Add(this.lb_balancetext);
            this.panel_mainview.Location = new System.Drawing.Point(741, 59);
            this.panel_mainview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_mainview.Name = "panel_mainview";
            this.panel_mainview.Size = new System.Drawing.Size(320, 278);
            this.panel_mainview.TabIndex = 15;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(193, 69);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(112, 35);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Location = new System.Drawing.Point(144, 108);
            this.lb_balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(18, 20);
            this.lb_balance.TabIndex = 15;
            this.lb_balance.Text = "0";
            // 
            // btn_deposit
            // 
            this.btn_deposit.Location = new System.Drawing.Point(117, 137);
            this.btn_deposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(112, 35);
            this.btn_deposit.TabIndex = 14;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Location = new System.Drawing.Point(117, 182);
            this.btn_withdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(112, 35);
            this.btn_withdraw.TabIndex = 13;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            // 
            // lb_ucbank3
            // 
            this.lb_ucbank3.AutoSize = true;
            this.lb_ucbank3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ucbank3.Location = new System.Drawing.Point(39, 28);
            this.lb_ucbank3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ucbank3.Name = "lb_ucbank3";
            this.lb_ucbank3.Size = new System.Drawing.Size(152, 37);
            this.lb_ucbank3.TabIndex = 10;
            this.lb_ucbank3.Text = "UC Bank";
            // 
            // lb_balancetext
            // 
            this.lb_balancetext.AutoSize = true;
            this.lb_balancetext.Location = new System.Drawing.Point(42, 105);
            this.lb_balancetext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_balancetext.Name = "lb_balancetext";
            this.lb_balancetext.Size = new System.Drawing.Size(71, 20);
            this.lb_balancetext.TabIndex = 8;
            this.lb_balancetext.Text = "Balance:";
            // 
            // panel_deposit
            // 
            this.panel_deposit.Controls.Add(this.lb_deposit);
            this.panel_deposit.Controls.Add(this.tb_deposit);
            this.panel_deposit.Controls.Add(this.btn_logoutdepo);
            this.panel_deposit.Controls.Add(this.btn_depositdepo);
            this.panel_deposit.Controls.Add(this.lb_ucbank5);
            this.panel_deposit.Controls.Add(this.lb_inputdepo);
            this.panel_deposit.Location = new System.Drawing.Point(398, 59);
            this.panel_deposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_deposit.Name = "panel_deposit";
            this.panel_deposit.Size = new System.Drawing.Size(320, 278);
            this.panel_deposit.TabIndex = 17;
            // 
            // lb_deposit
            // 
            this.lb_deposit.AutoSize = true;
            this.lb_deposit.Location = new System.Drawing.Point(48, 76);
            this.lb_deposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_deposit.Name = "lb_deposit";
            this.lb_deposit.Size = new System.Drawing.Size(18, 20);
            this.lb_deposit.TabIndex = 18;
            this.lb_deposit.Text = "0";
            // 
            // tb_deposit
            // 
            this.tb_deposit.Location = new System.Drawing.Point(105, 140);
            this.tb_deposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_deposit.Name = "tb_deposit";
            this.tb_deposit.Size = new System.Drawing.Size(148, 26);
            this.tb_deposit.TabIndex = 17;
            // 
            // btn_logoutdepo
            // 
            this.btn_logoutdepo.Location = new System.Drawing.Point(189, 69);
            this.btn_logoutdepo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_logoutdepo.Name = "btn_logoutdepo";
            this.btn_logoutdepo.Size = new System.Drawing.Size(112, 35);
            this.btn_logoutdepo.TabIndex = 16;
            this.btn_logoutdepo.Text = "Log Out";
            this.btn_logoutdepo.UseVisualStyleBackColor = true;
            // 
            // btn_depositdepo
            // 
            this.btn_depositdepo.Location = new System.Drawing.Point(118, 180);
            this.btn_depositdepo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_depositdepo.Name = "btn_depositdepo";
            this.btn_depositdepo.Size = new System.Drawing.Size(112, 35);
            this.btn_depositdepo.TabIndex = 14;
            this.btn_depositdepo.Text = "Deposit";
            this.btn_depositdepo.UseVisualStyleBackColor = true;
            // 
            // lb_ucbank5
            // 
            this.lb_ucbank5.AutoSize = true;
            this.lb_ucbank5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ucbank5.Location = new System.Drawing.Point(39, 28);
            this.lb_ucbank5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ucbank5.Name = "lb_ucbank5";
            this.lb_ucbank5.Size = new System.Drawing.Size(152, 37);
            this.lb_ucbank5.TabIndex = 10;
            this.lb_ucbank5.Text = "UC Bank";
            // 
            // lb_inputdepo
            // 
            this.lb_inputdepo.AutoSize = true;
            this.lb_inputdepo.Location = new System.Drawing.Point(100, 115);
            this.lb_inputdepo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_inputdepo.Name = "lb_inputdepo";
            this.lb_inputdepo.Size = new System.Drawing.Size(169, 20);
            this.lb_inputdepo.TabIndex = 8;
            this.lb_inputdepo.Text = "Input Deposit Amount:";
            // 
            // panel_withdraw
            // 
            this.panel_withdraw.Controls.Add(this.lb_withdraw);
            this.panel_withdraw.Controls.Add(this.tb_withdraw);
            this.panel_withdraw.Controls.Add(this.btn_logoutwd);
            this.panel_withdraw.Controls.Add(this.btn_withdrawwd);
            this.panel_withdraw.Controls.Add(this.lb_ucbank4);
            this.panel_withdraw.Controls.Add(this.lb_wd);
            this.panel_withdraw.Location = new System.Drawing.Point(115, 347);
            this.panel_withdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_withdraw.Name = "panel_withdraw";
            this.panel_withdraw.Size = new System.Drawing.Size(320, 278);
            this.panel_withdraw.TabIndex = 18;
            // 
            // lb_withdraw
            // 
            this.lb_withdraw.AutoSize = true;
            this.lb_withdraw.Location = new System.Drawing.Point(60, 77);
            this.lb_withdraw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_withdraw.Name = "lb_withdraw";
            this.lb_withdraw.Size = new System.Drawing.Size(18, 20);
            this.lb_withdraw.TabIndex = 18;
            this.lb_withdraw.Text = "0";
            // 
            // tb_withdraw
            // 
            this.tb_withdraw.Location = new System.Drawing.Point(105, 165);
            this.tb_withdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_withdraw.Name = "tb_withdraw";
            this.tb_withdraw.Size = new System.Drawing.Size(148, 26);
            this.tb_withdraw.TabIndex = 17;
            // 
            // btn_logoutwd
            // 
            this.btn_logoutwd.Location = new System.Drawing.Point(168, 68);
            this.btn_logoutwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_logoutwd.Name = "btn_logoutwd";
            this.btn_logoutwd.Size = new System.Drawing.Size(112, 35);
            this.btn_logoutwd.TabIndex = 16;
            this.btn_logoutwd.Text = "Log Out";
            this.btn_logoutwd.UseVisualStyleBackColor = true;
            this.btn_logoutwd.Click += new System.EventHandler(this.btn_logoutwd_Click);
            // 
            // btn_withdrawwd
            // 
            this.btn_withdrawwd.Location = new System.Drawing.Point(123, 205);
            this.btn_withdrawwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_withdrawwd.Name = "btn_withdrawwd";
            this.btn_withdrawwd.Size = new System.Drawing.Size(112, 35);
            this.btn_withdrawwd.TabIndex = 14;
            this.btn_withdrawwd.Text = "Withdraw";
            this.btn_withdrawwd.UseVisualStyleBackColor = true;
            this.btn_withdrawwd.Click += new System.EventHandler(this.btn_withdrawwd_Click);
            // 
            // lb_ucbank4
            // 
            this.lb_ucbank4.AutoSize = true;
            this.lb_ucbank4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ucbank4.Location = new System.Drawing.Point(39, 28);
            this.lb_ucbank4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ucbank4.Name = "lb_ucbank4";
            this.lb_ucbank4.Size = new System.Drawing.Size(152, 37);
            this.lb_ucbank4.TabIndex = 10;
            this.lb_ucbank4.Text = "UC Bank";
            // 
            // lb_wd
            // 
            this.lb_wd.AutoSize = true;
            this.lb_wd.Location = new System.Drawing.Point(100, 140);
            this.lb_wd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_wd.Name = "lb_wd";
            this.lb_wd.Size = new System.Drawing.Size(180, 20);
            this.lb_wd.TabIndex = 8;
            this.lb_wd.Text = "Input Withdraw Amount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel_withdraw);
            this.Controls.Add(this.panel_deposit);
            this.Controls.Add(this.panel_mainview);
            this.Controls.Add(this.panel_register);
            this.Controls.Add(this.panel_login);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            this.panel_mainview.ResumeLayout(false);
            this.panel_mainview.PerformLayout();
            this.panel_deposit.ResumeLayout(false);
            this.panel_deposit.PerformLayout();
            this.panel_withdraw.ResumeLayout(false);
            this.panel_withdraw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_usernamelogin;
        private System.Windows.Forms.TextBox tb_passwordlogin;
        private System.Windows.Forms.Label lb_ucbank;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label lb_username2;
        private System.Windows.Forms.Label lb_password2;
        private System.Windows.Forms.Label lb_ucbank2;
        private System.Windows.Forms.TextBox tb_usernameregist;
        private System.Windows.Forms.TextBox tb_passwordregist;
        private System.Windows.Forms.Button btn_registernew;
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.Panel panel_mainview;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Label lb_ucbank3;
        private System.Windows.Forms.Label lb_balancetext;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel_deposit;
        private System.Windows.Forms.TextBox tb_deposit;
        private System.Windows.Forms.Button btn_logoutdepo;
        private System.Windows.Forms.Button btn_depositdepo;
        private System.Windows.Forms.Label lb_ucbank5;
        private System.Windows.Forms.Label lb_inputdepo;
        private System.Windows.Forms.Panel panel_withdraw;
        private System.Windows.Forms.TextBox tb_withdraw;
        private System.Windows.Forms.Button btn_logoutwd;
        private System.Windows.Forms.Button btn_withdrawwd;
        private System.Windows.Forms.Label lb_ucbank4;
        private System.Windows.Forms.Label lb_wd;
        private System.Windows.Forms.Label lb_deposit;
        private System.Windows.Forms.Label lb_withdraw;
    }
}
