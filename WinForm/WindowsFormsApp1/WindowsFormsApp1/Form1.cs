using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnWinform.Click += BtnWinform_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 항목 이름.속성 = 값
            BtnWinform.Height = 200;
            //BtnWinform.Cursor = Cursors.AppStarting;
        }

        private void BtnWinform_Click(object sender, EventArgs e)
        {
            BtnWinform.Enabled = false;
        }
    }
}
