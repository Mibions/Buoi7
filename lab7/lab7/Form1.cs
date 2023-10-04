using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace lab7
{
    public partial class Form1 : Form
    {
        Data l_dt = new Data();  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thoát thiệt hong dợ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int gt = Convert.ToInt32(txbIn.Text.ToString());
            l_dt.them(gt);
            MessageBox.Show("Dữ liệu đã được thêm thành công!");
        }
        //private void btnShow_Click(object sender, EventArgs e)
        //{
        //    // Hiển thị dữ liệu đã nhập trong ListBox
        //    MessageBox.Show("Dữ liệu đã nhập:\n" + string.Join("\n", listBox.Items.Cast<string>()));
        //}

    }
}
