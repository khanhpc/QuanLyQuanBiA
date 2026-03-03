namespace WinFormsApp1.GUI
{
    partial class ucFoodItem
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
            ptbImage = new PictureBox();
            lblName = new Label();
            lblPrice = new Label();
            btnOrder = new Button();
            nudSoLuong = new NumericUpDown();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ptbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ptbImage
            // 
            ptbImage.BorderStyle = BorderStyle.FixedSingle;
            ptbImage.Dock = DockStyle.Top;
            ptbImage.Location = new Point(0, 0);
            ptbImage.Margin = new Padding(3, 2, 3, 2);
            ptbImage.Name = "ptbImage";
            ptbImage.Size = new Size(130, 131);
            ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImage.TabIndex = 0;
            ptbImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(24, 134);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 19);
            lblName.TabIndex = 1;
            lblName.Text = "Sting";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(15, 153);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(91, 19);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "10,000 VND";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Green;
            btnOrder.Dock = DockStyle.Bottom;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = SystemColors.ControlLightLight;
            btnOrder.Location = new Point(0, 32);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(130, 32);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Đặt";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudSoLuong.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudSoLuong.Location = new Point(29, 3);
            nudSoLuong.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(72, 22);
            nudSoLuong.TabIndex = 4;
            nudSoLuong.TextAlign = HorizontalAlignment.Right;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(nudSoLuong);
            panel1.Controls.Add(btnOrder);
            panel1.Location = new Point(0, 172);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 64);
            panel1.TabIndex = 5;
            // 
            // ucFoodItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(130, 242);
            Controls.Add(panel1);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(ptbImage);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucFoodItem";
            Text = "ucFoodItem";
            ((System.ComponentModel.ISupportInitialize)ptbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbImage;
        private Label lblName;
        private Label lblPrice;
        private Button btnOrder;
        private NumericUpDown nudSoLuong;
        private Panel panel1;
    }
}