namespace lab7
{
    partial class HoSo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trVPhongBan = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.TxbAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPB = new System.Windows.Forms.TextBox();
            this.btnAddP = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.cbPB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPB);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDeleteP);
            this.panel1.Controls.Add(this.btnAddP);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.TxbAddress);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.txbPB);
            this.panel1.Controls.Add(this.txbId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trVPhongBan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 329);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng ban";
            // 
            // trVPhongBan
            // 
            this.trVPhongBan.Location = new System.Drawing.Point(15, 36);
            this.trVPhongBan.Name = "trVPhongBan";
            this.trVPhongBan.Size = new System.Drawing.Size(164, 173);
            this.trVPhongBan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(192, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "HỒ SƠ NHÂN VIÊN ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phòng ban";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(256, 54);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(59, 20);
            this.txbId.TabIndex = 7;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(396, 58);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(60, 20);
            this.txbName.TabIndex = 8;
            this.txbName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxbAddress
            // 
            this.TxbAddress.Location = new System.Drawing.Point(257, 86);
            this.TxbAddress.Name = "TxbAddress";
            this.TxbAddress.Size = new System.Drawing.Size(199, 20);
            this.TxbAddress.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(237, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 38);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(343, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 38);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phòng ban";
            // 
            // txbPB
            // 
            this.txbPB.Location = new System.Drawing.Point(82, 223);
            this.txbPB.Name = "txbPB";
            this.txbPB.Size = new System.Drawing.Size(97, 20);
            this.txbPB.TabIndex = 7;
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(82, 249);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(97, 22);
            this.btnAddP.TabIndex = 11;
            this.btnAddP.Text = "Thêm phòng ban";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.Location = new System.Drawing.Point(82, 277);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(97, 22);
            this.btnDeleteP.TabIndex = 11;
            this.btnDeleteP.Text = "Xóa phòng ban";
            this.btnDeleteP.UseVisualStyleBackColor = true;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // cbPB
            // 
            this.cbPB.FormattingEnabled = true;
            this.cbPB.Location = new System.Drawing.Point(256, 117);
            this.cbPB.Name = "cbPB";
            this.cbPB.Size = new System.Drawing.Size(200, 21);
            this.cbPB.TabIndex = 13;
            // 
            // HoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 345);
            this.Controls.Add(this.panel1);
            this.Name = "HoSo";
            this.Text = "HoSo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView trVPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox TxbAddress;
        private System.Windows.Forms.TextBox txbPB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPB;
    }
}