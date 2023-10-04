using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class HoSo : Form
    {
        public HoSo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void TreeView_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế toán" };
            foreach(string s in pb)
            {
                trVPhongBan.Nodes.Add(s);
                cbPB.Items.Add(s);
            }
            cbPB.SelectedIndex = 0;
        }

        private bool ktra(TreeView tv, string c)
        {
            foreach (TreeNode node in tv.Nodes)
            {
                if(ktraGT(node, c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ktraGT(TreeNode node, string c)
        {
            if(node.Text == c)
            {
                return true;
            }
            foreach (TreeNode item in node.Nodes)
            {
                return true;
            }
            return false;
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            if (ktra(trVPhongBan, txbPB.Text))
            {
                trVPhongBan.Nodes.Add(txbPB.Text);
                cbPB.Items.Add(txbPB.Text);
            }
            else
            {
                MessageBox.Show("Phòng ban đã tồn tại!");
            }
            txbPB.Text = "";
            txbPB.Focus();
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                if(trVPhongBan.SelectedNode != null)
                {
                    cbPB.Items.Remove(trVPhongBan.SelectedNode.Text);
                    trVPhongBan.Nodes.Remove(trVPhongBan.SelectedNode);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in trVPhongBan.Nodes)
            {
                if(node.Text == cbPB.Text)
                {
                    index = node.Index;
                    break;
                }
                trVPhongBan.Nodes[index].Nodes.Add(txbName.Text + "(" + txbId.Text + ")");
                trVPhongBan.ExpandAll();
            }
        }

        
    }
}
