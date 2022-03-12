using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo.GUI
{
    public partial class Form2 : Form
    {
        string strRecei;
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="str"> dữ liệu nhận từ form1</param>
        public Form2(string str)
        {
            strRecei = str;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblRecei.Text = strRecei;
        }
    }
}
