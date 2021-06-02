using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Owner\Documents\Data5.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from USERINFO where USERNAME='" + Id_txt.Text + "' and PASSWORD='"+Pw_txt.Text+"'", con);

            DataTable newTable = new DataTable();

            sda.Fill(newTable);

            if(newTable.Rows[0][0].ToString() == "1")
            {
                //로그인 성공
                this.Hide();

                MainForm mainForm1 = new MainForm();
                mainForm1.Show();
            }
            else {
                //로그인 실패
                MessageBox.Show("아이디와 패스워드를 확인하세요");
            }



        }
    }
}
