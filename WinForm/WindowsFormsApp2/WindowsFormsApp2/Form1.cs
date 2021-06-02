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
    public partial class Form1 : Form
    {
        private string parameter;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string strParameter)
        {
            InitializeComponent();
            Load += Form1_Load;

            parameter = strParameter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHi.Text = parameter;
        }
    }
}
