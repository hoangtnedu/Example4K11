using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            GUI.Form1 form1 = new GUI.Form1();
            form1.ShowDialog();
        }
    }
}
