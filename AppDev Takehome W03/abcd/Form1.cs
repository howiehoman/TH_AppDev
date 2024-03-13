using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace abcd
{
    public partial class Form1 : Form
    {
        List<string> databaseusername = new List<string>();
        List<string> databasepassword = new List<string>();
        List<int> uang = new List<int>();
        int jumlahaccount = 0;
        int acclogin = 0;
        CultureInfo culture = new CultureInfo("id-ID");
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel_register.Visible = false;
            panel_mainview.Visible = false;
            panel_deposit.Visible = false;
            panel_withdraw.Visible = false;
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
            panel_register.Visible = true;
        }

        private void btn_register2_Click(object sender, EventArgs e)
        {
            string username = tb_usernameregist.Text;
            string password = tb_passwordregist.Text;
            panel_login.Visible = true;
            panel_register.Visible = false;
            int account = 0;
            for (int i = 0; i < databaseusername.Count; i++)
            {
                if (databaseusername[i] == username)
                {
                    account++;
                }
            }
            if (account == 0)
            {
                MessageBox.Show("Register Successful");
                tb_usernameregist.Clear();
                tb_passwordregist.Clear();
                databaseusername.Add(username);
                databasepassword.Add(password);
                jumlahaccount++;
                uang.Add(0);
            }
            else if (account > 0)
            {
                MessageBox.Show("Username and Password has been used");
                tb_usernameregist.Clear();
                tb_passwordregist.Clear();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (jumlahaccount == 0)
            {
                MessageBox.Show("Username and password not found");
                tb_usernamelogin.Clear();
                tb_passwordlogin.Clear();

            }
            else if (jumlahaccount > 0)
            {
                for (int i = 0; i < databaseusername.Count; i++)
                {
                    if (tb_usernamelogin.Text == databaseusername[i])
                    {
                        if (tb_passwordlogin.Text == databasepassword[i])
                        {
                            MessageBox.Show("Login Successful");
                            panel_mainview.Visible = true;
                            panel_login.Visible = false;
                            acclogin = i;
                            lb_balance.Text = uang[acclogin].ToString("C", culture);
                            lb_deposit.Text = uang[acclogin].ToString("C", culture);
                            lb_withdraw.Text = uang[acclogin].ToString("C", culture);
                        }
                        else
                        {
                            MessageBox.Show("Username and Password not found");
                        }
                    }
                    else
                    {
                        if (databaseusername.Contains(tb_usernamelogin.Text))
                        {

                        }
                        else
                        {
                            MessageBox.Show("Username and Password not found");
                        }
                    }
                }
                tb_usernamelogin.Clear();
                tb_passwordlogin.Clear();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            panel_login.Visible = true;
            panel_mainview.Visible = false;
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            panel_deposit.Visible = true;
            panel_mainview.Visible = false;
        }

        private void btn_deposit2_Click(object sender, EventArgs e)
        {
            int depo = Convert.ToInt32(tb_deposit.Text);
            if (depo > 0)
            {
                MessageBox.Show("Succesfully add deposit");
                uang[acclogin] += depo;
                lb_balance.Text = uang[acclogin].ToString("C", culture);
                lb_deposit.Text = uang[acclogin].ToString("C", culture);
                lb_withdraw.Text = uang[acclogin].ToString("C", culture);
                tb_deposit.Clear();
                panel_deposit.Visible = false;
                panel_mainview.Visible = true;
            }
            else
            {
                MessageBox.Show("Deposit amount can't be less than one!");
                tb_deposit.Clear();
                panel_deposit.Visible = false;
                panel_mainview.Visible = true;
            }
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            panel_withdraw.Visible = true;
            panel_mainview.Visible = false;
        }

        private void btn_logout2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            panel_login.Visible = true;
            panel_deposit.Visible = false;
        }

        private void btn_logoutwd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            panel_login.Visible = true;
            panel_withdraw.Visible = false;
        }

        private void btn_withdrawwd_Click(object sender, EventArgs e)
        {
            int wd = Convert.ToInt32(tb_withdraw.Text);
            if (wd > 0)
            {
                MessageBox.Show("Succesfully add deposit");
                uang[acclogin] += wd;
                lb_balance.Text = uang[acclogin].ToString("C", culture);
                lb_deposit.Text = uang[acclogin].ToString("C", culture);
                lb_withdraw.Text = uang[acclogin].ToString("C", culture);
                tb_withdraw.Clear();
                panel_withdraw.Visible = false;
                panel_mainview.Visible = true;
            }
            else
            {
                MessageBox.Show("Deposit amount can't be less than one!");
                tb_withdraw.Clear();
                panel_withdraw.Visible = false;
                panel_mainview.Visible = true;
            }
        }
    }
}