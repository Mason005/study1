using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MdiMain : Form
    {
        private string strParameter;

        public MdiMain()
        {
            InitializeComponent();
            this.Load += MdiMain_Load;
            btnFormShow.Click += BtnFormShow_Click;
            btnFormOutShow.Click += BtnFormOutShow_Click;

            strParameter = "안녕 친구여!!!";

        }

        /// <summary>
        /// MdiMain 폼 로드 완료시 실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MdiMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// FormShow 버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFormShow_Click(object sender, EventArgs e)
        {
            // 0. 주으복창이 띠워져있는지 체크
            if(Application.OpenForms["Form1"] is Form1 form1)
            {
                //Form1열려있는 경우
                form1.Focus();
                return;
            }
            //Form1이 열려 있지 않은 경우

            //1. 새로 띠울 Form의 new 객체생성
            form1 = new Form1(strParameter);
            //2. 폼이 름.show();
            form1.MdiParent = this;
            form1.Show();
        }

        /// <summary>
        /// 독립실행으로 열기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFormOutShow_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] is Form1 form1)
            {
                //Form1열려있는 경우
                form1.Close();
            }

            //1. 새로 띠울 Form의 new 객체생성
            form1 = new Form1();
            //2. 폼이 름.show();
            form1.Show();
        }

    }
}
