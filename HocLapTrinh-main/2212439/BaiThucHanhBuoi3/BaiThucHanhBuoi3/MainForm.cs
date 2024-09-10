using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Hi_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap= txtTen.Text;

            MessageBox.Show($"Xin chào bạn {tenDaNhap}. Rất vui được gặp bạn");
        }

        private void btnSaoChep_click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
