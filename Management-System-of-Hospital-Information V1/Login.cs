using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); 
            this.CenterToScreen();
            this.Load += new EventHandler(Login_Load);
            this.btnOut.Click += new EventHandler(btnOut_Click);
            this.btnIn.Click += new EventHandler(btnIn_Click);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtUsername.Focus();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("�������û���!");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("����������!");
                return;
            }

            SqlDataReader rs = null;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = SqlHelper.constr;
            
            try
            {
                string sql = String.Format("SELECT [ID],[Username],[Password] From Admin WHERE Username='{0}'", txtUsername.Text);
                rs = SqlHelper.ExecuteReader(con, CommandType.Text, sql);
                if (!rs.Read())
                {
                    MessageBox.Show("�û���������!");
                    return;
                }
                else if ((string)rs["Password"] != txtPassword.Text)
                {
                    MessageBox.Show("�������!");
                    return;
                }
                else
                {
                    MainFrm mainFrm = new MainFrm();
                    mainFrm.UserName = rs["Username"].ToString();
                    mainFrm.Text = mainFrm.Text +"||��ǰ�û���" +mainFrm.UserName;
                    mainFrm.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtPassword.Text = "";
                rs.Close();
            }
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}