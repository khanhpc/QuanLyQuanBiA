namespace WinFormsApp1.GUI
{
    partial class MenuForm
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
            panel1 = new Panel();
            flpMenu = new FlowLayoutPanel();
            panel3 = new Panel();
            btnSearch = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel8 = new Panel();
            lblTotalPrice = new Label();
            label4 = new Label();
            panel7 = new Panel();
            dgvBill = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            cbTables = new ComboBox();
            label3 = new Label();
            lblDateTime = new Label();
            label1 = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(flpMenu);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 581);
            panel1.TabIndex = 0;
            // 
            // flpMenu
            // 
            flpMenu.AutoScroll = true;
            flpMenu.BorderStyle = BorderStyle.Fixed3D;
            flpMenu.Dock = DockStyle.Bottom;
            flpMenu.Location = new Point(0, 53);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(512, 526);
            flpMenu.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(512, 56);
            panel3.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(389, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 26);
            textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(528, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 581);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.DarkCyan;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(lblTotalPrice);
            panel8.Controls.Add(label4);
            panel8.ForeColor = SystemColors.ControlLightLight;
            panel8.Location = new Point(0, 482);
            panel8.Name = "panel8";
            panel8.Size = new Size(494, 97);
            panel8.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(282, 12);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(121, 22);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "130.000 VNĐ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 12);
            label4.Name = "label4";
            label4.Size = new Size(50, 22);
            label4.TabIndex = 0;
            label4.Text = "Tổng";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(dgvBill);
            panel7.Location = new Point(0, 102);
            panel7.Name = "panel7";
            panel7.Size = new Size(496, 374);
            panel7.TabIndex = 2;
            // 
            // dgvBill
            // 
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.BackgroundColor = SystemColors.WindowFrame;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4 });
            dgvBill.Dock = DockStyle.Fill;
            dgvBill.Location = new Point(0, 0);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.Size = new Size(492, 370);
            dgvBill.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Món";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số Lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Đơn Giá";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Thành Tiền";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkCyan;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(cbTables);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblDateTime);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.ForeColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(494, 98);
            panel5.TabIndex = 0;
            // 
            // cbTables
            // 
            cbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTables.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTables.FormattingEnabled = true;
            cbTables.Location = new Point(244, 27);
            cbTables.Name = "cbTables";
            cbTables.Size = new Size(113, 27);
            cbTables.TabIndex = 5;
            cbTables.SelectedIndexChanged += cbTables_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(191, 32);
            label3.Name = "label3";
            label3.Size = new Size(47, 22);
            label3.TabIndex = 4;
            label3.Text = "Bàn:";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.Location = new Point(3, 38);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(135, 16);
            lblDateTime.TabIndex = 3;
            lblDateTime.Text = "Wednesday, 24/2/2026";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 2;
            label1.Text = "New Order";
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 106);
            panel6.Name = "panel6";
            panel6.Size = new Size(399, 257);
            panel6.TabIndex = 1;
            // 
            // MenuForm
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1024, 581);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "MenuForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel8;
        private Panel panel7;
        private Panel panel5;
        private Panel panel6;
        private ComboBox cbTables;
        private Label label3;
        private Label lblDateTime;
        private Label label1;
        private Button btnSearch;
        private TextBox textBox1;
        private Label lblTotalPrice;
        private Label label4;
        private FlowLayoutPanel flpMenu;
        private DataGridView dgvBill;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
    }
}