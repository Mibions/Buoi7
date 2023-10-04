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
        List_int l_int = new List_int();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int them = Convert.ToInt32(textBox1.Text.ToString());
            l_int.ThemGiaTri(them);
            MessageBox.Show("Thêm giá trị thành công.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            int timkiem = Convert.ToInt32(textBox1.Text.ToString());
            if (l_int.TimKiemGiaTri(timkiem))
            {
                MessageBox.Show("Giá trị đã được tìm thấy trong danh sách.");
            }
            else
            {
                MessageBox.Show("Giá trị không tồn tại trong danh sách.");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = l_int;
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PropertyName"; // Đặt tên thuộc tính muốn hiển thị (trong trường hợp này là "PropertyName")
            column.HeaderText = "Column Name"; // Đặt tên cho cột trên DataGridView
            dataGridView1.Columns.Add(column);

        }
    }
}
